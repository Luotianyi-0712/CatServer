// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueMiracle.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueMiracle.proto</summary>
  public static partial class RogueMiracleReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueMiracle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueMiracleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJSb2d1ZU1pcmFjbGUucHJvdG8itQEKDFJvZ3VlTWlyYWNsZRITCgtGRkxN",
            "Q09KQUpBSRgKIAEoDRIzCgtISUZLREhLSkdBQxgPIAMoCzIeLlJvZ3VlTWly",
            "YWNsZS5ISUZLREhLSkdBQ0VudHJ5EhMKC0NORk1HSkhGQUJEGAggASgNEhIK",
            "Cm1pcmFjbGVfaWQYDCABKA0aMgoQSElGS0RIS0pHQUNFbnRyeRILCgNrZXkY",
            "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueMiracle), global::EggLink.DanhengServer.Proto.RogueMiracle.Parser, new[]{ "FFLMCOJAJAI", "HIFKDHKJGAC", "CNFMGJHFABD", "MiracleId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueMiracle : pb::IMessage<RogueMiracle>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueMiracle> _parser = new pb::MessageParser<RogueMiracle>(() => new RogueMiracle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueMiracle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueMiracleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle(RogueMiracle other) : this() {
      fFLMCOJAJAI_ = other.fFLMCOJAJAI_;
      hIFKDHKJGAC_ = other.hIFKDHKJGAC_.Clone();
      cNFMGJHFABD_ = other.cNFMGJHFABD_;
      miracleId_ = other.miracleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueMiracle Clone() {
      return new RogueMiracle(this);
    }

    /// <summary>Field number for the "FFLMCOJAJAI" field.</summary>
    public const int FFLMCOJAJAIFieldNumber = 10;
    private uint fFLMCOJAJAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FFLMCOJAJAI {
      get { return fFLMCOJAJAI_; }
      set {
        fFLMCOJAJAI_ = value;
      }
    }

    /// <summary>Field number for the "HIFKDHKJGAC" field.</summary>
    public const int HIFKDHKJGACFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_hIFKDHKJGAC_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> hIFKDHKJGAC_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> HIFKDHKJGAC {
      get { return hIFKDHKJGAC_; }
    }

    /// <summary>Field number for the "CNFMGJHFABD" field.</summary>
    public const int CNFMGJHFABDFieldNumber = 8;
    private uint cNFMGJHFABD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNFMGJHFABD {
      get { return cNFMGJHFABD_; }
      set {
        cNFMGJHFABD_ = value;
      }
    }

    /// <summary>Field number for the "miracle_id" field.</summary>
    public const int MiracleIdFieldNumber = 12;
    private uint miracleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MiracleId {
      get { return miracleId_; }
      set {
        miracleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueMiracle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueMiracle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FFLMCOJAJAI != other.FFLMCOJAJAI) return false;
      if (!HIFKDHKJGAC.Equals(other.HIFKDHKJGAC)) return false;
      if (CNFMGJHFABD != other.CNFMGJHFABD) return false;
      if (MiracleId != other.MiracleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FFLMCOJAJAI != 0) hash ^= FFLMCOJAJAI.GetHashCode();
      hash ^= HIFKDHKJGAC.GetHashCode();
      if (CNFMGJHFABD != 0) hash ^= CNFMGJHFABD.GetHashCode();
      if (MiracleId != 0) hash ^= MiracleId.GetHashCode();
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
      if (CNFMGJHFABD != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CNFMGJHFABD);
      }
      if (FFLMCOJAJAI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FFLMCOJAJAI);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MiracleId);
      }
      hIFKDHKJGAC_.WriteTo(output, _map_hIFKDHKJGAC_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CNFMGJHFABD != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CNFMGJHFABD);
      }
      if (FFLMCOJAJAI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FFLMCOJAJAI);
      }
      if (MiracleId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MiracleId);
      }
      hIFKDHKJGAC_.WriteTo(ref output, _map_hIFKDHKJGAC_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FFLMCOJAJAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FFLMCOJAJAI);
      }
      size += hIFKDHKJGAC_.CalculateSize(_map_hIFKDHKJGAC_codec);
      if (CNFMGJHFABD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CNFMGJHFABD);
      }
      if (MiracleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MiracleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueMiracle other) {
      if (other == null) {
        return;
      }
      if (other.FFLMCOJAJAI != 0) {
        FFLMCOJAJAI = other.FFLMCOJAJAI;
      }
      hIFKDHKJGAC_.MergeFrom(other.hIFKDHKJGAC_);
      if (other.CNFMGJHFABD != 0) {
        CNFMGJHFABD = other.CNFMGJHFABD;
      }
      if (other.MiracleId != 0) {
        MiracleId = other.MiracleId;
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
          case 64: {
            CNFMGJHFABD = input.ReadUInt32();
            break;
          }
          case 80: {
            FFLMCOJAJAI = input.ReadUInt32();
            break;
          }
          case 96: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 122: {
            hIFKDHKJGAC_.AddEntriesFrom(input, _map_hIFKDHKJGAC_codec);
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
          case 64: {
            CNFMGJHFABD = input.ReadUInt32();
            break;
          }
          case 80: {
            FFLMCOJAJAI = input.ReadUInt32();
            break;
          }
          case 96: {
            MiracleId = input.ReadUInt32();
            break;
          }
          case 122: {
            hIFKDHKJGAC_.AddEntriesFrom(ref input, _map_hIFKDHKJGAC_codec);
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
