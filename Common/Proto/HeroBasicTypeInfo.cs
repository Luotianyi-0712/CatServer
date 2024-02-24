// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeroBasicTypeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeroBasicTypeInfo.proto</summary>
  public static partial class HeroBasicTypeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HeroBasicTypeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeroBasicTypeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdIZXJvQmFzaWNUeXBlSW5mby5wcm90bxoTSGVyb0Jhc2ljVHlwZS5wcm90",
            "bxoVQXZhdGFyU2tpbGxUcmVlLnByb3RvInAKEUhlcm9CYXNpY1R5cGVJbmZv",
            "EgwKBHJhbmsYCyABKA0SIgoKYmFzaWNfdHlwZRgCIAEoDjIOLkhlcm9CYXNp",
            "Y1R5cGUSKQoPc2tpbGxfdHJlZV9saXN0GAwgAygLMhAuQXZhdGFyU2tpbGxU",
            "cmVlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeroBasicTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.AvatarSkillTreeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HeroBasicTypeInfo), global::EggLink.DanhengServer.Proto.HeroBasicTypeInfo.Parser, new[]{ "Rank", "BasicType", "SkillTreeList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HeroBasicTypeInfo : pb::IMessage<HeroBasicTypeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeroBasicTypeInfo> _parser = new pb::MessageParser<HeroBasicTypeInfo>(() => new HeroBasicTypeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeroBasicTypeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HeroBasicTypeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroBasicTypeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroBasicTypeInfo(HeroBasicTypeInfo other) : this() {
      rank_ = other.rank_;
      basicType_ = other.basicType_;
      skillTreeList_ = other.skillTreeList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroBasicTypeInfo Clone() {
      return new HeroBasicTypeInfo(this);
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 11;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "basic_type" field.</summary>
    public const int BasicTypeFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.HeroBasicType basicType_ = global::EggLink.DanhengServer.Proto.HeroBasicType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeroBasicType BasicType {
      get { return basicType_; }
      set {
        basicType_ = value;
      }
    }

    /// <summary>Field number for the "skill_tree_list" field.</summary>
    public const int SkillTreeListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AvatarSkillTree> _repeated_skillTreeList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.AvatarSkillTree.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> skillTreeList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AvatarSkillTree> SkillTreeList {
      get { return skillTreeList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeroBasicTypeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeroBasicTypeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Rank != other.Rank) return false;
      if (BasicType != other.BasicType) return false;
      if(!skillTreeList_.Equals(other.skillTreeList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (BasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) hash ^= BasicType.GetHashCode();
      hash ^= skillTreeList_.GetHashCode();
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
      if (BasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BasicType);
      }
      if (Rank != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Rank);
      }
      skillTreeList_.WriteTo(output, _repeated_skillTreeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BasicType);
      }
      if (Rank != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Rank);
      }
      skillTreeList_.WriteTo(ref output, _repeated_skillTreeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (BasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BasicType);
      }
      size += skillTreeList_.CalculateSize(_repeated_skillTreeList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeroBasicTypeInfo other) {
      if (other == null) {
        return;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.BasicType != global::EggLink.DanhengServer.Proto.HeroBasicType.None) {
        BasicType = other.BasicType;
      }
      skillTreeList_.Add(other.skillTreeList_);
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
            BasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 88: {
            Rank = input.ReadUInt32();
            break;
          }
          case 98: {
            skillTreeList_.AddEntriesFrom(input, _repeated_skillTreeList_codec);
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
            BasicType = (global::EggLink.DanhengServer.Proto.HeroBasicType) input.ReadEnum();
            break;
          }
          case 88: {
            Rank = input.ReadUInt32();
            break;
          }
          case 98: {
            skillTreeList_.AddEntriesFrom(ref input, _repeated_skillTreeList_codec);
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
