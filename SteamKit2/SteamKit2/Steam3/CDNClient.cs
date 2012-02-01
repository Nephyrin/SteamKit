﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace SteamKit2
{
    public class CDNClient
    {
        public class ClientEndPoint
        {
            public string Host;
            public int Port;
            public string Type;

            public ClientEndPoint(string host, int port)
            {
                Host = host;
                Port = port;
            }

            public ClientEndPoint(string host, int port, string type) : this(host, port)
            {
                Type = type;
            }
        }

        private WebClient webClient;
        private byte[] sessionKey;

        private ulong sessionID;
        private long reqcounter;

        private ClientEndPoint endPoint;
        private byte[] appTicket;

        static CDNClient()
        {
            ServicePointManager.Expect100Continue = false;
        }

        public CDNClient(ClientEndPoint cdnServer, byte[] appticket)
        {
            sessionKey = CryptoHelper.GenerateRandomBlock(32);

            webClient = new WebClient();

            endPoint = cdnServer;
            appTicket = appticket;
        }

        ~CDNClient()
        {
            webClient.Dispose();
        }

        public void PointTo(ClientEndPoint ep)
        {
            endPoint = ep;
        }

        public bool Connect()
        {
            byte[] encryptedKey = CryptoHelper.RSAEncrypt(sessionKey);
            byte[] encryptedTicket = CryptoHelper.SymmetricEncrypt(appTicket, sessionKey);

            string payload = String.Format("sessionkey={0}&appticket={1}", WebHelpers.UrlEncode(encryptedKey), WebHelpers.UrlEncode(encryptedTicket));

            webClient.Headers.Clear();
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            string response;
            try
            {
                response = webClient.UploadString(BuildCommand(endPoint, "initsession"), payload);
            }
            catch (WebException)
            {
                return false;
            }

            var responsekv = KeyValue.LoadFromString(response);
            var sessionidn = responsekv.Children.Where(c => c.Name == "sessionid").First();
            var reqcountern = responsekv.Children.Where(c => c.Name == "req-counter").First();

            sessionID = (ulong)(sessionidn.AsLong(0));
            reqcounter = reqcountern.AsLong(0);

            try
            {
                AuthDepot();
            }
            catch (WebException)
            {
                return false;
            }

            return true;
        }

        public byte[] DownloadDepotManifest(int depotid, ulong manifestid)
        {
            Uri manifestURI = new Uri(BuildCommand(endPoint, "depot"), String.Format("{0}/manifest/{1}", depotid, manifestid));

            PrepareAuthHeader(ref webClient, manifestURI);

            byte[] compressedManifest;
            byte[] manifest;
            try
            {
                compressedManifest = webClient.DownloadData(manifestURI);
            }
            catch (WebException)
            {
                return null;
            }

            try
            {
                manifest = ZipUtil.Decompress(compressedManifest);
            }
            catch (Exception)
            {
                return null;
            }

            return manifest;
        }

        public byte[] DownloadDepotChunk(int depotid, string chunkid)
        {
            Uri chunkURI = new Uri(BuildCommand(endPoint, "depot"), String.Format("{0}/chunk/{1}", depotid, chunkid));

            PrepareAuthHeader(ref webClient, chunkURI);

            byte[] chunk;
            try
            {
                chunk = webClient.DownloadData(chunkURI);
            }
            catch (WebException)
            {
                return null;
            }

            return chunk;
        }

        public byte[] ProcessChunk(byte[] chunk, byte[] depotkey)
        {
            byte[] decrypted_chunk = CryptoHelper.SymmetricDecrypt(chunk, depotkey);
            byte[] decompressed_chunk = ZipUtil.Decompress(decrypted_chunk);

            return decompressed_chunk;
        }

        private void AuthDepot()
        {
            Uri authURI = BuildCommand(endPoint, "authdepot");

            PrepareAuthHeader(ref webClient, authURI);
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            byte[] encryptedTicket = CryptoHelper.SymmetricEncrypt(appTicket, sessionKey);
            string payload = String.Format("appticket={0}", WebHelpers.UrlEncode(encryptedTicket));

            string response = webClient.UploadString(authURI, payload);
        }

        private void PrepareAuthHeader(ref WebClient client, Uri uri)
        {
            reqcounter++;

            byte[] sha_hash;

            BinaryWriterEx bb = new BinaryWriterEx();

            bb.Write( sessionID );
            bb.Write( reqcounter );
            bb.Write( sessionKey );
            bb.Write( Encoding.ASCII.GetBytes( uri.AbsolutePath ) );

            sha_hash = CryptoHelper.SHAHash(bb.ToArray());

            string hex_hash = Utils.EncodeHexString(sha_hash);

            string authheader = String.Format("sessionid={0};req-counter={1};hash={2};", sessionID, reqcounter, hex_hash);

            webClient.Headers.Clear();
            webClient.Headers.Add("x-steam-auth", authheader);
        }

        private static Uri BuildCommand(ClientEndPoint csServer, string command)
        {
            return new Uri(String.Format("http://{0}:{1}/{2}/", csServer.Host, csServer.Port.ToString(), command));
        }

        public static List<ClientEndPoint> FetchServerList(ClientEndPoint csServer, int cellID)
        {
            int serversToRequest = 20;

            using(WebClient webClient = new WebClient())
            {
                Uri request = new Uri(BuildCommand(csServer, "serverlist"), String.Format("{0}/{1}/", cellID, serversToRequest));

                string serverList;
                try
                {
                    serverList = webClient.DownloadString(request);
                }
                catch (WebException e)
                {
                    Console.WriteLine("FetchServerList returned: {0}", e.Message);
                    return null;
                }

                KeyValue serverkv = KeyValue.LoadFromString(serverList);

                if (serverkv["deferred"].AsString() == "1")
                    return null;

                List<ClientEndPoint> endpoints = new List<ClientEndPoint>();

                foreach (var child in serverkv.Children)
                {
                    var node = child.Children.Where(x => x.Name == "host" || x.Name == "Host").First();
                    var typeNode = child.Children.Where(x => x.Name == "type").First();

                    var endpoint_string = node.Value.Split(':');

                    int port = 80;
                    
                    if(endpoint_string.Length > 1)
                        port = int.Parse(endpoint_string[1]);

                    endpoints.Add(new ClientEndPoint(endpoint_string[0], port, typeNode.AsString()));
                }

                return endpoints;
            }
        }
    }
}
