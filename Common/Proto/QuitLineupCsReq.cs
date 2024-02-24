// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuitLineupCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from QuitLineupCsReq.proto</summary>
  public static partial class QuitLineupCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for QuitLineupCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuitLineupCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVRdWl0TGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90",
            "bxoQQXZhdGFyVHlwZS5wcm90byKtAQoPUXVpdExpbmV1cENzUmVxEisKEWV4",
            "dHJhX2xpbmV1cF90eXBlGA4gASgOMhAuRXh0cmFMaW5ldXBUeXBlEg0KBWlu",
            "ZGV4GA0gASgNEiAKC2F2YXRhcl90eXBlGAggASgOMgsuQXZhdGFyVHlwZRIS",
            "Cgppc192aXJ0dWFsGAUgASgIEhAKCHBsYW5lX2lkGAcgASgNEhYKDmJhc2Vf",
            "YXZhdGFyX2lkGAIgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ExtraLineupTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.QuitLineupCsReq), global::EggLink.DanhengServer.Proto.QuitLineupCsReq.Parser, new[]{ "ExtraLineupType", "Index", "AvatarType", "IsVirtual", "PlaneId", "BaseAvatarId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QuitLineupCsReq : pb::IMessage<QuitLineupCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuitLineupCsReq> _parser = new pb::MessageParser<QuitLineupCsReq>(() => new QuitLineupCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuitLineupCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.QuitLineupCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitLineupCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitLineupCsReq(QuitLineupCsReq other) : this() {
      extraLineupType_ = other.extraLineupType_;
      index_ = other.index_;
      avatarType_ = other.avatarType_;
      isVirtual_ = other.isVirtual_;
      planeId_ = other.planeId_;
      baseAvatarId_ = other.baseAvatarId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitLineupCsReq Clone() {
      return new QuitLineupCsReq(this);
    }

    /// <summary>Field number for the "extra_lineup_type" field.</summary>
    public const int ExtraLineupTypeFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ExtraLineupType extraLineupType_ = global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraLineupType ExtraLineupType {
      get { return extraLineupType_; }
      set {
        extraLineupType_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 13;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.AvatarType avatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "is_virtual" field.</summary>
    public const int IsVirtualFieldNumber = 5;
    private bool isVirtual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsVirtual {
      get { return isVirtual_; }
      set {
        isVirtual_ = value;
      }
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 7;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "base_avatar_id" field.</summary>
    public const int BaseAvatarIdFieldNumber = 2;
    private uint baseAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BaseAvatarId {
      get { return baseAvatarId_; }
      set {
        baseAvatarId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuitLineupCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuitLineupCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ExtraLineupType != other.ExtraLineupType) return false;
      if (Index != other.Index) return false;
      if (AvatarType != other.AvatarType) return false;
      if (IsVirtual != other.IsVirtual) return false;
      if (PlaneId != other.PlaneId) return false;
      if (BaseAvatarId != other.BaseAvatarId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) hash ^= ExtraLineupType.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= AvatarType.GetHashCode();
      if (IsVirtual != false) hash ^= IsVirtual.GetHashCode();
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (BaseAvatarId != 0) hash ^= BaseAvatarId.GetHashCode();
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
      if (BaseAvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BaseAvatarId);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsVirtual);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PlaneId);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) AvatarType);
      }
      if (Index != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Index);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) ExtraLineupType);
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
      if (BaseAvatarId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BaseAvatarId);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsVirtual);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PlaneId);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) AvatarType);
      }
      if (Index != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Index);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) ExtraLineupType);
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
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraLineupType);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      if (IsVirtual != false) {
        size += 1 + 1;
      }
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (BaseAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuitLineupCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        ExtraLineupType = other.ExtraLineupType;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        AvatarType = other.AvatarType;
      }
      if (other.IsVirtual != false) {
        IsVirtual = other.IsVirtual;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.BaseAvatarId != 0) {
        BaseAvatarId = other.BaseAvatarId;
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
          case 16: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 56: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 64: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 104: {
            Index = input.ReadUInt32();
            break;
          }
          case 112: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
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
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 56: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 64: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 104: {
            Index = input.ReadUInt32();
            break;
          }
          case 112: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
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
