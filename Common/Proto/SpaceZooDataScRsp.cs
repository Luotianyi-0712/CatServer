// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooDataScRsp.proto</summary>
  public static partial class SpaceZooDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTcGFjZVpvb0RhdGFTY1JzcC5wcm90bxoRQUdGT0NOQUpER0wucHJvdG8a",
            "EUhCQUlIQUpCT05PLnByb3RvIugBChFTcGFjZVpvb0RhdGFTY1JzcBITCgtD",
            "TkpMSkFFSEdFRRgCIAMoDRITCgtDTElDQU1HUExLSBgDIAMoDRIhCgtJREJK",
            "R0pLRFBJRxgPIAMoCzIMLkFHRk9DTkFKREdMEhMKC05DTUNDRUhPSERLGAwg",
            "AygNEhMKC0RGR0pGS0JCS0FHGAUgAygNEhMKC0xGSUlETUxFTEZHGAEgASgN",
            "EiEKC0VNQkRDRUVFTUVFGAcgAygLMgwuSEJBSUhBSkJPTk8SEwoLQURITU5O",
            "T0NOQkgYCSADKA0SDwoHcmV0Y29kZRgNIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AGFOCNAJDGLReflection.Descriptor, global::EggLink.DanhengServer.Proto.HBAIHAJBONOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooDataScRsp), global::EggLink.DanhengServer.Proto.SpaceZooDataScRsp.Parser, new[]{ "CNJLJAEHGEE", "CLICAMGPLKH", "IDBJGJKDPIG", "NCMCCEHOHDK", "DFGJFKBBKAG", "LFIIDMLELFG", "EMBDCEEEMEE", "ADHMNNOCNBH", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooDataScRsp : pb::IMessage<SpaceZooDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooDataScRsp> _parser = new pb::MessageParser<SpaceZooDataScRsp>(() => new SpaceZooDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp(SpaceZooDataScRsp other) : this() {
      cNJLJAEHGEE_ = other.cNJLJAEHGEE_.Clone();
      cLICAMGPLKH_ = other.cLICAMGPLKH_.Clone();
      iDBJGJKDPIG_ = other.iDBJGJKDPIG_.Clone();
      nCMCCEHOHDK_ = other.nCMCCEHOHDK_.Clone();
      dFGJFKBBKAG_ = other.dFGJFKBBKAG_.Clone();
      lFIIDMLELFG_ = other.lFIIDMLELFG_;
      eMBDCEEEMEE_ = other.eMBDCEEEMEE_.Clone();
      aDHMNNOCNBH_ = other.aDHMNNOCNBH_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp Clone() {
      return new SpaceZooDataScRsp(this);
    }

    /// <summary>Field number for the "CNJLJAEHGEE" field.</summary>
    public const int CNJLJAEHGEEFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_cNJLJAEHGEE_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> cNJLJAEHGEE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CNJLJAEHGEE {
      get { return cNJLJAEHGEE_; }
    }

    /// <summary>Field number for the "CLICAMGPLKH" field.</summary>
    public const int CLICAMGPLKHFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_cLICAMGPLKH_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> cLICAMGPLKH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CLICAMGPLKH {
      get { return cLICAMGPLKH_; }
    }

    /// <summary>Field number for the "IDBJGJKDPIG" field.</summary>
    public const int IDBJGJKDPIGFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL> _repeated_iDBJGJKDPIG_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.AGFOCNAJDGL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL> iDBJGJKDPIG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AGFOCNAJDGL> IDBJGJKDPIG {
      get { return iDBJGJKDPIG_; }
    }

    /// <summary>Field number for the "NCMCCEHOHDK" field.</summary>
    public const int NCMCCEHOHDKFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_nCMCCEHOHDK_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> nCMCCEHOHDK_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NCMCCEHOHDK {
      get { return nCMCCEHOHDK_; }
    }

    /// <summary>Field number for the "DFGJFKBBKAG" field.</summary>
    public const int DFGJFKBBKAGFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_dFGJFKBBKAG_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> dFGJFKBBKAG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DFGJFKBBKAG {
      get { return dFGJFKBBKAG_; }
    }

    /// <summary>Field number for the "LFIIDMLELFG" field.</summary>
    public const int LFIIDMLELFGFieldNumber = 1;
    private uint lFIIDMLELFG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LFIIDMLELFG {
      get { return lFIIDMLELFG_; }
      set {
        lFIIDMLELFG_ = value;
      }
    }

    /// <summary>Field number for the "EMBDCEEEMEE" field.</summary>
    public const int EMBDCEEEMEEFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HBAIHAJBONO> _repeated_eMBDCEEEMEE_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.HBAIHAJBONO.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HBAIHAJBONO> eMBDCEEEMEE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HBAIHAJBONO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HBAIHAJBONO> EMBDCEEEMEE {
      get { return eMBDCEEEMEE_; }
    }

    /// <summary>Field number for the "ADHMNNOCNBH" field.</summary>
    public const int ADHMNNOCNBHFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_aDHMNNOCNBH_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> aDHMNNOCNBH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ADHMNNOCNBH {
      get { return aDHMNNOCNBH_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cNJLJAEHGEE_.Equals(other.cNJLJAEHGEE_)) return false;
      if(!cLICAMGPLKH_.Equals(other.cLICAMGPLKH_)) return false;
      if(!iDBJGJKDPIG_.Equals(other.iDBJGJKDPIG_)) return false;
      if(!nCMCCEHOHDK_.Equals(other.nCMCCEHOHDK_)) return false;
      if(!dFGJFKBBKAG_.Equals(other.dFGJFKBBKAG_)) return false;
      if (LFIIDMLELFG != other.LFIIDMLELFG) return false;
      if(!eMBDCEEEMEE_.Equals(other.eMBDCEEEMEE_)) return false;
      if(!aDHMNNOCNBH_.Equals(other.aDHMNNOCNBH_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cNJLJAEHGEE_.GetHashCode();
      hash ^= cLICAMGPLKH_.GetHashCode();
      hash ^= iDBJGJKDPIG_.GetHashCode();
      hash ^= nCMCCEHOHDK_.GetHashCode();
      hash ^= dFGJFKBBKAG_.GetHashCode();
      if (LFIIDMLELFG != 0) hash ^= LFIIDMLELFG.GetHashCode();
      hash ^= eMBDCEEEMEE_.GetHashCode();
      hash ^= aDHMNNOCNBH_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (LFIIDMLELFG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LFIIDMLELFG);
      }
      cNJLJAEHGEE_.WriteTo(output, _repeated_cNJLJAEHGEE_codec);
      cLICAMGPLKH_.WriteTo(output, _repeated_cLICAMGPLKH_codec);
      dFGJFKBBKAG_.WriteTo(output, _repeated_dFGJFKBBKAG_codec);
      eMBDCEEEMEE_.WriteTo(output, _repeated_eMBDCEEEMEE_codec);
      aDHMNNOCNBH_.WriteTo(output, _repeated_aDHMNNOCNBH_codec);
      nCMCCEHOHDK_.WriteTo(output, _repeated_nCMCCEHOHDK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      iDBJGJKDPIG_.WriteTo(output, _repeated_iDBJGJKDPIG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LFIIDMLELFG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LFIIDMLELFG);
      }
      cNJLJAEHGEE_.WriteTo(ref output, _repeated_cNJLJAEHGEE_codec);
      cLICAMGPLKH_.WriteTo(ref output, _repeated_cLICAMGPLKH_codec);
      dFGJFKBBKAG_.WriteTo(ref output, _repeated_dFGJFKBBKAG_codec);
      eMBDCEEEMEE_.WriteTo(ref output, _repeated_eMBDCEEEMEE_codec);
      aDHMNNOCNBH_.WriteTo(ref output, _repeated_aDHMNNOCNBH_codec);
      nCMCCEHOHDK_.WriteTo(ref output, _repeated_nCMCCEHOHDK_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      iDBJGJKDPIG_.WriteTo(ref output, _repeated_iDBJGJKDPIG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += cNJLJAEHGEE_.CalculateSize(_repeated_cNJLJAEHGEE_codec);
      size += cLICAMGPLKH_.CalculateSize(_repeated_cLICAMGPLKH_codec);
      size += iDBJGJKDPIG_.CalculateSize(_repeated_iDBJGJKDPIG_codec);
      size += nCMCCEHOHDK_.CalculateSize(_repeated_nCMCCEHOHDK_codec);
      size += dFGJFKBBKAG_.CalculateSize(_repeated_dFGJFKBBKAG_codec);
      if (LFIIDMLELFG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LFIIDMLELFG);
      }
      size += eMBDCEEEMEE_.CalculateSize(_repeated_eMBDCEEEMEE_codec);
      size += aDHMNNOCNBH_.CalculateSize(_repeated_aDHMNNOCNBH_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooDataScRsp other) {
      if (other == null) {
        return;
      }
      cNJLJAEHGEE_.Add(other.cNJLJAEHGEE_);
      cLICAMGPLKH_.Add(other.cLICAMGPLKH_);
      iDBJGJKDPIG_.Add(other.iDBJGJKDPIG_);
      nCMCCEHOHDK_.Add(other.nCMCCEHOHDK_);
      dFGJFKBBKAG_.Add(other.dFGJFKBBKAG_);
      if (other.LFIIDMLELFG != 0) {
        LFIIDMLELFG = other.LFIIDMLELFG;
      }
      eMBDCEEEMEE_.Add(other.eMBDCEEEMEE_);
      aDHMNNOCNBH_.Add(other.aDHMNNOCNBH_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            LFIIDMLELFG = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            cNJLJAEHGEE_.AddEntriesFrom(input, _repeated_cNJLJAEHGEE_codec);
            break;
          }
          case 26:
          case 24: {
            cLICAMGPLKH_.AddEntriesFrom(input, _repeated_cLICAMGPLKH_codec);
            break;
          }
          case 42:
          case 40: {
            dFGJFKBBKAG_.AddEntriesFrom(input, _repeated_dFGJFKBBKAG_codec);
            break;
          }
          case 58: {
            eMBDCEEEMEE_.AddEntriesFrom(input, _repeated_eMBDCEEEMEE_codec);
            break;
          }
          case 74:
          case 72: {
            aDHMNNOCNBH_.AddEntriesFrom(input, _repeated_aDHMNNOCNBH_codec);
            break;
          }
          case 98:
          case 96: {
            nCMCCEHOHDK_.AddEntriesFrom(input, _repeated_nCMCCEHOHDK_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122: {
            iDBJGJKDPIG_.AddEntriesFrom(input, _repeated_iDBJGJKDPIG_codec);
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
            LFIIDMLELFG = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            cNJLJAEHGEE_.AddEntriesFrom(ref input, _repeated_cNJLJAEHGEE_codec);
            break;
          }
          case 26:
          case 24: {
            cLICAMGPLKH_.AddEntriesFrom(ref input, _repeated_cLICAMGPLKH_codec);
            break;
          }
          case 42:
          case 40: {
            dFGJFKBBKAG_.AddEntriesFrom(ref input, _repeated_dFGJFKBBKAG_codec);
            break;
          }
          case 58: {
            eMBDCEEEMEE_.AddEntriesFrom(ref input, _repeated_eMBDCEEEMEE_codec);
            break;
          }
          case 74:
          case 72: {
            aDHMNNOCNBH_.AddEntriesFrom(ref input, _repeated_aDHMNNOCNBH_codec);
            break;
          }
          case 98:
          case 96: {
            nCMCCEHOHDK_.AddEntriesFrom(ref input, _repeated_nCMCCEHOHDK_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 122: {
            iDBJGJKDPIG_.AddEntriesFrom(ref input, _repeated_iDBJGJKDPIG_codec);
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
