// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuseumInfoChangedScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MuseumInfoChangedScNotify.proto</summary>
  public static partial class MuseumInfoChangedScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MuseumInfoChangedScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuseumInfoChangedScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9NdXNldW1JbmZvQ2hhbmdlZFNjTm90aWZ5LnByb3RvGhFNQkVNRUdPREVK",
            "TS5wcm90bxoRQ0NGT0tESU5BQ0sucHJvdG8aEUNNT0ZCR1BCR0RELnByb3Rv",
            "GhFISENOSFBFQklDRi5wcm90byLWAgoZTXVzZXVtSW5mb0NoYW5nZWRTY05v",
            "dGlmeRITCgtLUEtCS0tETkVIThgIIAEoDRITCgtESkpDR0RQR0NDSRgEIAEo",
            "DRITCgtQRktLQkdKT0VLShgFIAEoDRIhCgtGR09FRERCR0xERxgPIAEoCzIM",
            "LkhIQ05IUEVCSUNGEhMKC09GTkJFRUVFQkxEGAkgAygNEiEKC0FOTURFS09P",
            "QUZKGAYgAygLMgwuQ01PRkJHUEJHREQSIQoLR0JOSUtOS1BBQUQYCyADKAsy",
            "DC5DQ0ZPS0RJTkFDSxIhCgtKTU5PTUlFTEFHQhgOIAEoCzIMLk1CRU1FR09E",
            "RUpNEhMKC0JHTEpHR01QT09IGAIgASgNEg0KBWxldmVsGAogASgNEhMKC0xJ",
            "Q0xEREdJTExGGA0gAygNEhMKC0NBUFBPSEFMTENMGAMgASgNEgsKA2V4cBgB",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MBEMEGODEJMReflection.Descriptor, global::EggLink.DanhengServer.Proto.CCFOKDINACKReflection.Descriptor, global::EggLink.DanhengServer.Proto.CMOFBGPBGDDReflection.Descriptor, global::EggLink.DanhengServer.Proto.HHCNHPEBICFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MuseumInfoChangedScNotify), global::EggLink.DanhengServer.Proto.MuseumInfoChangedScNotify.Parser, new[]{ "KPKBKKDNEHN", "DJJCGDPGCCI", "PFKKBGJOEKJ", "FGOEDDBGLDG", "OFNBEEEEBLD", "ANMDEKOOAFJ", "GBNIKNKPAAD", "JMNOMIELAGB", "BGLJGGMPOOH", "Level", "LICLDDGILLF", "CAPPOHALLCL", "Exp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MuseumInfoChangedScNotify : pb::IMessage<MuseumInfoChangedScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuseumInfoChangedScNotify> _parser = new pb::MessageParser<MuseumInfoChangedScNotify>(() => new MuseumInfoChangedScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuseumInfoChangedScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MuseumInfoChangedScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumInfoChangedScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumInfoChangedScNotify(MuseumInfoChangedScNotify other) : this() {
      kPKBKKDNEHN_ = other.kPKBKKDNEHN_;
      dJJCGDPGCCI_ = other.dJJCGDPGCCI_;
      pFKKBGJOEKJ_ = other.pFKKBGJOEKJ_;
      fGOEDDBGLDG_ = other.fGOEDDBGLDG_ != null ? other.fGOEDDBGLDG_.Clone() : null;
      oFNBEEEEBLD_ = other.oFNBEEEEBLD_.Clone();
      aNMDEKOOAFJ_ = other.aNMDEKOOAFJ_.Clone();
      gBNIKNKPAAD_ = other.gBNIKNKPAAD_.Clone();
      jMNOMIELAGB_ = other.jMNOMIELAGB_ != null ? other.jMNOMIELAGB_.Clone() : null;
      bGLJGGMPOOH_ = other.bGLJGGMPOOH_;
      level_ = other.level_;
      lICLDDGILLF_ = other.lICLDDGILLF_.Clone();
      cAPPOHALLCL_ = other.cAPPOHALLCL_;
      exp_ = other.exp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuseumInfoChangedScNotify Clone() {
      return new MuseumInfoChangedScNotify(this);
    }

    /// <summary>Field number for the "KPKBKKDNEHN" field.</summary>
    public const int KPKBKKDNEHNFieldNumber = 8;
    private uint kPKBKKDNEHN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KPKBKKDNEHN {
      get { return kPKBKKDNEHN_; }
      set {
        kPKBKKDNEHN_ = value;
      }
    }

    /// <summary>Field number for the "DJJCGDPGCCI" field.</summary>
    public const int DJJCGDPGCCIFieldNumber = 4;
    private uint dJJCGDPGCCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DJJCGDPGCCI {
      get { return dJJCGDPGCCI_; }
      set {
        dJJCGDPGCCI_ = value;
      }
    }

    /// <summary>Field number for the "PFKKBGJOEKJ" field.</summary>
    public const int PFKKBGJOEKJFieldNumber = 5;
    private uint pFKKBGJOEKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PFKKBGJOEKJ {
      get { return pFKKBGJOEKJ_; }
      set {
        pFKKBGJOEKJ_ = value;
      }
    }

    /// <summary>Field number for the "FGOEDDBGLDG" field.</summary>
    public const int FGOEDDBGLDGFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.HHCNHPEBICF fGOEDDBGLDG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HHCNHPEBICF FGOEDDBGLDG {
      get { return fGOEDDBGLDG_; }
      set {
        fGOEDDBGLDG_ = value;
      }
    }

    /// <summary>Field number for the "OFNBEEEEBLD" field.</summary>
    public const int OFNBEEEEBLDFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_oFNBEEEEBLD_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> oFNBEEEEBLD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OFNBEEEEBLD {
      get { return oFNBEEEEBLD_; }
    }

    /// <summary>Field number for the "ANMDEKOOAFJ" field.</summary>
    public const int ANMDEKOOAFJFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CMOFBGPBGDD> _repeated_aNMDEKOOAFJ_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.CMOFBGPBGDD.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CMOFBGPBGDD> aNMDEKOOAFJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CMOFBGPBGDD>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CMOFBGPBGDD> ANMDEKOOAFJ {
      get { return aNMDEKOOAFJ_; }
    }

    /// <summary>Field number for the "GBNIKNKPAAD" field.</summary>
    public const int GBNIKNKPAADFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CCFOKDINACK> _repeated_gBNIKNKPAAD_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.CCFOKDINACK.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCFOKDINACK> gBNIKNKPAAD_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCFOKDINACK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCFOKDINACK> GBNIKNKPAAD {
      get { return gBNIKNKPAAD_; }
    }

    /// <summary>Field number for the "JMNOMIELAGB" field.</summary>
    public const int JMNOMIELAGBFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.MBEMEGODEJM jMNOMIELAGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MBEMEGODEJM JMNOMIELAGB {
      get { return jMNOMIELAGB_; }
      set {
        jMNOMIELAGB_ = value;
      }
    }

    /// <summary>Field number for the "BGLJGGMPOOH" field.</summary>
    public const int BGLJGGMPOOHFieldNumber = 2;
    private uint bGLJGGMPOOH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BGLJGGMPOOH {
      get { return bGLJGGMPOOH_; }
      set {
        bGLJGGMPOOH_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 10;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "LICLDDGILLF" field.</summary>
    public const int LICLDDGILLFFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_lICLDDGILLF_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> lICLDDGILLF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LICLDDGILLF {
      get { return lICLDDGILLF_; }
    }

    /// <summary>Field number for the "CAPPOHALLCL" field.</summary>
    public const int CAPPOHALLCLFieldNumber = 3;
    private uint cAPPOHALLCL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CAPPOHALLCL {
      get { return cAPPOHALLCL_; }
      set {
        cAPPOHALLCL_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 1;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuseumInfoChangedScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuseumInfoChangedScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KPKBKKDNEHN != other.KPKBKKDNEHN) return false;
      if (DJJCGDPGCCI != other.DJJCGDPGCCI) return false;
      if (PFKKBGJOEKJ != other.PFKKBGJOEKJ) return false;
      if (!object.Equals(FGOEDDBGLDG, other.FGOEDDBGLDG)) return false;
      if(!oFNBEEEEBLD_.Equals(other.oFNBEEEEBLD_)) return false;
      if(!aNMDEKOOAFJ_.Equals(other.aNMDEKOOAFJ_)) return false;
      if(!gBNIKNKPAAD_.Equals(other.gBNIKNKPAAD_)) return false;
      if (!object.Equals(JMNOMIELAGB, other.JMNOMIELAGB)) return false;
      if (BGLJGGMPOOH != other.BGLJGGMPOOH) return false;
      if (Level != other.Level) return false;
      if(!lICLDDGILLF_.Equals(other.lICLDDGILLF_)) return false;
      if (CAPPOHALLCL != other.CAPPOHALLCL) return false;
      if (Exp != other.Exp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KPKBKKDNEHN != 0) hash ^= KPKBKKDNEHN.GetHashCode();
      if (DJJCGDPGCCI != 0) hash ^= DJJCGDPGCCI.GetHashCode();
      if (PFKKBGJOEKJ != 0) hash ^= PFKKBGJOEKJ.GetHashCode();
      if (fGOEDDBGLDG_ != null) hash ^= FGOEDDBGLDG.GetHashCode();
      hash ^= oFNBEEEEBLD_.GetHashCode();
      hash ^= aNMDEKOOAFJ_.GetHashCode();
      hash ^= gBNIKNKPAAD_.GetHashCode();
      if (jMNOMIELAGB_ != null) hash ^= JMNOMIELAGB.GetHashCode();
      if (BGLJGGMPOOH != 0) hash ^= BGLJGGMPOOH.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= lICLDDGILLF_.GetHashCode();
      if (CAPPOHALLCL != 0) hash ^= CAPPOHALLCL.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (BGLJGGMPOOH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BGLJGGMPOOH);
      }
      if (CAPPOHALLCL != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CAPPOHALLCL);
      }
      if (DJJCGDPGCCI != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DJJCGDPGCCI);
      }
      if (PFKKBGJOEKJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PFKKBGJOEKJ);
      }
      aNMDEKOOAFJ_.WriteTo(output, _repeated_aNMDEKOOAFJ_codec);
      if (KPKBKKDNEHN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KPKBKKDNEHN);
      }
      oFNBEEEEBLD_.WriteTo(output, _repeated_oFNBEEEEBLD_codec);
      if (Level != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Level);
      }
      gBNIKNKPAAD_.WriteTo(output, _repeated_gBNIKNKPAAD_codec);
      lICLDDGILLF_.WriteTo(output, _repeated_lICLDDGILLF_codec);
      if (jMNOMIELAGB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(JMNOMIELAGB);
      }
      if (fGOEDDBGLDG_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FGOEDDBGLDG);
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
      if (Exp != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Exp);
      }
      if (BGLJGGMPOOH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BGLJGGMPOOH);
      }
      if (CAPPOHALLCL != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CAPPOHALLCL);
      }
      if (DJJCGDPGCCI != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DJJCGDPGCCI);
      }
      if (PFKKBGJOEKJ != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PFKKBGJOEKJ);
      }
      aNMDEKOOAFJ_.WriteTo(ref output, _repeated_aNMDEKOOAFJ_codec);
      if (KPKBKKDNEHN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KPKBKKDNEHN);
      }
      oFNBEEEEBLD_.WriteTo(ref output, _repeated_oFNBEEEEBLD_codec);
      if (Level != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Level);
      }
      gBNIKNKPAAD_.WriteTo(ref output, _repeated_gBNIKNKPAAD_codec);
      lICLDDGILLF_.WriteTo(ref output, _repeated_lICLDDGILLF_codec);
      if (jMNOMIELAGB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(JMNOMIELAGB);
      }
      if (fGOEDDBGLDG_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FGOEDDBGLDG);
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
      if (KPKBKKDNEHN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KPKBKKDNEHN);
      }
      if (DJJCGDPGCCI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DJJCGDPGCCI);
      }
      if (PFKKBGJOEKJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PFKKBGJOEKJ);
      }
      if (fGOEDDBGLDG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FGOEDDBGLDG);
      }
      size += oFNBEEEEBLD_.CalculateSize(_repeated_oFNBEEEEBLD_codec);
      size += aNMDEKOOAFJ_.CalculateSize(_repeated_aNMDEKOOAFJ_codec);
      size += gBNIKNKPAAD_.CalculateSize(_repeated_gBNIKNKPAAD_codec);
      if (jMNOMIELAGB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JMNOMIELAGB);
      }
      if (BGLJGGMPOOH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BGLJGGMPOOH);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += lICLDDGILLF_.CalculateSize(_repeated_lICLDDGILLF_codec);
      if (CAPPOHALLCL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CAPPOHALLCL);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuseumInfoChangedScNotify other) {
      if (other == null) {
        return;
      }
      if (other.KPKBKKDNEHN != 0) {
        KPKBKKDNEHN = other.KPKBKKDNEHN;
      }
      if (other.DJJCGDPGCCI != 0) {
        DJJCGDPGCCI = other.DJJCGDPGCCI;
      }
      if (other.PFKKBGJOEKJ != 0) {
        PFKKBGJOEKJ = other.PFKKBGJOEKJ;
      }
      if (other.fGOEDDBGLDG_ != null) {
        if (fGOEDDBGLDG_ == null) {
          FGOEDDBGLDG = new global::EggLink.DanhengServer.Proto.HHCNHPEBICF();
        }
        FGOEDDBGLDG.MergeFrom(other.FGOEDDBGLDG);
      }
      oFNBEEEEBLD_.Add(other.oFNBEEEEBLD_);
      aNMDEKOOAFJ_.Add(other.aNMDEKOOAFJ_);
      gBNIKNKPAAD_.Add(other.gBNIKNKPAAD_);
      if (other.jMNOMIELAGB_ != null) {
        if (jMNOMIELAGB_ == null) {
          JMNOMIELAGB = new global::EggLink.DanhengServer.Proto.MBEMEGODEJM();
        }
        JMNOMIELAGB.MergeFrom(other.JMNOMIELAGB);
      }
      if (other.BGLJGGMPOOH != 0) {
        BGLJGGMPOOH = other.BGLJGGMPOOH;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      lICLDDGILLF_.Add(other.lICLDDGILLF_);
      if (other.CAPPOHALLCL != 0) {
        CAPPOHALLCL = other.CAPPOHALLCL;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            BGLJGGMPOOH = input.ReadUInt32();
            break;
          }
          case 24: {
            CAPPOHALLCL = input.ReadUInt32();
            break;
          }
          case 32: {
            DJJCGDPGCCI = input.ReadUInt32();
            break;
          }
          case 40: {
            PFKKBGJOEKJ = input.ReadUInt32();
            break;
          }
          case 50: {
            aNMDEKOOAFJ_.AddEntriesFrom(input, _repeated_aNMDEKOOAFJ_codec);
            break;
          }
          case 64: {
            KPKBKKDNEHN = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            oFNBEEEEBLD_.AddEntriesFrom(input, _repeated_oFNBEEEEBLD_codec);
            break;
          }
          case 80: {
            Level = input.ReadUInt32();
            break;
          }
          case 90: {
            gBNIKNKPAAD_.AddEntriesFrom(input, _repeated_gBNIKNKPAAD_codec);
            break;
          }
          case 106:
          case 104: {
            lICLDDGILLF_.AddEntriesFrom(input, _repeated_lICLDDGILLF_codec);
            break;
          }
          case 114: {
            if (jMNOMIELAGB_ == null) {
              JMNOMIELAGB = new global::EggLink.DanhengServer.Proto.MBEMEGODEJM();
            }
            input.ReadMessage(JMNOMIELAGB);
            break;
          }
          case 122: {
            if (fGOEDDBGLDG_ == null) {
              FGOEDDBGLDG = new global::EggLink.DanhengServer.Proto.HHCNHPEBICF();
            }
            input.ReadMessage(FGOEDDBGLDG);
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
            Exp = input.ReadUInt32();
            break;
          }
          case 16: {
            BGLJGGMPOOH = input.ReadUInt32();
            break;
          }
          case 24: {
            CAPPOHALLCL = input.ReadUInt32();
            break;
          }
          case 32: {
            DJJCGDPGCCI = input.ReadUInt32();
            break;
          }
          case 40: {
            PFKKBGJOEKJ = input.ReadUInt32();
            break;
          }
          case 50: {
            aNMDEKOOAFJ_.AddEntriesFrom(ref input, _repeated_aNMDEKOOAFJ_codec);
            break;
          }
          case 64: {
            KPKBKKDNEHN = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            oFNBEEEEBLD_.AddEntriesFrom(ref input, _repeated_oFNBEEEEBLD_codec);
            break;
          }
          case 80: {
            Level = input.ReadUInt32();
            break;
          }
          case 90: {
            gBNIKNKPAAD_.AddEntriesFrom(ref input, _repeated_gBNIKNKPAAD_codec);
            break;
          }
          case 106:
          case 104: {
            lICLDDGILLF_.AddEntriesFrom(ref input, _repeated_lICLDDGILLF_codec);
            break;
          }
          case 114: {
            if (jMNOMIELAGB_ == null) {
              JMNOMIELAGB = new global::EggLink.DanhengServer.Proto.MBEMEGODEJM();
            }
            input.ReadMessage(JMNOMIELAGB);
            break;
          }
          case 122: {
            if (fGOEDDBGLDG_ == null) {
              FGOEDDBGLDG = new global::EggLink.DanhengServer.Proto.HHCNHPEBICF();
            }
            input.ReadMessage(FGOEDDBGLDG);
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
