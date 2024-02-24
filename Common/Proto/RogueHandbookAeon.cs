// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueHandbookAeon.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueHandbookAeon.proto</summary>
  public static partial class RogueHandbookAeonReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueHandbookAeon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueHandbookAeonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSb2d1ZUhhbmRib29rQWVvbi5wcm90byKLAQoRUm9ndWVIYW5kYm9va0Fl",
            "b24SDwoHYWVvbl9pZBgCIAEoDRIRCgltYXhfbGV2ZWwYBSABKA0SCwoDZXhw",
            "GA8gASgNEg0KBWxldmVsGAQgASgNEhsKE2FyY2hpdmVfdW5sb2NrX2xpc3QY",
            "DSADKA0SGQoRdGFrZW5fcmV3YXJkX2xpc3QYCiADKA1CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueHandbookAeon), global::EggLink.DanhengServer.Proto.RogueHandbookAeon.Parser, new[]{ "AeonId", "MaxLevel", "Exp", "Level", "ArchiveUnlockList", "TakenRewardList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueHandbookAeon : pb::IMessage<RogueHandbookAeon>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueHandbookAeon> _parser = new pb::MessageParser<RogueHandbookAeon>(() => new RogueHandbookAeon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueHandbookAeon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueHandbookAeonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueHandbookAeon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueHandbookAeon(RogueHandbookAeon other) : this() {
      aeonId_ = other.aeonId_;
      maxLevel_ = other.maxLevel_;
      exp_ = other.exp_;
      level_ = other.level_;
      archiveUnlockList_ = other.archiveUnlockList_.Clone();
      takenRewardList_ = other.takenRewardList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueHandbookAeon Clone() {
      return new RogueHandbookAeon(this);
    }

    /// <summary>Field number for the "aeon_id" field.</summary>
    public const int AeonIdFieldNumber = 2;
    private uint aeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AeonId {
      get { return aeonId_; }
      set {
        aeonId_ = value;
      }
    }

    /// <summary>Field number for the "max_level" field.</summary>
    public const int MaxLevelFieldNumber = 5;
    private uint maxLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxLevel {
      get { return maxLevel_; }
      set {
        maxLevel_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 15;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 4;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "archive_unlock_list" field.</summary>
    public const int ArchiveUnlockListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_archiveUnlockList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> archiveUnlockList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ArchiveUnlockList {
      get { return archiveUnlockList_; }
    }

    /// <summary>Field number for the "taken_reward_list" field.</summary>
    public const int TakenRewardListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_takenRewardList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> takenRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenRewardList {
      get { return takenRewardList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueHandbookAeon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueHandbookAeon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AeonId != other.AeonId) return false;
      if (MaxLevel != other.MaxLevel) return false;
      if (Exp != other.Exp) return false;
      if (Level != other.Level) return false;
      if(!archiveUnlockList_.Equals(other.archiveUnlockList_)) return false;
      if(!takenRewardList_.Equals(other.takenRewardList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AeonId != 0) hash ^= AeonId.GetHashCode();
      if (MaxLevel != 0) hash ^= MaxLevel.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= archiveUnlockList_.GetHashCode();
      hash ^= takenRewardList_.GetHashCode();
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
      if (AeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AeonId);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Level);
      }
      if (MaxLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MaxLevel);
      }
      takenRewardList_.WriteTo(output, _repeated_takenRewardList_codec);
      archiveUnlockList_.WriteTo(output, _repeated_archiveUnlockList_codec);
      if (Exp != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Exp);
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
      if (AeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(AeonId);
      }
      if (Level != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Level);
      }
      if (MaxLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MaxLevel);
      }
      takenRewardList_.WriteTo(ref output, _repeated_takenRewardList_codec);
      archiveUnlockList_.WriteTo(ref output, _repeated_archiveUnlockList_codec);
      if (Exp != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Exp);
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
      if (AeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AeonId);
      }
      if (MaxLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxLevel);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += archiveUnlockList_.CalculateSize(_repeated_archiveUnlockList_codec);
      size += takenRewardList_.CalculateSize(_repeated_takenRewardList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueHandbookAeon other) {
      if (other == null) {
        return;
      }
      if (other.AeonId != 0) {
        AeonId = other.AeonId;
      }
      if (other.MaxLevel != 0) {
        MaxLevel = other.MaxLevel;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      archiveUnlockList_.Add(other.archiveUnlockList_);
      takenRewardList_.Add(other.takenRewardList_);
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
          case 16: {
            AeonId = input.ReadUInt32();
            break;
          }
          case 32: {
            Level = input.ReadUInt32();
            break;
          }
          case 40: {
            MaxLevel = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            takenRewardList_.AddEntriesFrom(input, _repeated_takenRewardList_codec);
            break;
          }
          case 106:
          case 104: {
            archiveUnlockList_.AddEntriesFrom(input, _repeated_archiveUnlockList_codec);
            break;
          }
          case 120: {
            Exp = input.ReadUInt32();
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
          case 16: {
            AeonId = input.ReadUInt32();
            break;
          }
          case 32: {
            Level = input.ReadUInt32();
            break;
          }
          case 40: {
            MaxLevel = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            takenRewardList_.AddEntriesFrom(ref input, _repeated_takenRewardList_codec);
            break;
          }
          case 106:
          case 104: {
            archiveUnlockList_.AddEntriesFrom(ref input, _repeated_archiveUnlockList_codec);
            break;
          }
          case 120: {
            Exp = input.ReadUInt32();
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
