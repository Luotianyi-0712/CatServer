// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JoinLineupCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JoinLineupCsReq.proto</summary>
  public static partial class JoinLineupCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for JoinLineupCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JoinLineupCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVKb2luTGluZXVwQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aFUV4",
            "dHJhTGluZXVwVHlwZS5wcm90byK7AQoPSm9pbkxpbmV1cENzUmVxEhAKCHBs",
            "YW5lX2lkGAggASgNEhYKDmJhc2VfYXZhdGFyX2lkGAwgASgNEisKEWV4dHJh",
            "X2xpbmV1cF90eXBlGAkgASgOMhAuRXh0cmFMaW5ldXBUeXBlEhIKCmlzX3Zp",
            "cnR1YWwYBCABKAgSDQoFaW5kZXgYCyABKA0SIAoLYXZhdGFyX3R5cGUYDSAB",
            "KA4yCy5BdmF0YXJUeXBlEgwKBHNsb3QYAyABKA1CHqoCG0VnZ0xpbmsuRGFu",
            "aGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.ExtraLineupTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JoinLineupCsReq), global::EggLink.DanhengServer.Proto.JoinLineupCsReq.Parser, new[]{ "PlaneId", "BaseAvatarId", "ExtraLineupType", "IsVirtual", "Index", "AvatarType", "Slot" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JoinLineupCsReq : pb::IMessage<JoinLineupCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JoinLineupCsReq> _parser = new pb::MessageParser<JoinLineupCsReq>(() => new JoinLineupCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JoinLineupCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JoinLineupCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinLineupCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinLineupCsReq(JoinLineupCsReq other) : this() {
      planeId_ = other.planeId_;
      baseAvatarId_ = other.baseAvatarId_;
      extraLineupType_ = other.extraLineupType_;
      isVirtual_ = other.isVirtual_;
      index_ = other.index_;
      avatarType_ = other.avatarType_;
      slot_ = other.slot_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JoinLineupCsReq Clone() {
      return new JoinLineupCsReq(this);
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 8;
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
    public const int BaseAvatarIdFieldNumber = 12;
    private uint baseAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BaseAvatarId {
      get { return baseAvatarId_; }
      set {
        baseAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "extra_lineup_type" field.</summary>
    public const int ExtraLineupTypeFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.ExtraLineupType extraLineupType_ = global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraLineupType ExtraLineupType {
      get { return extraLineupType_; }
      set {
        extraLineupType_ = value;
      }
    }

    /// <summary>Field number for the "is_virtual" field.</summary>
    public const int IsVirtualFieldNumber = 4;
    private bool isVirtual_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsVirtual {
      get { return isVirtual_; }
      set {
        isVirtual_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 11;
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
    public const int AvatarTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.AvatarType avatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "slot" field.</summary>
    public const int SlotFieldNumber = 3;
    private uint slot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Slot {
      get { return slot_; }
      set {
        slot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JoinLineupCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JoinLineupCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlaneId != other.PlaneId) return false;
      if (BaseAvatarId != other.BaseAvatarId) return false;
      if (ExtraLineupType != other.ExtraLineupType) return false;
      if (IsVirtual != other.IsVirtual) return false;
      if (Index != other.Index) return false;
      if (AvatarType != other.AvatarType) return false;
      if (Slot != other.Slot) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (BaseAvatarId != 0) hash ^= BaseAvatarId.GetHashCode();
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) hash ^= ExtraLineupType.GetHashCode();
      if (IsVirtual != false) hash ^= IsVirtual.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= AvatarType.GetHashCode();
      if (Slot != 0) hash ^= Slot.GetHashCode();
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
      if (Slot != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Slot);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsVirtual);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlaneId);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BaseAvatarId);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) AvatarType);
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
      if (Slot != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Slot);
      }
      if (IsVirtual != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsVirtual);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlaneId);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (Index != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Index);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BaseAvatarId);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) AvatarType);
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
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (BaseAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraLineupType);
      }
      if (IsVirtual != false) {
        size += 1 + 1;
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      if (Slot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Slot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JoinLineupCsReq other) {
      if (other == null) {
        return;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.BaseAvatarId != 0) {
        BaseAvatarId = other.BaseAvatarId;
      }
      if (other.ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        ExtraLineupType = other.ExtraLineupType;
      }
      if (other.IsVirtual != false) {
        IsVirtual = other.IsVirtual;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        AvatarType = other.AvatarType;
      }
      if (other.Slot != 0) {
        Slot = other.Slot;
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
          case 24: {
            Slot = input.ReadUInt32();
            break;
          }
          case 32: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 64: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 72: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
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
          case 24: {
            Slot = input.ReadUInt32();
            break;
          }
          case 32: {
            IsVirtual = input.ReadBool();
            break;
          }
          case 64: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 72: {
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 88: {
            Index = input.ReadUInt32();
            break;
          }
          case 96: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
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
