// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSceneMapInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSceneMapInfoScRsp.proto</summary>
  public static partial class GetSceneMapInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSceneMapInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSceneMapInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHZXRTY2VuZU1hcEluZm9TY1JzcC5wcm90bxoRTWF6ZU1hcERhdGEucHJv",
            "dG8aD01hemVHcm91cC5wcm90bxoPTWF6ZUNoZXN0LnByb3RvGg5NYXplUHJv",
            "cC5wcm90byKiAgoUR2V0U2NlbmVNYXBJbmZvU2NSc3ASHgoWdW5sb2NrZWRf",
            "dGVsZXBvcnRfbGlzdBgNIAMoDRIcChRsaWdodGVuX3NlY3Rpb25fbGlzdBgE",
            "IAMoDRIYChBjdXJfbWFwX2VudHJ5X2lkGAkgASgNEh4KCG1hcF9saXN0GA4g",
            "AygLMgwuTWF6ZU1hcERhdGESJwoTdW5sb2NrZWRfY2hlc3RfbGlzdBgMIAMo",
            "CzIKLk1hemVDaGVzdBIjCg9tYXplX2dyb3VwX2xpc3QYDyADKAsyCi5NYXpl",
            "R3JvdXASDwoHcmV0Y29kZRgIIAEoDRIhCg5tYXplX3Byb3BfbGlzdBgHIAMo",
            "CzIJLk1hemVQcm9wEhAKCGVudHJ5X2lkGAogASgNQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MazeMapDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazeGroupReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazeChestReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazePropReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSceneMapInfoScRsp), global::EggLink.DanhengServer.Proto.GetSceneMapInfoScRsp.Parser, new[]{ "UnlockedTeleportList", "LightenSectionList", "CurMapEntryId", "MapList", "UnlockedChestList", "MazeGroupList", "Retcode", "MazePropList", "EntryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSceneMapInfoScRsp : pb::IMessage<GetSceneMapInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSceneMapInfoScRsp> _parser = new pb::MessageParser<GetSceneMapInfoScRsp>(() => new GetSceneMapInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSceneMapInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSceneMapInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoScRsp(GetSceneMapInfoScRsp other) : this() {
      unlockedTeleportList_ = other.unlockedTeleportList_.Clone();
      lightenSectionList_ = other.lightenSectionList_.Clone();
      curMapEntryId_ = other.curMapEntryId_;
      mapList_ = other.mapList_.Clone();
      unlockedChestList_ = other.unlockedChestList_.Clone();
      mazeGroupList_ = other.mazeGroupList_.Clone();
      retcode_ = other.retcode_;
      mazePropList_ = other.mazePropList_.Clone();
      entryId_ = other.entryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSceneMapInfoScRsp Clone() {
      return new GetSceneMapInfoScRsp(this);
    }

    /// <summary>Field number for the "unlocked_teleport_list" field.</summary>
    public const int UnlockedTeleportListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedTeleportList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> unlockedTeleportList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedTeleportList {
      get { return unlockedTeleportList_; }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    /// <summary>Field number for the "cur_map_entry_id" field.</summary>
    public const int CurMapEntryIdFieldNumber = 9;
    private uint curMapEntryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurMapEntryId {
      get { return curMapEntryId_; }
      set {
        curMapEntryId_ = value;
      }
    }

    /// <summary>Field number for the "map_list" field.</summary>
    public const int MapListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeMapData> _repeated_mapList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.MazeMapData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeMapData> mapList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeMapData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeMapData> MapList {
      get { return mapList_; }
    }

    /// <summary>Field number for the "unlocked_chest_list" field.</summary>
    public const int UnlockedChestListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeChest> _repeated_unlockedChestList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.MazeChest.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeChest> unlockedChestList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeChest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeChest> UnlockedChestList {
      get { return unlockedChestList_; }
    }

    /// <summary>Field number for the "maze_group_list" field.</summary>
    public const int MazeGroupListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeGroup> _repeated_mazeGroupList_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.MazeGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup> mazeGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup> MazeGroupList {
      get { return mazeGroupList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "maze_prop_list" field.</summary>
    public const int MazePropListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeProp> _repeated_mazePropList_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.MazeProp.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeProp> mazePropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeProp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeProp> MazePropList {
      get { return mazePropList_; }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 10;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSceneMapInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSceneMapInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockedTeleportList_.Equals(other.unlockedTeleportList_)) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      if (CurMapEntryId != other.CurMapEntryId) return false;
      if(!mapList_.Equals(other.mapList_)) return false;
      if(!unlockedChestList_.Equals(other.unlockedChestList_)) return false;
      if(!mazeGroupList_.Equals(other.mazeGroupList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!mazePropList_.Equals(other.mazePropList_)) return false;
      if (EntryId != other.EntryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockedTeleportList_.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
      if (CurMapEntryId != 0) hash ^= CurMapEntryId.GetHashCode();
      hash ^= mapList_.GetHashCode();
      hash ^= unlockedChestList_.GetHashCode();
      hash ^= mazeGroupList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= mazePropList_.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      mazePropList_.WriteTo(output, _repeated_mazePropList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (CurMapEntryId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurMapEntryId);
      }
      if (EntryId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EntryId);
      }
      unlockedChestList_.WriteTo(output, _repeated_unlockedChestList_codec);
      unlockedTeleportList_.WriteTo(output, _repeated_unlockedTeleportList_codec);
      mapList_.WriteTo(output, _repeated_mapList_codec);
      mazeGroupList_.WriteTo(output, _repeated_mazeGroupList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      mazePropList_.WriteTo(ref output, _repeated_mazePropList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      if (CurMapEntryId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurMapEntryId);
      }
      if (EntryId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EntryId);
      }
      unlockedChestList_.WriteTo(ref output, _repeated_unlockedChestList_codec);
      unlockedTeleportList_.WriteTo(ref output, _repeated_unlockedTeleportList_codec);
      mapList_.WriteTo(ref output, _repeated_mapList_codec);
      mazeGroupList_.WriteTo(ref output, _repeated_mazeGroupList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unlockedTeleportList_.CalculateSize(_repeated_unlockedTeleportList_codec);
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      if (CurMapEntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurMapEntryId);
      }
      size += mapList_.CalculateSize(_repeated_mapList_codec);
      size += unlockedChestList_.CalculateSize(_repeated_unlockedChestList_codec);
      size += mazeGroupList_.CalculateSize(_repeated_mazeGroupList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += mazePropList_.CalculateSize(_repeated_mazePropList_codec);
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSceneMapInfoScRsp other) {
      if (other == null) {
        return;
      }
      unlockedTeleportList_.Add(other.unlockedTeleportList_);
      lightenSectionList_.Add(other.lightenSectionList_);
      if (other.CurMapEntryId != 0) {
        CurMapEntryId = other.CurMapEntryId;
      }
      mapList_.Add(other.mapList_);
      unlockedChestList_.Add(other.unlockedChestList_);
      mazeGroupList_.Add(other.mazeGroupList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      mazePropList_.Add(other.mazePropList_);
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 34:
          case 32: {
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 58: {
            mazePropList_.AddEntriesFrom(input, _repeated_mazePropList_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 72: {
            CurMapEntryId = input.ReadUInt32();
            break;
          }
          case 80: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 98: {
            unlockedChestList_.AddEntriesFrom(input, _repeated_unlockedChestList_codec);
            break;
          }
          case 106:
          case 104: {
            unlockedTeleportList_.AddEntriesFrom(input, _repeated_unlockedTeleportList_codec);
            break;
          }
          case 114: {
            mapList_.AddEntriesFrom(input, _repeated_mapList_codec);
            break;
          }
          case 122: {
            mazeGroupList_.AddEntriesFrom(input, _repeated_mazeGroupList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 34:
          case 32: {
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 58: {
            mazePropList_.AddEntriesFrom(ref input, _repeated_mazePropList_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 72: {
            CurMapEntryId = input.ReadUInt32();
            break;
          }
          case 80: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 98: {
            unlockedChestList_.AddEntriesFrom(ref input, _repeated_unlockedChestList_codec);
            break;
          }
          case 106:
          case 104: {
            unlockedTeleportList_.AddEntriesFrom(ref input, _repeated_unlockedTeleportList_codec);
            break;
          }
          case 114: {
            mapList_.AddEntriesFrom(ref input, _repeated_mapList_codec);
            break;
          }
          case 122: {
            mazeGroupList_.AddEntriesFrom(ref input, _repeated_mazeGroupList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
