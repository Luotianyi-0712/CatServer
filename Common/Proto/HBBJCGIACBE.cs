// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HBBJCGIACBE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HBBJCGIACBE.proto</summary>
  public static partial class HBBJCGIACBEReflection {

    #region Descriptor
    /// <summary>File descriptor for HBBJCGIACBE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HBBJCGIACBEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQkJKQ0dJQUNCRS5wcm90byK3AQoLSEJCSkNHSUFDQkUSEQoJYXZhdGFy",
            "X2lkGAEgASgNEhMKC0hKT01DSkdHSExHGAIgAygNEg4KBnNvdXJjZRgDIAEo",
            "DRIOCgZkYW1hZ2UYBCABKAESEwoLREFCT1BCT0ZJQkwYBSADKA0SEwoLTUlQ",
            "QkFIS0xES0QYBiABKAUSEwoLQUhPQVBGTklKTkgYByABKAESEwoLTkdPUENB",
            "SExMSUQYCCABKA0SDAoEd2F2ZRgJIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HBBJCGIACBE), global::EggLink.DanhengServer.Proto.HBBJCGIACBE.Parser, new[]{ "AvatarId", "HJOMCJGGHLG", "Source", "Damage", "DABOPBOFIBL", "MIPBAHKLDKD", "AHOAPFNIJNH", "NGOPCAHLLID", "Wave" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HBBJCGIACBE : pb::IMessage<HBBJCGIACBE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HBBJCGIACBE> _parser = new pb::MessageParser<HBBJCGIACBE>(() => new HBBJCGIACBE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HBBJCGIACBE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HBBJCGIACBEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBBJCGIACBE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBBJCGIACBE(HBBJCGIACBE other) : this() {
      avatarId_ = other.avatarId_;
      hJOMCJGGHLG_ = other.hJOMCJGGHLG_.Clone();
      source_ = other.source_;
      damage_ = other.damage_;
      dABOPBOFIBL_ = other.dABOPBOFIBL_.Clone();
      mIPBAHKLDKD_ = other.mIPBAHKLDKD_;
      aHOAPFNIJNH_ = other.aHOAPFNIJNH_;
      nGOPCAHLLID_ = other.nGOPCAHLLID_;
      wave_ = other.wave_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBBJCGIACBE Clone() {
      return new HBBJCGIACBE(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 1;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "HJOMCJGGHLG" field.</summary>
    public const int HJOMCJGGHLGFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_hJOMCJGGHLG_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> hJOMCJGGHLG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HJOMCJGGHLG {
      get { return hJOMCJGGHLG_; }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 3;
    private uint source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "damage" field.</summary>
    public const int DamageFieldNumber = 4;
    private double damage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Damage {
      get { return damage_; }
      set {
        damage_ = value;
      }
    }

    /// <summary>Field number for the "DABOPBOFIBL" field.</summary>
    public const int DABOPBOFIBLFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_dABOPBOFIBL_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> dABOPBOFIBL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DABOPBOFIBL {
      get { return dABOPBOFIBL_; }
    }

    /// <summary>Field number for the "MIPBAHKLDKD" field.</summary>
    public const int MIPBAHKLDKDFieldNumber = 6;
    private int mIPBAHKLDKD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MIPBAHKLDKD {
      get { return mIPBAHKLDKD_; }
      set {
        mIPBAHKLDKD_ = value;
      }
    }

    /// <summary>Field number for the "AHOAPFNIJNH" field.</summary>
    public const int AHOAPFNIJNHFieldNumber = 7;
    private double aHOAPFNIJNH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double AHOAPFNIJNH {
      get { return aHOAPFNIJNH_; }
      set {
        aHOAPFNIJNH_ = value;
      }
    }

    /// <summary>Field number for the "NGOPCAHLLID" field.</summary>
    public const int NGOPCAHLLIDFieldNumber = 8;
    private uint nGOPCAHLLID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NGOPCAHLLID {
      get { return nGOPCAHLLID_; }
      set {
        nGOPCAHLLID_ = value;
      }
    }

    /// <summary>Field number for the "wave" field.</summary>
    public const int WaveFieldNumber = 9;
    private uint wave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Wave {
      get { return wave_; }
      set {
        wave_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HBBJCGIACBE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HBBJCGIACBE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if(!hJOMCJGGHLG_.Equals(other.hJOMCJGGHLG_)) return false;
      if (Source != other.Source) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage)) return false;
      if(!dABOPBOFIBL_.Equals(other.dABOPBOFIBL_)) return false;
      if (MIPBAHKLDKD != other.MIPBAHKLDKD) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(AHOAPFNIJNH, other.AHOAPFNIJNH)) return false;
      if (NGOPCAHLLID != other.NGOPCAHLLID) return false;
      if (Wave != other.Wave) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      hash ^= hJOMCJGGHLG_.GetHashCode();
      if (Source != 0) hash ^= Source.GetHashCode();
      if (Damage != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
      hash ^= dABOPBOFIBL_.GetHashCode();
      if (MIPBAHKLDKD != 0) hash ^= MIPBAHKLDKD.GetHashCode();
      if (AHOAPFNIJNH != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(AHOAPFNIJNH);
      if (NGOPCAHLLID != 0) hash ^= NGOPCAHLLID.GetHashCode();
      if (Wave != 0) hash ^= Wave.GetHashCode();
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
      if (AvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AvatarId);
      }
      hJOMCJGGHLG_.WriteTo(output, _repeated_hJOMCJGGHLG_codec);
      if (Source != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Source);
      }
      if (Damage != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Damage);
      }
      dABOPBOFIBL_.WriteTo(output, _repeated_dABOPBOFIBL_codec);
      if (MIPBAHKLDKD != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MIPBAHKLDKD);
      }
      if (AHOAPFNIJNH != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(AHOAPFNIJNH);
      }
      if (NGOPCAHLLID != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NGOPCAHLLID);
      }
      if (Wave != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Wave);
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
      if (AvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AvatarId);
      }
      hJOMCJGGHLG_.WriteTo(ref output, _repeated_hJOMCJGGHLG_codec);
      if (Source != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Source);
      }
      if (Damage != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Damage);
      }
      dABOPBOFIBL_.WriteTo(ref output, _repeated_dABOPBOFIBL_codec);
      if (MIPBAHKLDKD != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MIPBAHKLDKD);
      }
      if (AHOAPFNIJNH != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(AHOAPFNIJNH);
      }
      if (NGOPCAHLLID != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NGOPCAHLLID);
      }
      if (Wave != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Wave);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      size += hJOMCJGGHLG_.CalculateSize(_repeated_hJOMCJGGHLG_codec);
      if (Source != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Source);
      }
      if (Damage != 0D) {
        size += 1 + 8;
      }
      size += dABOPBOFIBL_.CalculateSize(_repeated_dABOPBOFIBL_codec);
      if (MIPBAHKLDKD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MIPBAHKLDKD);
      }
      if (AHOAPFNIJNH != 0D) {
        size += 1 + 8;
      }
      if (NGOPCAHLLID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NGOPCAHLLID);
      }
      if (Wave != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Wave);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HBBJCGIACBE other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      hJOMCJGGHLG_.Add(other.hJOMCJGGHLG_);
      if (other.Source != 0) {
        Source = other.Source;
      }
      if (other.Damage != 0D) {
        Damage = other.Damage;
      }
      dABOPBOFIBL_.Add(other.dABOPBOFIBL_);
      if (other.MIPBAHKLDKD != 0) {
        MIPBAHKLDKD = other.MIPBAHKLDKD;
      }
      if (other.AHOAPFNIJNH != 0D) {
        AHOAPFNIJNH = other.AHOAPFNIJNH;
      }
      if (other.NGOPCAHLLID != 0) {
        NGOPCAHLLID = other.NGOPCAHLLID;
      }
      if (other.Wave != 0) {
        Wave = other.Wave;
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            hJOMCJGGHLG_.AddEntriesFrom(input, _repeated_hJOMCJGGHLG_codec);
            break;
          }
          case 24: {
            Source = input.ReadUInt32();
            break;
          }
          case 33: {
            Damage = input.ReadDouble();
            break;
          }
          case 42:
          case 40: {
            dABOPBOFIBL_.AddEntriesFrom(input, _repeated_dABOPBOFIBL_codec);
            break;
          }
          case 48: {
            MIPBAHKLDKD = input.ReadInt32();
            break;
          }
          case 57: {
            AHOAPFNIJNH = input.ReadDouble();
            break;
          }
          case 64: {
            NGOPCAHLLID = input.ReadUInt32();
            break;
          }
          case 72: {
            Wave = input.ReadUInt32();
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            hJOMCJGGHLG_.AddEntriesFrom(ref input, _repeated_hJOMCJGGHLG_codec);
            break;
          }
          case 24: {
            Source = input.ReadUInt32();
            break;
          }
          case 33: {
            Damage = input.ReadDouble();
            break;
          }
          case 42:
          case 40: {
            dABOPBOFIBL_.AddEntriesFrom(ref input, _repeated_dABOPBOFIBL_codec);
            break;
          }
          case 48: {
            MIPBAHKLDKD = input.ReadInt32();
            break;
          }
          case 57: {
            AHOAPFNIJNH = input.ReadDouble();
            break;
          }
          case 64: {
            NGOPCAHLLID = input.ReadUInt32();
            break;
          }
          case 72: {
            Wave = input.ReadUInt32();
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
