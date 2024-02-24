// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueBuffSelectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueBuffSelectInfo.proto</summary>
  public static partial class RogueBuffSelectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueBuffSelectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueBuffSelectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSb2d1ZUJ1ZmZTZWxlY3RJbmZvLnByb3RvGiFSb2d1ZUNvbW1vbkJ1ZmZT",
            "ZWxlY3RTb3VyY2UucHJvdG8aEkl0ZW1Db3N0TGlzdC5wcm90bxoPUm9ndWVC",
            "dWZmLnByb3RvIuYCChNSb2d1ZUJ1ZmZTZWxlY3RJbmZvEiYKD3JvbGxfYnVm",
            "ZnNfY29zdBgJIAEoCzINLkl0ZW1Db3N0TGlzdBIsCgZzb3VyY2UYBiABKA4y",
            "HC5Sb2d1ZUNvbW1vbkJ1ZmZTZWxlY3RTb3VyY2USEAoIY2FuX3JvbGwYDSAB",
            "KAgSHgoWc2VsZWN0X2ZpcnN0X2J1ZmZfbGlzdBgFIAMoDRIXCg9yb2xsX2J1",
            "ZmZfdGltZXMYByABKA0SGwoTcm9sbF9idWZmX21heF90aW1lcxgKIAEoDRIm",
            "Ch5zZWxlY3RfYnVmZl9zb3VyY2VfdG90YWxfY291bnQYAiABKA0SJAocc2Vs",
            "ZWN0X2J1ZmZfc291cmNlX2N1cl9jb3VudBgPIAEoDRIiCg5tYXplX2J1ZmZf",
            "bGlzdBgMIAMoCzIKLlJvZ3VlQnVmZhIfChdzZWxlY3RfYnVmZl9zb3VyY2Vf",
            "aGludBgBIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSourceReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemCostListReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueBuffSelectInfo), global::EggLink.DanhengServer.Proto.RogueBuffSelectInfo.Parser, new[]{ "RollBuffsCost", "Source", "CanRoll", "SelectFirstBuffList", "RollBuffTimes", "RollBuffMaxTimes", "SelectBuffSourceTotalCount", "SelectBuffSourceCurCount", "MazeBuffList", "SelectBuffSourceHint" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueBuffSelectInfo : pb::IMessage<RogueBuffSelectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueBuffSelectInfo> _parser = new pb::MessageParser<RogueBuffSelectInfo>(() => new RogueBuffSelectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueBuffSelectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueBuffSelectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueBuffSelectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueBuffSelectInfo(RogueBuffSelectInfo other) : this() {
      rollBuffsCost_ = other.rollBuffsCost_ != null ? other.rollBuffsCost_.Clone() : null;
      source_ = other.source_;
      canRoll_ = other.canRoll_;
      selectFirstBuffList_ = other.selectFirstBuffList_.Clone();
      rollBuffTimes_ = other.rollBuffTimes_;
      rollBuffMaxTimes_ = other.rollBuffMaxTimes_;
      selectBuffSourceTotalCount_ = other.selectBuffSourceTotalCount_;
      selectBuffSourceCurCount_ = other.selectBuffSourceCurCount_;
      mazeBuffList_ = other.mazeBuffList_.Clone();
      selectBuffSourceHint_ = other.selectBuffSourceHint_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueBuffSelectInfo Clone() {
      return new RogueBuffSelectInfo(this);
    }

    /// <summary>Field number for the "roll_buffs_cost" field.</summary>
    public const int RollBuffsCostFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ItemCostList rollBuffsCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostList RollBuffsCost {
      get { return rollBuffsCost_; }
      set {
        rollBuffsCost_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource source_ = global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource.TypeNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "can_roll" field.</summary>
    public const int CanRollFieldNumber = 13;
    private bool canRoll_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CanRoll {
      get { return canRoll_; }
      set {
        canRoll_ = value;
      }
    }

    /// <summary>Field number for the "select_first_buff_list" field.</summary>
    public const int SelectFirstBuffListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_selectFirstBuffList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> selectFirstBuffList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectFirstBuffList {
      get { return selectFirstBuffList_; }
    }

    /// <summary>Field number for the "roll_buff_times" field.</summary>
    public const int RollBuffTimesFieldNumber = 7;
    private uint rollBuffTimes_;
    /// <summary>
    /// bool show_handbook_hint = 8; removed???
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffTimes {
      get { return rollBuffTimes_; }
      set {
        rollBuffTimes_ = value;
      }
    }

    /// <summary>Field number for the "roll_buff_max_times" field.</summary>
    public const int RollBuffMaxTimesFieldNumber = 10;
    private uint rollBuffMaxTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RollBuffMaxTimes {
      get { return rollBuffMaxTimes_; }
      set {
        rollBuffMaxTimes_ = value;
      }
    }

    /// <summary>Field number for the "select_buff_source_total_count" field.</summary>
    public const int SelectBuffSourceTotalCountFieldNumber = 2;
    private uint selectBuffSourceTotalCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectBuffSourceTotalCount {
      get { return selectBuffSourceTotalCount_; }
      set {
        selectBuffSourceTotalCount_ = value;
      }
    }

    /// <summary>Field number for the "select_buff_source_cur_count" field.</summary>
    public const int SelectBuffSourceCurCountFieldNumber = 15;
    private uint selectBuffSourceCurCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectBuffSourceCurCount {
      get { return selectBuffSourceCurCount_; }
      set {
        selectBuffSourceCurCount_ = value;
      }
    }

    /// <summary>Field number for the "maze_buff_list" field.</summary>
    public const int MazeBuffListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RogueBuff> _repeated_mazeBuffList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.RogueBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueBuff> mazeBuffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RogueBuff> MazeBuffList {
      get { return mazeBuffList_; }
    }

    /// <summary>Field number for the "select_buff_source_hint" field.</summary>
    public const int SelectBuffSourceHintFieldNumber = 1;
    private uint selectBuffSourceHint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectBuffSourceHint {
      get { return selectBuffSourceHint_; }
      set {
        selectBuffSourceHint_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueBuffSelectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueBuffSelectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RollBuffsCost, other.RollBuffsCost)) return false;
      if (Source != other.Source) return false;
      if (CanRoll != other.CanRoll) return false;
      if(!selectFirstBuffList_.Equals(other.selectFirstBuffList_)) return false;
      if (RollBuffTimes != other.RollBuffTimes) return false;
      if (RollBuffMaxTimes != other.RollBuffMaxTimes) return false;
      if (SelectBuffSourceTotalCount != other.SelectBuffSourceTotalCount) return false;
      if (SelectBuffSourceCurCount != other.SelectBuffSourceCurCount) return false;
      if(!mazeBuffList_.Equals(other.mazeBuffList_)) return false;
      if (SelectBuffSourceHint != other.SelectBuffSourceHint) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rollBuffsCost_ != null) hash ^= RollBuffsCost.GetHashCode();
      if (Source != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource.TypeNone) hash ^= Source.GetHashCode();
      if (CanRoll != false) hash ^= CanRoll.GetHashCode();
      hash ^= selectFirstBuffList_.GetHashCode();
      if (RollBuffTimes != 0) hash ^= RollBuffTimes.GetHashCode();
      if (RollBuffMaxTimes != 0) hash ^= RollBuffMaxTimes.GetHashCode();
      if (SelectBuffSourceTotalCount != 0) hash ^= SelectBuffSourceTotalCount.GetHashCode();
      if (SelectBuffSourceCurCount != 0) hash ^= SelectBuffSourceCurCount.GetHashCode();
      hash ^= mazeBuffList_.GetHashCode();
      if (SelectBuffSourceHint != 0) hash ^= SelectBuffSourceHint.GetHashCode();
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
      if (SelectBuffSourceHint != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SelectBuffSourceHint);
      }
      if (SelectBuffSourceTotalCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SelectBuffSourceTotalCount);
      }
      selectFirstBuffList_.WriteTo(output, _repeated_selectFirstBuffList_codec);
      if (Source != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource.TypeNone) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Source);
      }
      if (RollBuffTimes != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RollBuffTimes);
      }
      if (rollBuffsCost_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RollBuffsCost);
      }
      if (RollBuffMaxTimes != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RollBuffMaxTimes);
      }
      mazeBuffList_.WriteTo(output, _repeated_mazeBuffList_codec);
      if (CanRoll != false) {
        output.WriteRawTag(104);
        output.WriteBool(CanRoll);
      }
      if (SelectBuffSourceCurCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelectBuffSourceCurCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SelectBuffSourceHint != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SelectBuffSourceHint);
      }
      if (SelectBuffSourceTotalCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SelectBuffSourceTotalCount);
      }
      selectFirstBuffList_.WriteTo(ref output, _repeated_selectFirstBuffList_codec);
      if (Source != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource.TypeNone) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Source);
      }
      if (RollBuffTimes != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RollBuffTimes);
      }
      if (rollBuffsCost_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(RollBuffsCost);
      }
      if (RollBuffMaxTimes != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RollBuffMaxTimes);
      }
      mazeBuffList_.WriteTo(ref output, _repeated_mazeBuffList_codec);
      if (CanRoll != false) {
        output.WriteRawTag(104);
        output.WriteBool(CanRoll);
      }
      if (SelectBuffSourceCurCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelectBuffSourceCurCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (rollBuffsCost_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RollBuffsCost);
      }
      if (Source != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource.TypeNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (CanRoll != false) {
        size += 1 + 1;
      }
      size += selectFirstBuffList_.CalculateSize(_repeated_selectFirstBuffList_codec);
      if (RollBuffTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffTimes);
      }
      if (RollBuffMaxTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RollBuffMaxTimes);
      }
      if (SelectBuffSourceTotalCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectBuffSourceTotalCount);
      }
      if (SelectBuffSourceCurCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectBuffSourceCurCount);
      }
      size += mazeBuffList_.CalculateSize(_repeated_mazeBuffList_codec);
      if (SelectBuffSourceHint != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectBuffSourceHint);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueBuffSelectInfo other) {
      if (other == null) {
        return;
      }
      if (other.rollBuffsCost_ != null) {
        if (rollBuffsCost_ == null) {
          RollBuffsCost = new global::EggLink.DanhengServer.Proto.ItemCostList();
        }
        RollBuffsCost.MergeFrom(other.RollBuffsCost);
      }
      if (other.Source != global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource.TypeNone) {
        Source = other.Source;
      }
      if (other.CanRoll != false) {
        CanRoll = other.CanRoll;
      }
      selectFirstBuffList_.Add(other.selectFirstBuffList_);
      if (other.RollBuffTimes != 0) {
        RollBuffTimes = other.RollBuffTimes;
      }
      if (other.RollBuffMaxTimes != 0) {
        RollBuffMaxTimes = other.RollBuffMaxTimes;
      }
      if (other.SelectBuffSourceTotalCount != 0) {
        SelectBuffSourceTotalCount = other.SelectBuffSourceTotalCount;
      }
      if (other.SelectBuffSourceCurCount != 0) {
        SelectBuffSourceCurCount = other.SelectBuffSourceCurCount;
      }
      mazeBuffList_.Add(other.mazeBuffList_);
      if (other.SelectBuffSourceHint != 0) {
        SelectBuffSourceHint = other.SelectBuffSourceHint;
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
            SelectBuffSourceHint = input.ReadUInt32();
            break;
          }
          case 16: {
            SelectBuffSourceTotalCount = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            selectFirstBuffList_.AddEntriesFrom(input, _repeated_selectFirstBuffList_codec);
            break;
          }
          case 48: {
            Source = (global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource) input.ReadEnum();
            break;
          }
          case 56: {
            RollBuffTimes = input.ReadUInt32();
            break;
          }
          case 74: {
            if (rollBuffsCost_ == null) {
              RollBuffsCost = new global::EggLink.DanhengServer.Proto.ItemCostList();
            }
            input.ReadMessage(RollBuffsCost);
            break;
          }
          case 80: {
            RollBuffMaxTimes = input.ReadUInt32();
            break;
          }
          case 98: {
            mazeBuffList_.AddEntriesFrom(input, _repeated_mazeBuffList_codec);
            break;
          }
          case 104: {
            CanRoll = input.ReadBool();
            break;
          }
          case 120: {
            SelectBuffSourceCurCount = input.ReadUInt32();
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
            SelectBuffSourceHint = input.ReadUInt32();
            break;
          }
          case 16: {
            SelectBuffSourceTotalCount = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            selectFirstBuffList_.AddEntriesFrom(ref input, _repeated_selectFirstBuffList_codec);
            break;
          }
          case 48: {
            Source = (global::EggLink.DanhengServer.Proto.RogueCommonBuffSelectSource) input.ReadEnum();
            break;
          }
          case 56: {
            RollBuffTimes = input.ReadUInt32();
            break;
          }
          case 74: {
            if (rollBuffsCost_ == null) {
              RollBuffsCost = new global::EggLink.DanhengServer.Proto.ItemCostList();
            }
            input.ReadMessage(RollBuffsCost);
            break;
          }
          case 80: {
            RollBuffMaxTimes = input.ReadUInt32();
            break;
          }
          case 98: {
            mazeBuffList_.AddEntriesFrom(ref input, _repeated_mazeBuffList_codec);
            break;
          }
          case 104: {
            CanRoll = input.ReadBool();
            break;
          }
          case 120: {
            SelectBuffSourceCurCount = input.ReadUInt32();
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
