// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueNousDice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueNousDice.proto</summary>
  public static partial class ChessRogueNousDiceReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueNousDice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueNousDiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlTm91c0RpY2UucHJvdG8aHENoZXNzUm9ndWVOb3VzRGlj",
            "ZUluZm8ucHJvdG8iwQIKEkNoZXNzUm9ndWVOb3VzRGljZRITCgtHRkdDUEpP",
            "SE1FTBgJIAEoDRIZChFjdXJfc3VyZmFjZV9pbmRleBgNIAEoDRIUCgtOT0dK",
            "TU1FREdMTBjBBiADKA0SFAoMcmVyb2xsX3RpbWVzGAIgASgNEisKCWRpY2Vf",
            "aW5mbxjQASABKAsyFy5DaGVzc1JvZ3VlTm91c0RpY2VJbmZvEh0KFWRpY2Vf",
            "YnJhbmNoX2lkX3JlbW90ZRgOIAEoDRIWCg5kaWNlX2JyYW5jaF9pZBgBIAEo",
            "DRIUCgtDSEdMTUxEQU1KSBihCSABKAgSEwoLY2hlYXRfdGltZXMYBCABKA0S",
            "EwoLSElKQk9QTUdCQVAYBSABKA0SEwoLQkRFTkFERE9DQUMYCiABKAgSFgoO",
            "Y3VyX3N1cmZhY2VfaWQYAyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZl",
            "ci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueNousDice), global::EggLink.DanhengServer.Proto.ChessRogueNousDice.Parser, new[]{ "GFGCPJOHMEL", "CurSurfaceIndex", "NOGJMMEDGLL", "RerollTimes", "DiceInfo", "DiceBranchIdRemote", "DiceBranchId", "CHGLMLDAMJH", "CheatTimes", "HIJBOPMGBAP", "BDENADDOCAC", "CurSurfaceId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueNousDice : pb::IMessage<ChessRogueNousDice>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueNousDice> _parser = new pb::MessageParser<ChessRogueNousDice>(() => new ChessRogueNousDice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueNousDice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueNousDiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDice(ChessRogueNousDice other) : this() {
      gFGCPJOHMEL_ = other.gFGCPJOHMEL_;
      curSurfaceIndex_ = other.curSurfaceIndex_;
      nOGJMMEDGLL_ = other.nOGJMMEDGLL_.Clone();
      rerollTimes_ = other.rerollTimes_;
      diceInfo_ = other.diceInfo_ != null ? other.diceInfo_.Clone() : null;
      diceBranchIdRemote_ = other.diceBranchIdRemote_;
      diceBranchId_ = other.diceBranchId_;
      cHGLMLDAMJH_ = other.cHGLMLDAMJH_;
      cheatTimes_ = other.cheatTimes_;
      hIJBOPMGBAP_ = other.hIJBOPMGBAP_;
      bDENADDOCAC_ = other.bDENADDOCAC_;
      curSurfaceId_ = other.curSurfaceId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDice Clone() {
      return new ChessRogueNousDice(this);
    }

    /// <summary>Field number for the "GFGCPJOHMEL" field.</summary>
    public const int GFGCPJOHMELFieldNumber = 9;
    private uint gFGCPJOHMEL_;
    /// <summary>
    /// 1
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GFGCPJOHMEL {
      get { return gFGCPJOHMEL_; }
      set {
        gFGCPJOHMEL_ = value;
      }
    }

    /// <summary>Field number for the "cur_surface_index" field.</summary>
    public const int CurSurfaceIndexFieldNumber = 13;
    private uint curSurfaceIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSurfaceIndex {
      get { return curSurfaceIndex_; }
      set {
        curSurfaceIndex_ = value;
      }
    }

    /// <summary>Field number for the "NOGJMMEDGLL" field.</summary>
    public const int NOGJMMEDGLLFieldNumber = 833;
    private static readonly pb::FieldCodec<uint> _repeated_nOGJMMEDGLL_codec
        = pb::FieldCodec.ForUInt32(6666);
    private readonly pbc::RepeatedField<uint> nOGJMMEDGLL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NOGJMMEDGLL {
      get { return nOGJMMEDGLL_; }
    }

    /// <summary>Field number for the "reroll_times" field.</summary>
    public const int RerollTimesFieldNumber = 2;
    private uint rerollTimes_;
    /// <summary>
    ///FEDEMDEEJML JLCEDGIHAFF = 12;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RerollTimes {
      get { return rerollTimes_; }
      set {
        rerollTimes_ = value;
      }
    }

    /// <summary>Field number for the "dice_info" field.</summary>
    public const int DiceInfoFieldNumber = 208;
    private global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo diceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo DiceInfo {
      get { return diceInfo_; }
      set {
        diceInfo_ = value;
      }
    }

    /// <summary>Field number for the "dice_branch_id_remote" field.</summary>
    public const int DiceBranchIdRemoteFieldNumber = 14;
    private uint diceBranchIdRemote_;
    /// <summary>
    /// idk
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiceBranchIdRemote {
      get { return diceBranchIdRemote_; }
      set {
        diceBranchIdRemote_ = value;
      }
    }

    /// <summary>Field number for the "dice_branch_id" field.</summary>
    public const int DiceBranchIdFieldNumber = 1;
    private uint diceBranchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiceBranchId {
      get { return diceBranchId_; }
      set {
        diceBranchId_ = value;
      }
    }

    /// <summary>Field number for the "CHGLMLDAMJH" field.</summary>
    public const int CHGLMLDAMJHFieldNumber = 1185;
    private bool cHGLMLDAMJH_;
    /// <summary>
    ///NMNBNLMAJGC POHKHEGDOHO = 343;  // guess its about modifier
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CHGLMLDAMJH {
      get { return cHGLMLDAMJH_; }
      set {
        cHGLMLDAMJH_ = value;
      }
    }

    /// <summary>Field number for the "cheat_times" field.</summary>
    public const int CheatTimesFieldNumber = 4;
    private uint cheatTimes_;
    /// <summary>
    /// 1
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CheatTimes {
      get { return cheatTimes_; }
      set {
        cheatTimes_ = value;
      }
    }

    /// <summary>Field number for the "HIJBOPMGBAP" field.</summary>
    public const int HIJBOPMGBAPFieldNumber = 5;
    private uint hIJBOPMGBAP_;
    /// <summary>
    /// 10
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HIJBOPMGBAP {
      get { return hIJBOPMGBAP_; }
      set {
        hIJBOPMGBAP_ = value;
      }
    }

    /// <summary>Field number for the "BDENADDOCAC" field.</summary>
    public const int BDENADDOCACFieldNumber = 10;
    private bool bDENADDOCAC_;
    /// <summary>
    ///sint32 PAOHKKNCNCD = 625;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BDENADDOCAC {
      get { return bDENADDOCAC_; }
      set {
        bDENADDOCAC_ = value;
      }
    }

    /// <summary>Field number for the "cur_surface_id" field.</summary>
    public const int CurSurfaceIdFieldNumber = 3;
    private uint curSurfaceId_;
    /// <summary>
    ///NMNBNLMAJGC cur_surface_effect = 6;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSurfaceId {
      get { return curSurfaceId_; }
      set {
        curSurfaceId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueNousDice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueNousDice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GFGCPJOHMEL != other.GFGCPJOHMEL) return false;
      if (CurSurfaceIndex != other.CurSurfaceIndex) return false;
      if(!nOGJMMEDGLL_.Equals(other.nOGJMMEDGLL_)) return false;
      if (RerollTimes != other.RerollTimes) return false;
      if (!object.Equals(DiceInfo, other.DiceInfo)) return false;
      if (DiceBranchIdRemote != other.DiceBranchIdRemote) return false;
      if (DiceBranchId != other.DiceBranchId) return false;
      if (CHGLMLDAMJH != other.CHGLMLDAMJH) return false;
      if (CheatTimes != other.CheatTimes) return false;
      if (HIJBOPMGBAP != other.HIJBOPMGBAP) return false;
      if (BDENADDOCAC != other.BDENADDOCAC) return false;
      if (CurSurfaceId != other.CurSurfaceId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GFGCPJOHMEL != 0) hash ^= GFGCPJOHMEL.GetHashCode();
      if (CurSurfaceIndex != 0) hash ^= CurSurfaceIndex.GetHashCode();
      hash ^= nOGJMMEDGLL_.GetHashCode();
      if (RerollTimes != 0) hash ^= RerollTimes.GetHashCode();
      if (diceInfo_ != null) hash ^= DiceInfo.GetHashCode();
      if (DiceBranchIdRemote != 0) hash ^= DiceBranchIdRemote.GetHashCode();
      if (DiceBranchId != 0) hash ^= DiceBranchId.GetHashCode();
      if (CHGLMLDAMJH != false) hash ^= CHGLMLDAMJH.GetHashCode();
      if (CheatTimes != 0) hash ^= CheatTimes.GetHashCode();
      if (HIJBOPMGBAP != 0) hash ^= HIJBOPMGBAP.GetHashCode();
      if (BDENADDOCAC != false) hash ^= BDENADDOCAC.GetHashCode();
      if (CurSurfaceId != 0) hash ^= CurSurfaceId.GetHashCode();
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
      if (DiceBranchId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DiceBranchId);
      }
      if (RerollTimes != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RerollTimes);
      }
      if (CurSurfaceId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurSurfaceId);
      }
      if (CheatTimes != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CheatTimes);
      }
      if (HIJBOPMGBAP != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HIJBOPMGBAP);
      }
      if (GFGCPJOHMEL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GFGCPJOHMEL);
      }
      if (BDENADDOCAC != false) {
        output.WriteRawTag(80);
        output.WriteBool(BDENADDOCAC);
      }
      if (CurSurfaceIndex != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CurSurfaceIndex);
      }
      if (DiceBranchIdRemote != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DiceBranchIdRemote);
      }
      if (diceInfo_ != null) {
        output.WriteRawTag(130, 13);
        output.WriteMessage(DiceInfo);
      }
      nOGJMMEDGLL_.WriteTo(output, _repeated_nOGJMMEDGLL_codec);
      if (CHGLMLDAMJH != false) {
        output.WriteRawTag(136, 74);
        output.WriteBool(CHGLMLDAMJH);
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
      if (DiceBranchId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DiceBranchId);
      }
      if (RerollTimes != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RerollTimes);
      }
      if (CurSurfaceId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CurSurfaceId);
      }
      if (CheatTimes != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CheatTimes);
      }
      if (HIJBOPMGBAP != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(HIJBOPMGBAP);
      }
      if (GFGCPJOHMEL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GFGCPJOHMEL);
      }
      if (BDENADDOCAC != false) {
        output.WriteRawTag(80);
        output.WriteBool(BDENADDOCAC);
      }
      if (CurSurfaceIndex != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CurSurfaceIndex);
      }
      if (DiceBranchIdRemote != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DiceBranchIdRemote);
      }
      if (diceInfo_ != null) {
        output.WriteRawTag(130, 13);
        output.WriteMessage(DiceInfo);
      }
      nOGJMMEDGLL_.WriteTo(ref output, _repeated_nOGJMMEDGLL_codec);
      if (CHGLMLDAMJH != false) {
        output.WriteRawTag(136, 74);
        output.WriteBool(CHGLMLDAMJH);
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
      if (GFGCPJOHMEL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GFGCPJOHMEL);
      }
      if (CurSurfaceIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSurfaceIndex);
      }
      size += nOGJMMEDGLL_.CalculateSize(_repeated_nOGJMMEDGLL_codec);
      if (RerollTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RerollTimes);
      }
      if (diceInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DiceInfo);
      }
      if (DiceBranchIdRemote != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiceBranchIdRemote);
      }
      if (DiceBranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiceBranchId);
      }
      if (CHGLMLDAMJH != false) {
        size += 2 + 1;
      }
      if (CheatTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CheatTimes);
      }
      if (HIJBOPMGBAP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HIJBOPMGBAP);
      }
      if (BDENADDOCAC != false) {
        size += 1 + 1;
      }
      if (CurSurfaceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSurfaceId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueNousDice other) {
      if (other == null) {
        return;
      }
      if (other.GFGCPJOHMEL != 0) {
        GFGCPJOHMEL = other.GFGCPJOHMEL;
      }
      if (other.CurSurfaceIndex != 0) {
        CurSurfaceIndex = other.CurSurfaceIndex;
      }
      nOGJMMEDGLL_.Add(other.nOGJMMEDGLL_);
      if (other.RerollTimes != 0) {
        RerollTimes = other.RerollTimes;
      }
      if (other.diceInfo_ != null) {
        if (diceInfo_ == null) {
          DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo();
        }
        DiceInfo.MergeFrom(other.DiceInfo);
      }
      if (other.DiceBranchIdRemote != 0) {
        DiceBranchIdRemote = other.DiceBranchIdRemote;
      }
      if (other.DiceBranchId != 0) {
        DiceBranchId = other.DiceBranchId;
      }
      if (other.CHGLMLDAMJH != false) {
        CHGLMLDAMJH = other.CHGLMLDAMJH;
      }
      if (other.CheatTimes != 0) {
        CheatTimes = other.CheatTimes;
      }
      if (other.HIJBOPMGBAP != 0) {
        HIJBOPMGBAP = other.HIJBOPMGBAP;
      }
      if (other.BDENADDOCAC != false) {
        BDENADDOCAC = other.BDENADDOCAC;
      }
      if (other.CurSurfaceId != 0) {
        CurSurfaceId = other.CurSurfaceId;
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
            DiceBranchId = input.ReadUInt32();
            break;
          }
          case 16: {
            RerollTimes = input.ReadUInt32();
            break;
          }
          case 24: {
            CurSurfaceId = input.ReadUInt32();
            break;
          }
          case 32: {
            CheatTimes = input.ReadUInt32();
            break;
          }
          case 40: {
            HIJBOPMGBAP = input.ReadUInt32();
            break;
          }
          case 72: {
            GFGCPJOHMEL = input.ReadUInt32();
            break;
          }
          case 80: {
            BDENADDOCAC = input.ReadBool();
            break;
          }
          case 104: {
            CurSurfaceIndex = input.ReadUInt32();
            break;
          }
          case 112: {
            DiceBranchIdRemote = input.ReadUInt32();
            break;
          }
          case 1666: {
            if (diceInfo_ == null) {
              DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo();
            }
            input.ReadMessage(DiceInfo);
            break;
          }
          case 6666:
          case 6664: {
            nOGJMMEDGLL_.AddEntriesFrom(input, _repeated_nOGJMMEDGLL_codec);
            break;
          }
          case 9480: {
            CHGLMLDAMJH = input.ReadBool();
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
            DiceBranchId = input.ReadUInt32();
            break;
          }
          case 16: {
            RerollTimes = input.ReadUInt32();
            break;
          }
          case 24: {
            CurSurfaceId = input.ReadUInt32();
            break;
          }
          case 32: {
            CheatTimes = input.ReadUInt32();
            break;
          }
          case 40: {
            HIJBOPMGBAP = input.ReadUInt32();
            break;
          }
          case 72: {
            GFGCPJOHMEL = input.ReadUInt32();
            break;
          }
          case 80: {
            BDENADDOCAC = input.ReadBool();
            break;
          }
          case 104: {
            CurSurfaceIndex = input.ReadUInt32();
            break;
          }
          case 112: {
            DiceBranchIdRemote = input.ReadUInt32();
            break;
          }
          case 1666: {
            if (diceInfo_ == null) {
              DiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo();
            }
            input.ReadMessage(DiceInfo);
            break;
          }
          case 6666:
          case 6664: {
            nOGJMMEDGLL_.AddEntriesFrom(ref input, _repeated_nOGJMMEDGLL_codec);
            break;
          }
          case 9480: {
            CHGLMLDAMJH = input.ReadBool();
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
