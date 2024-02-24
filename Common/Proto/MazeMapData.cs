// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MazeMapData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MazeMapData.proto</summary>
  public static partial class MazeMapDataReflection {

    #region Descriptor
    /// <summary>File descriptor for MazeMapData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MazeMapDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNYXplTWFwRGF0YS5wcm90bxoPTWF6ZUdyb3VwLnByb3RvGg9NYXplQ2hl",
            "c3QucHJvdG8aDk1hemVQcm9wLnByb3RvIvkBCgtNYXplTWFwRGF0YRInChN1",
            "bmxvY2tlZF9jaGVzdF9saXN0GAIgAygLMgouTWF6ZUNoZXN0EiMKD21hemVf",
            "Z3JvdXBfbGlzdBgMIAMoCzIKLk1hemVHcm91cBIPCgdyZXRjb2RlGAEgASgN",
            "EiEKDm1hemVfcHJvcF9saXN0GA4gAygLMgkuTWF6ZVByb3ASHAoUbGlnaHRl",
            "bl9zZWN0aW9uX2xpc3QYCSADKA0SHgoWdW5sb2NrZWRfdGVsZXBvcnRfbGlz",
            "dBgFIAMoDRIYChBjdXJfbWFwX2VudHJ5X2lkGAggASgNEhAKCGVudHJ5X2lk",
            "GAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MazeGroupReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazeChestReflection.Descriptor, global::EggLink.DanhengServer.Proto.MazePropReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MazeMapData), global::EggLink.DanhengServer.Proto.MazeMapData.Parser, new[]{ "UnlockedChestList", "MazeGroupList", "Retcode", "MazePropList", "LightenSectionList", "UnlockedTeleportList", "CurMapEntryId", "EntryId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MazeMapData : pb::IMessage<MazeMapData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MazeMapData> _parser = new pb::MessageParser<MazeMapData>(() => new MazeMapData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MazeMapData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MazeMapDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MazeMapData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MazeMapData(MazeMapData other) : this() {
      unlockedChestList_ = other.unlockedChestList_.Clone();
      mazeGroupList_ = other.mazeGroupList_.Clone();
      retcode_ = other.retcode_;
      mazePropList_ = other.mazePropList_.Clone();
      lightenSectionList_ = other.lightenSectionList_.Clone();
      unlockedTeleportList_ = other.unlockedTeleportList_.Clone();
      curMapEntryId_ = other.curMapEntryId_;
      entryId_ = other.entryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MazeMapData Clone() {
      return new MazeMapData(this);
    }

    /// <summary>Field number for the "unlocked_chest_list" field.</summary>
    public const int UnlockedChestListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeChest> _repeated_unlockedChestList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.MazeChest.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeChest> unlockedChestList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeChest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeChest> UnlockedChestList {
      get { return unlockedChestList_; }
    }

    /// <summary>Field number for the "maze_group_list" field.</summary>
    public const int MazeGroupListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeGroup> _repeated_mazeGroupList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.MazeGroup.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup> mazeGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeGroup> MazeGroupList {
      get { return mazeGroupList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
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
    public const int MazePropListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MazeProp> _repeated_mazePropList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.MazeProp.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeProp> mazePropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeProp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MazeProp> MazePropList {
      get { return mazePropList_; }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    /// <summary>Field number for the "unlocked_teleport_list" field.</summary>
    public const int UnlockedTeleportListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedTeleportList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> unlockedTeleportList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedTeleportList {
      get { return unlockedTeleportList_; }
    }

    /// <summary>Field number for the "cur_map_entry_id" field.</summary>
    public const int CurMapEntryIdFieldNumber = 8;
    private uint curMapEntryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurMapEntryId {
      get { return curMapEntryId_; }
      set {
        curMapEntryId_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 7;
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
      return Equals(other as MazeMapData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MazeMapData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockedChestList_.Equals(other.unlockedChestList_)) return false;
      if(!mazeGroupList_.Equals(other.mazeGroupList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!mazePropList_.Equals(other.mazePropList_)) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      if(!unlockedTeleportList_.Equals(other.unlockedTeleportList_)) return false;
      if (CurMapEntryId != other.CurMapEntryId) return false;
      if (EntryId != other.EntryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockedChestList_.GetHashCode();
      hash ^= mazeGroupList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= mazePropList_.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
      hash ^= unlockedTeleportList_.GetHashCode();
      if (CurMapEntryId != 0) hash ^= CurMapEntryId.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      unlockedChestList_.WriteTo(output, _repeated_unlockedChestList_codec);
      unlockedTeleportList_.WriteTo(output, _repeated_unlockedTeleportList_codec);
      if (EntryId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntryId);
      }
      if (CurMapEntryId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CurMapEntryId);
      }
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      mazeGroupList_.WriteTo(output, _repeated_mazeGroupList_codec);
      mazePropList_.WriteTo(output, _repeated_mazePropList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Retcode);
      }
      unlockedChestList_.WriteTo(ref output, _repeated_unlockedChestList_codec);
      unlockedTeleportList_.WriteTo(ref output, _repeated_unlockedTeleportList_codec);
      if (EntryId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntryId);
      }
      if (CurMapEntryId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CurMapEntryId);
      }
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      mazeGroupList_.WriteTo(ref output, _repeated_mazeGroupList_codec);
      mazePropList_.WriteTo(ref output, _repeated_mazePropList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unlockedChestList_.CalculateSize(_repeated_unlockedChestList_codec);
      size += mazeGroupList_.CalculateSize(_repeated_mazeGroupList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += mazePropList_.CalculateSize(_repeated_mazePropList_codec);
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      size += unlockedTeleportList_.CalculateSize(_repeated_unlockedTeleportList_codec);
      if (CurMapEntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurMapEntryId);
      }
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
    public void MergeFrom(MazeMapData other) {
      if (other == null) {
        return;
      }
      unlockedChestList_.Add(other.unlockedChestList_);
      mazeGroupList_.Add(other.mazeGroupList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      mazePropList_.Add(other.mazePropList_);
      lightenSectionList_.Add(other.lightenSectionList_);
      unlockedTeleportList_.Add(other.unlockedTeleportList_);
      if (other.CurMapEntryId != 0) {
        CurMapEntryId = other.CurMapEntryId;
      }
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
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            unlockedChestList_.AddEntriesFrom(input, _repeated_unlockedChestList_codec);
            break;
          }
          case 42:
          case 40: {
            unlockedTeleportList_.AddEntriesFrom(input, _repeated_unlockedTeleportList_codec);
            break;
          }
          case 56: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 64: {
            CurMapEntryId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 98: {
            mazeGroupList_.AddEntriesFrom(input, _repeated_mazeGroupList_codec);
            break;
          }
          case 114: {
            mazePropList_.AddEntriesFrom(input, _repeated_mazePropList_codec);
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
          case 8: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 18: {
            unlockedChestList_.AddEntriesFrom(ref input, _repeated_unlockedChestList_codec);
            break;
          }
          case 42:
          case 40: {
            unlockedTeleportList_.AddEntriesFrom(ref input, _repeated_unlockedTeleportList_codec);
            break;
          }
          case 56: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 64: {
            CurMapEntryId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 98: {
            mazeGroupList_.AddEntriesFrom(ref input, _repeated_mazeGroupList_codec);
            break;
          }
          case 114: {
            mazePropList_.AddEntriesFrom(ref input, _repeated_mazePropList_codec);
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
