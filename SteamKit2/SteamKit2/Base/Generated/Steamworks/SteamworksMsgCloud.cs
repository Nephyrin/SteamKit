//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_cloud.steamworkssdk.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamworkssdk.proto
namespace SteamKit2.Steamworks
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetUploadServerInfo_Request")]
  public partial class CCloud_GetUploadServerInfo_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_GetUploadServerInfo_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetUploadServerInfo_Response")]
  public partial class CCloud_GetUploadServerInfo_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_GetUploadServerInfo_Response() {}
    

    private string _server_url = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"server_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string server_url
    {
      get { return _server_url; }
      set { _server_url = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetFileDetails_Request")]
  public partial class CCloud_GetFileDetails_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_GetFileDetails_Request() {}
    

    private ulong _ugcid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ugcid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ugcid
    {
      get { return _ugcid; }
      set { _ugcid = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_UserFile")]
  public partial class CCloud_UserFile : global::ProtoBuf.IExtensible
  {
    public CCloud_UserFile() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _ugcid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ugcid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong ugcid
    {
      get { return _ugcid; }
      set { _ugcid = value; }
    }

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private ulong _timestamp = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }

    private uint _file_size = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"file_size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint file_size
    {
      get { return _file_size; }
      set { _file_size = value; }
    }

    private string _url = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string url
    {
      get { return _url; }
      set { _url = value; }
    }

    private ulong _steamid_creator = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"steamid_creator", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid_creator
    {
      get { return _steamid_creator; }
      set { _steamid_creator = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_GetFileDetails_Response")]
  public partial class CCloud_GetFileDetails_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_GetFileDetails_Response() {}
    

    private CCloud_UserFile _details = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"details", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CCloud_UserFile details
    {
      get { return _details; }
      set { _details = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_EnumerateUserFiles_Request")]
  public partial class CCloud_EnumerateUserFiles_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_EnumerateUserFiles_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private bool _extended_details = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"extended_details", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool extended_details
    {
      get { return _extended_details; }
      set { _extended_details = value; }
    }

    private uint _count = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }

    private uint _start_index = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"start_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint start_index
    {
      get { return _start_index; }
      set { _start_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_EnumerateUserFiles_Response")]
  public partial class CCloud_EnumerateUserFiles_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_EnumerateUserFiles_Response() {}
    
    private readonly global::System.Collections.Generic.List<CCloud_UserFile> _files = new global::System.Collections.Generic.List<CCloud_UserFile>();
    [global::ProtoBuf.ProtoMember(1, Name=@"files", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CCloud_UserFile> files
    {
      get { return _files; }
    }
  

    private uint _total_files = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"total_files", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint total_files
    {
      get { return _total_files; }
      set { _total_files = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_Delete_Request")]
  public partial class CCloud_Delete_Request : global::ProtoBuf.IExtensible
  {
    public CCloud_Delete_Request() {}
    

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCloud_Delete_Response")]
  public partial class CCloud_Delete_Response : global::ProtoBuf.IExtensible
  {
    public CCloud_Delete_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ICloud
    {
      CCloud_GetUploadServerInfo_Response GetUploadServerInfo(CCloud_GetUploadServerInfo_Request request);
    CCloud_GetFileDetails_Response GetFileDetails(CCloud_GetFileDetails_Request request);
    CCloud_EnumerateUserFiles_Response EnumerateUserFiles(CCloud_EnumerateUserFiles_Request request);
    CCloud_Delete_Response Delete(CCloud_Delete_Request request);
    
    }
    
    
}
#pragma warning restore 1591
