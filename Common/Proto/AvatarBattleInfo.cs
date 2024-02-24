// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarBattleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AvatarBattleInfo.proto</summary>
  public static partial class AvatarBattleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarBattleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarBattleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZBdmF0YXJCYXR0bGVJbmZvLnByb3RvGhRBdmF0YXJQcm9wZXJ0eS5wcm90",
            "bxoQQXZhdGFyVHlwZS5wcm90byKtAQoQQXZhdGFyQmF0dGxlSW5mbxIgCgth",
            "dmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGUSCgoCaWQYAiABKA0SFAoM",
            "YXZhdGFyX2xldmVsGAMgASgNEhMKC2F2YXRhcl9yYW5rGAQgASgNEhgKEGF2",
            "YXRhcl9wcm9tb3Rpb24YBSABKA0SJgoNYXZhdGFyX3N0YXR1cxgGIAEoCzIP",
            "LkF2YXRhclByb3BlcnR5Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarPropertyReflection.Descriptor, global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AvatarBattleInfo), global::EggLink.DanhengServer.Proto.AvatarBattleInfo.Parser, new[]{ "AvatarType", "Id", "AvatarLevel", "AvatarRank", "AvatarPromotion", "AvatarStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AvatarBattleInfo : pb::IMessage<AvatarBattleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarBattleInfo> _parser = new pb::MessageParser<AvatarBattleInfo>(() => new AvatarBattleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarBattleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AvatarBattleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarBattleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarBattleInfo(AvatarBattleInfo other) : this() {
      avatarType_ = other.avatarType_;
      id_ = other.id_;
      avatarLevel_ = other.avatarLevel_;
      avatarRank_ = other.avatarRank_;
      avatarPromotion_ = other.avatarPromotion_;
      avatarStatus_ = other.avatarStatus_ != null ? other.avatarStatus_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarBattleInfo Clone() {
      return new AvatarBattleInfo(this);
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.AvatarType avatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "avatar_level" field.</summary>
    public const int AvatarLevelFieldNumber = 3;
    private uint avatarLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarLevel {
      get { return avatarLevel_; }
      set {
        avatarLevel_ = value;
      }
    }

    /// <summary>Field number for the "avatar_rank" field.</summary>
    public const int AvatarRankFieldNumber = 4;
    private uint avatarRank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarRank {
      get { return avatarRank_; }
      set {
        avatarRank_ = value;
      }
    }

    /// <summary>Field number for the "avatar_promotion" field.</summary>
    public const int AvatarPromotionFieldNumber = 5;
    private uint avatarPromotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarPromotion {
      get { return avatarPromotion_; }
      set {
        avatarPromotion_ = value;
      }
    }

    /// <summary>Field number for the "avatar_status" field.</summary>
    public const int AvatarStatusFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.AvatarProperty avatarStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarProperty AvatarStatus {
      get { return avatarStatus_; }
      set {
        avatarStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarBattleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarBattleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarType != other.AvatarType) return false;
      if (Id != other.Id) return false;
      if (AvatarLevel != other.AvatarLevel) return false;
      if (AvatarRank != other.AvatarRank) return false;
      if (AvatarPromotion != other.AvatarPromotion) return false;
      if (!object.Equals(AvatarStatus, other.AvatarStatus)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= AvatarType.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (AvatarLevel != 0) hash ^= AvatarLevel.GetHashCode();
      if (AvatarRank != 0) hash ^= AvatarRank.GetHashCode();
      if (AvatarPromotion != 0) hash ^= AvatarPromotion.GetHashCode();
      if (avatarStatus_ != null) hash ^= AvatarStatus.GetHashCode();
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
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AvatarType);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (AvatarLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AvatarLevel);
      }
      if (AvatarRank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarRank);
      }
      if (AvatarPromotion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AvatarPromotion);
      }
      if (avatarStatus_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AvatarStatus);
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
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) AvatarType);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (AvatarLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AvatarLevel);
      }
      if (AvatarRank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarRank);
      }
      if (AvatarPromotion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AvatarPromotion);
      }
      if (avatarStatus_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AvatarStatus);
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
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (AvatarLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarLevel);
      }
      if (AvatarRank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarRank);
      }
      if (AvatarPromotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarPromotion);
      }
      if (avatarStatus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AvatarStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarBattleInfo other) {
      if (other == null) {
        return;
      }
      if (other.AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        AvatarType = other.AvatarType;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.AvatarLevel != 0) {
        AvatarLevel = other.AvatarLevel;
      }
      if (other.AvatarRank != 0) {
        AvatarRank = other.AvatarRank;
      }
      if (other.AvatarPromotion != 0) {
        AvatarPromotion = other.AvatarPromotion;
      }
      if (other.avatarStatus_ != null) {
        if (avatarStatus_ == null) {
          AvatarStatus = new global::EggLink.DanhengServer.Proto.AvatarProperty();
        }
        AvatarStatus.MergeFrom(other.AvatarStatus);
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
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 24: {
            AvatarLevel = input.ReadUInt32();
            break;
          }
          case 32: {
            AvatarRank = input.ReadUInt32();
            break;
          }
          case 40: {
            AvatarPromotion = input.ReadUInt32();
            break;
          }
          case 50: {
            if (avatarStatus_ == null) {
              AvatarStatus = new global::EggLink.DanhengServer.Proto.AvatarProperty();
            }
            input.ReadMessage(AvatarStatus);
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
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 24: {
            AvatarLevel = input.ReadUInt32();
            break;
          }
          case 32: {
            AvatarRank = input.ReadUInt32();
            break;
          }
          case 40: {
            AvatarPromotion = input.ReadUInt32();
            break;
          }
          case 50: {
            if (avatarStatus_ == null) {
              AvatarStatus = new global::EggLink.DanhengServer.Proto.AvatarProperty();
            }
            input.ReadMessage(AvatarStatus);
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
