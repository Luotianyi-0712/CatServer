// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMapRotationDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMapRotationDataScRsp.proto</summary>
  public static partial class GetMapRotationDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMapRotationDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMapRotationDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRNYXBSb3RhdGlvbkRhdGFTY1JzcC5wcm90bxoRQ2hhcmdlckluZm8u",
            "cHJvdG8aEURNQU9NQ0JFQU5JLnByb3RvGhFOQ1BDT0tDSUJPRi5wcm90bxoR",
            "T0RJRlBHRERLSEwucHJvdG8i8gEKF0dldE1hcFJvdGF0aW9uRGF0YVNjUnNw",
            "EhMKC0tISUhEUEhPR0FMGA8gASgNEg8KB3JldGNvZGUYDSABKA0SEwoLTUNM",
            "S0VISEhMUEUYASABKAgSIQoLSE9LTUVJSUVHQVAYDCADKAsyDC5DaGFyZ2Vy",
            "SW5mbxITCgtIUEFBR0xKQUVERBgCIAEoBRIhCgtMTUZCTElFSUhKSxgIIAMo",
            "CzIMLkRNQU9NQ0JFQU5JEh4KCG1hcF9pbmZvGAYgASgLMgwuTkNQQ09LQ0lC",
            "T0YSIQoLSkhGREJJTklQRkUYDiABKAsyDC5PRElGUEdEREtITEIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChargerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DMAOMCBEANIReflection.Descriptor, global::EggLink.DanhengServer.Proto.NCPCOKCIBOFReflection.Descriptor, global::EggLink.DanhengServer.Proto.ODIFPGDDKHLReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMapRotationDataScRsp), global::EggLink.DanhengServer.Proto.GetMapRotationDataScRsp.Parser, new[]{ "KHIHDPHOGAL", "Retcode", "MCLKEHHHLPE", "HOKMEIIEGAP", "HPAAGLJAEDD", "LMFBLIEIHJK", "MapInfo", "JHFDBINIPFE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMapRotationDataScRsp : pb::IMessage<GetMapRotationDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMapRotationDataScRsp> _parser = new pb::MessageParser<GetMapRotationDataScRsp>(() => new GetMapRotationDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMapRotationDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMapRotationDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp(GetMapRotationDataScRsp other) : this() {
      kHIHDPHOGAL_ = other.kHIHDPHOGAL_;
      retcode_ = other.retcode_;
      mCLKEHHHLPE_ = other.mCLKEHHHLPE_;
      hOKMEIIEGAP_ = other.hOKMEIIEGAP_.Clone();
      hPAAGLJAEDD_ = other.hPAAGLJAEDD_;
      lMFBLIEIHJK_ = other.lMFBLIEIHJK_.Clone();
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      jHFDBINIPFE_ = other.jHFDBINIPFE_ != null ? other.jHFDBINIPFE_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMapRotationDataScRsp Clone() {
      return new GetMapRotationDataScRsp(this);
    }

    /// <summary>Field number for the "KHIHDPHOGAL" field.</summary>
    public const int KHIHDPHOGALFieldNumber = 15;
    private uint kHIHDPHOGAL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KHIHDPHOGAL {
      get { return kHIHDPHOGAL_; }
      set {
        kHIHDPHOGAL_ = value;
      }
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

    /// <summary>Field number for the "MCLKEHHHLPE" field.</summary>
    public const int MCLKEHHHLPEFieldNumber = 1;
    private bool mCLKEHHHLPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MCLKEHHHLPE {
      get { return mCLKEHHHLPE_; }
      set {
        mCLKEHHHLPE_ = value;
      }
    }

    /// <summary>Field number for the "HOKMEIIEGAP" field.</summary>
    public const int HOKMEIIEGAPFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChargerInfo> _repeated_hOKMEIIEGAP_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.ChargerInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> hOKMEIIEGAP_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> HOKMEIIEGAP {
      get { return hOKMEIIEGAP_; }
    }

    /// <summary>Field number for the "HPAAGLJAEDD" field.</summary>
    public const int HPAAGLJAEDDFieldNumber = 2;
    private int hPAAGLJAEDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HPAAGLJAEDD {
      get { return hPAAGLJAEDD_; }
      set {
        hPAAGLJAEDD_ = value;
      }
    }

    /// <summary>Field number for the "LMFBLIEIHJK" field.</summary>
    public const int LMFBLIEIHJKFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DMAOMCBEANI> _repeated_lMFBLIEIHJK_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.DMAOMCBEANI.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DMAOMCBEANI> lMFBLIEIHJK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DMAOMCBEANI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DMAOMCBEANI> LMFBLIEIHJK {
      get { return lMFBLIEIHJK_; }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.NCPCOKCIBOF mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NCPCOKCIBOF MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "JHFDBINIPFE" field.</summary>
    public const int JHFDBINIPFEFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ODIFPGDDKHL jHFDBINIPFE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ODIFPGDDKHL JHFDBINIPFE {
      get { return jHFDBINIPFE_; }
      set {
        jHFDBINIPFE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMapRotationDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMapRotationDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KHIHDPHOGAL != other.KHIHDPHOGAL) return false;
      if (Retcode != other.Retcode) return false;
      if (MCLKEHHHLPE != other.MCLKEHHHLPE) return false;
      if(!hOKMEIIEGAP_.Equals(other.hOKMEIIEGAP_)) return false;
      if (HPAAGLJAEDD != other.HPAAGLJAEDD) return false;
      if(!lMFBLIEIHJK_.Equals(other.lMFBLIEIHJK_)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (!object.Equals(JHFDBINIPFE, other.JHFDBINIPFE)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KHIHDPHOGAL != 0) hash ^= KHIHDPHOGAL.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (MCLKEHHHLPE != false) hash ^= MCLKEHHHLPE.GetHashCode();
      hash ^= hOKMEIIEGAP_.GetHashCode();
      if (HPAAGLJAEDD != 0) hash ^= HPAAGLJAEDD.GetHashCode();
      hash ^= lMFBLIEIHJK_.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (jHFDBINIPFE_ != null) hash ^= JHFDBINIPFE.GetHashCode();
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
      if (MCLKEHHHLPE != false) {
        output.WriteRawTag(8);
        output.WriteBool(MCLKEHHHLPE);
      }
      if (HPAAGLJAEDD != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(HPAAGLJAEDD);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(MapInfo);
      }
      lMFBLIEIHJK_.WriteTo(output, _repeated_lMFBLIEIHJK_codec);
      hOKMEIIEGAP_.WriteTo(output, _repeated_hOKMEIIEGAP_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (jHFDBINIPFE_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(JHFDBINIPFE);
      }
      if (KHIHDPHOGAL != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KHIHDPHOGAL);
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
      if (MCLKEHHHLPE != false) {
        output.WriteRawTag(8);
        output.WriteBool(MCLKEHHHLPE);
      }
      if (HPAAGLJAEDD != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(HPAAGLJAEDD);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(MapInfo);
      }
      lMFBLIEIHJK_.WriteTo(ref output, _repeated_lMFBLIEIHJK_codec);
      hOKMEIIEGAP_.WriteTo(ref output, _repeated_hOKMEIIEGAP_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (jHFDBINIPFE_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(JHFDBINIPFE);
      }
      if (KHIHDPHOGAL != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KHIHDPHOGAL);
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
      if (KHIHDPHOGAL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KHIHDPHOGAL);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (MCLKEHHHLPE != false) {
        size += 1 + 1;
      }
      size += hOKMEIIEGAP_.CalculateSize(_repeated_hOKMEIIEGAP_codec);
      if (HPAAGLJAEDD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HPAAGLJAEDD);
      }
      size += lMFBLIEIHJK_.CalculateSize(_repeated_lMFBLIEIHJK_codec);
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (jHFDBINIPFE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JHFDBINIPFE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMapRotationDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.KHIHDPHOGAL != 0) {
        KHIHDPHOGAL = other.KHIHDPHOGAL;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.MCLKEHHHLPE != false) {
        MCLKEHHHLPE = other.MCLKEHHHLPE;
      }
      hOKMEIIEGAP_.Add(other.hOKMEIIEGAP_);
      if (other.HPAAGLJAEDD != 0) {
        HPAAGLJAEDD = other.HPAAGLJAEDD;
      }
      lMFBLIEIHJK_.Add(other.lMFBLIEIHJK_);
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.NCPCOKCIBOF();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.jHFDBINIPFE_ != null) {
        if (jHFDBINIPFE_ == null) {
          JHFDBINIPFE = new global::EggLink.DanhengServer.Proto.ODIFPGDDKHL();
        }
        JHFDBINIPFE.MergeFrom(other.JHFDBINIPFE);
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
            MCLKEHHHLPE = input.ReadBool();
            break;
          }
          case 16: {
            HPAAGLJAEDD = input.ReadInt32();
            break;
          }
          case 50: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.NCPCOKCIBOF();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 66: {
            lMFBLIEIHJK_.AddEntriesFrom(input, _repeated_lMFBLIEIHJK_codec);
            break;
          }
          case 98: {
            hOKMEIIEGAP_.AddEntriesFrom(input, _repeated_hOKMEIIEGAP_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (jHFDBINIPFE_ == null) {
              JHFDBINIPFE = new global::EggLink.DanhengServer.Proto.ODIFPGDDKHL();
            }
            input.ReadMessage(JHFDBINIPFE);
            break;
          }
          case 120: {
            KHIHDPHOGAL = input.ReadUInt32();
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
            MCLKEHHHLPE = input.ReadBool();
            break;
          }
          case 16: {
            HPAAGLJAEDD = input.ReadInt32();
            break;
          }
          case 50: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.NCPCOKCIBOF();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 66: {
            lMFBLIEIHJK_.AddEntriesFrom(ref input, _repeated_lMFBLIEIHJK_codec);
            break;
          }
          case 98: {
            hOKMEIIEGAP_.AddEntriesFrom(ref input, _repeated_hOKMEIIEGAP_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (jHFDBINIPFE_ == null) {
              JHFDBINIPFE = new global::EggLink.DanhengServer.Proto.ODIFPGDDKHL();
            }
            input.ReadMessage(JHFDBINIPFE);
            break;
          }
          case 120: {
            KHIHDPHOGAL = input.ReadUInt32();
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
