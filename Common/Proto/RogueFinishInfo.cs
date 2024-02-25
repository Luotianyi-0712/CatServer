// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueFinishInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueFinishInfo.proto</summary>
  public static partial class RogueFinishInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueFinishInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueFinishInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZUZpbmlzaEluZm8ucHJvdG8aGlJvZ3VlU2NvcmVSZXdhcmRJbmZv",
            "LnByb3RvGhVSb2d1ZVJlY29yZEluZm8ucHJvdG8aDkl0ZW1MaXN0LnByb3Rv",
            "Ir8DCg9Sb2d1ZUZpbmlzaEluZm8SFwoPcGFzc19yb29tX2NvdW50GAwgASgN",
            "EhMKC0JGQ0JIUENQQU9JGAIgASgIEjQKFWN1cl9zY29yZV9yZXdhcmRfaW5m",
            "bxgKIAEoCzIVLlJvZ3VlU2NvcmVSZXdhcmRJbmZvEhAKB2FyZWFfaWQYhAIg",
            "ASgNEiUKC3JlY29yZF9pbmZvGA8gASgLMhAuUm9ndWVSZWNvcmRJbmZvEhMK",
            "C3Rha2VuX3Njb3JlGAYgASgNEh4KC0xCTEVMQ1BQTENJGA0gASgLMgkuSXRl",
            "bUxpc3QSEwoLQU5CRkdPS05FSUEYBCABKA0SMAoRc2NvcmVfcmV3YXJkX2lu",
            "Zm8YBSABKAsyFS5Sb2d1ZVNjb3JlUmV3YXJkSW5mbxIOCgZpc193aW4YCSAB",
            "KAgSHgoLSVBOR01NSU9KSkIYDiABKAsyCS5JdGVtTGlzdBIZChByZWFjaF9y",
            "b29tX2NvdW50GI8CIAEoDRITCgtCQ0tQSEJPUENDThgIIAEoDRIeCgtJQ09D",
            "TFBCTEZOThgDIAEoCzIJLkl0ZW1MaXN0EhMKC3RvdGFsX3Njb3JlGAEgASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueScoreRewardInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueRecordInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueFinishInfo), global::EggLink.DanhengServer.Proto.RogueFinishInfo.Parser, new[]{ "PassRoomCount", "BFCBHPCPAOI", "CurScoreRewardInfo", "AreaId", "RecordInfo", "TakenScore", "LBLELCPPLCI", "ANBFGOKNEIA", "ScoreRewardInfo", "IsWin", "IPNGMMIOJJB", "ReachRoomCount", "BCKPHBOPCCN", "ICOCLPBLFNN", "TotalScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueFinishInfo : pb::IMessage<RogueFinishInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueFinishInfo> _parser = new pb::MessageParser<RogueFinishInfo>(() => new RogueFinishInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueFinishInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueFinishInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueFinishInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueFinishInfo(RogueFinishInfo other) : this() {
      passRoomCount_ = other.passRoomCount_;
      bFCBHPCPAOI_ = other.bFCBHPCPAOI_;
      curScoreRewardInfo_ = other.curScoreRewardInfo_ != null ? other.curScoreRewardInfo_.Clone() : null;
      areaId_ = other.areaId_;
      recordInfo_ = other.recordInfo_ != null ? other.recordInfo_.Clone() : null;
      takenScore_ = other.takenScore_;
      lBLELCPPLCI_ = other.lBLELCPPLCI_ != null ? other.lBLELCPPLCI_.Clone() : null;
      aNBFGOKNEIA_ = other.aNBFGOKNEIA_;
      scoreRewardInfo_ = other.scoreRewardInfo_ != null ? other.scoreRewardInfo_.Clone() : null;
      isWin_ = other.isWin_;
      iPNGMMIOJJB_ = other.iPNGMMIOJJB_ != null ? other.iPNGMMIOJJB_.Clone() : null;
      reachRoomCount_ = other.reachRoomCount_;
      bCKPHBOPCCN_ = other.bCKPHBOPCCN_;
      iCOCLPBLFNN_ = other.iCOCLPBLFNN_ != null ? other.iCOCLPBLFNN_.Clone() : null;
      totalScore_ = other.totalScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueFinishInfo Clone() {
      return new RogueFinishInfo(this);
    }

    /// <summary>Field number for the "pass_room_count" field.</summary>
    public const int PassRoomCountFieldNumber = 12;
    private uint passRoomCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PassRoomCount {
      get { return passRoomCount_; }
      set {
        passRoomCount_ = value;
      }
    }

    /// <summary>Field number for the "BFCBHPCPAOI" field.</summary>
    public const int BFCBHPCPAOIFieldNumber = 2;
    private bool bFCBHPCPAOI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BFCBHPCPAOI {
      get { return bFCBHPCPAOI_; }
      set {
        bFCBHPCPAOI_ = value;
      }
    }

    /// <summary>Field number for the "cur_score_reward_info" field.</summary>
    public const int CurScoreRewardInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo curScoreRewardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo CurScoreRewardInfo {
      get { return curScoreRewardInfo_; }
      set {
        curScoreRewardInfo_ = value;
      }
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 260;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "record_info" field.</summary>
    public const int RecordInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.RogueRecordInfo recordInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueRecordInfo RecordInfo {
      get { return recordInfo_; }
      set {
        recordInfo_ = value;
      }
    }

    /// <summary>Field number for the "taken_score" field.</summary>
    public const int TakenScoreFieldNumber = 6;
    private uint takenScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TakenScore {
      get { return takenScore_; }
      set {
        takenScore_ = value;
      }
    }

    /// <summary>Field number for the "LBLELCPPLCI" field.</summary>
    public const int LBLELCPPLCIFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.ItemList lBLELCPPLCI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList LBLELCPPLCI {
      get { return lBLELCPPLCI_; }
      set {
        lBLELCPPLCI_ = value;
      }
    }

    /// <summary>Field number for the "ANBFGOKNEIA" field.</summary>
    public const int ANBFGOKNEIAFieldNumber = 4;
    private uint aNBFGOKNEIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ANBFGOKNEIA {
      get { return aNBFGOKNEIA_; }
      set {
        aNBFGOKNEIA_ = value;
      }
    }

    /// <summary>Field number for the "score_reward_info" field.</summary>
    public const int ScoreRewardInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo scoreRewardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo ScoreRewardInfo {
      get { return scoreRewardInfo_; }
      set {
        scoreRewardInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 9;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "IPNGMMIOJJB" field.</summary>
    public const int IPNGMMIOJJBFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ItemList iPNGMMIOJJB_;
    /// <summary>
    ///MMOCIHBBOMA LDFFDAMFFFO = 11;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList IPNGMMIOJJB {
      get { return iPNGMMIOJJB_; }
      set {
        iPNGMMIOJJB_ = value;
      }
    }

    /// <summary>Field number for the "reach_room_count" field.</summary>
    public const int ReachRoomCountFieldNumber = 271;
    private uint reachRoomCount_;
    /// <summary>
    ///HNNAOBNKFLO LAOLNLHIECJ = 7;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReachRoomCount {
      get { return reachRoomCount_; }
      set {
        reachRoomCount_ = value;
      }
    }

    /// <summary>Field number for the "BCKPHBOPCCN" field.</summary>
    public const int BCKPHBOPCCNFieldNumber = 8;
    private uint bCKPHBOPCCN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BCKPHBOPCCN {
      get { return bCKPHBOPCCN_; }
      set {
        bCKPHBOPCCN_ = value;
      }
    }

    /// <summary>Field number for the "ICOCLPBLFNN" field.</summary>
    public const int ICOCLPBLFNNFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ItemList iCOCLPBLFNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList ICOCLPBLFNN {
      get { return iCOCLPBLFNN_; }
      set {
        iCOCLPBLFNN_ = value;
      }
    }

    /// <summary>Field number for the "total_score" field.</summary>
    public const int TotalScoreFieldNumber = 1;
    private uint totalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalScore {
      get { return totalScore_; }
      set {
        totalScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueFinishInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueFinishInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PassRoomCount != other.PassRoomCount) return false;
      if (BFCBHPCPAOI != other.BFCBHPCPAOI) return false;
      if (!object.Equals(CurScoreRewardInfo, other.CurScoreRewardInfo)) return false;
      if (AreaId != other.AreaId) return false;
      if (!object.Equals(RecordInfo, other.RecordInfo)) return false;
      if (TakenScore != other.TakenScore) return false;
      if (!object.Equals(LBLELCPPLCI, other.LBLELCPPLCI)) return false;
      if (ANBFGOKNEIA != other.ANBFGOKNEIA) return false;
      if (!object.Equals(ScoreRewardInfo, other.ScoreRewardInfo)) return false;
      if (IsWin != other.IsWin) return false;
      if (!object.Equals(IPNGMMIOJJB, other.IPNGMMIOJJB)) return false;
      if (ReachRoomCount != other.ReachRoomCount) return false;
      if (BCKPHBOPCCN != other.BCKPHBOPCCN) return false;
      if (!object.Equals(ICOCLPBLFNN, other.ICOCLPBLFNN)) return false;
      if (TotalScore != other.TotalScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PassRoomCount != 0) hash ^= PassRoomCount.GetHashCode();
      if (BFCBHPCPAOI != false) hash ^= BFCBHPCPAOI.GetHashCode();
      if (curScoreRewardInfo_ != null) hash ^= CurScoreRewardInfo.GetHashCode();
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      if (recordInfo_ != null) hash ^= RecordInfo.GetHashCode();
      if (TakenScore != 0) hash ^= TakenScore.GetHashCode();
      if (lBLELCPPLCI_ != null) hash ^= LBLELCPPLCI.GetHashCode();
      if (ANBFGOKNEIA != 0) hash ^= ANBFGOKNEIA.GetHashCode();
      if (scoreRewardInfo_ != null) hash ^= ScoreRewardInfo.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      if (iPNGMMIOJJB_ != null) hash ^= IPNGMMIOJJB.GetHashCode();
      if (ReachRoomCount != 0) hash ^= ReachRoomCount.GetHashCode();
      if (BCKPHBOPCCN != 0) hash ^= BCKPHBOPCCN.GetHashCode();
      if (iCOCLPBLFNN_ != null) hash ^= ICOCLPBLFNN.GetHashCode();
      if (TotalScore != 0) hash ^= TotalScore.GetHashCode();
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
      if (TotalScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TotalScore);
      }
      if (BFCBHPCPAOI != false) {
        output.WriteRawTag(16);
        output.WriteBool(BFCBHPCPAOI);
      }
      if (iCOCLPBLFNN_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ICOCLPBLFNN);
      }
      if (ANBFGOKNEIA != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ANBFGOKNEIA);
      }
      if (scoreRewardInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ScoreRewardInfo);
      }
      if (TakenScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TakenScore);
      }
      if (BCKPHBOPCCN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BCKPHBOPCCN);
      }
      if (IsWin != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsWin);
      }
      if (curScoreRewardInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CurScoreRewardInfo);
      }
      if (PassRoomCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PassRoomCount);
      }
      if (lBLELCPPLCI_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LBLELCPPLCI);
      }
      if (iPNGMMIOJJB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IPNGMMIOJJB);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RecordInfo);
      }
      if (AreaId != 0) {
        output.WriteRawTag(160, 16);
        output.WriteUInt32(AreaId);
      }
      if (ReachRoomCount != 0) {
        output.WriteRawTag(248, 16);
        output.WriteUInt32(ReachRoomCount);
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
      if (TotalScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TotalScore);
      }
      if (BFCBHPCPAOI != false) {
        output.WriteRawTag(16);
        output.WriteBool(BFCBHPCPAOI);
      }
      if (iCOCLPBLFNN_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ICOCLPBLFNN);
      }
      if (ANBFGOKNEIA != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ANBFGOKNEIA);
      }
      if (scoreRewardInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ScoreRewardInfo);
      }
      if (TakenScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TakenScore);
      }
      if (BCKPHBOPCCN != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BCKPHBOPCCN);
      }
      if (IsWin != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsWin);
      }
      if (curScoreRewardInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CurScoreRewardInfo);
      }
      if (PassRoomCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PassRoomCount);
      }
      if (lBLELCPPLCI_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LBLELCPPLCI);
      }
      if (iPNGMMIOJJB_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(IPNGMMIOJJB);
      }
      if (recordInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RecordInfo);
      }
      if (AreaId != 0) {
        output.WriteRawTag(160, 16);
        output.WriteUInt32(AreaId);
      }
      if (ReachRoomCount != 0) {
        output.WriteRawTag(248, 16);
        output.WriteUInt32(ReachRoomCount);
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
      if (PassRoomCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PassRoomCount);
      }
      if (BFCBHPCPAOI != false) {
        size += 1 + 1;
      }
      if (curScoreRewardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurScoreRewardInfo);
      }
      if (AreaId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      if (recordInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RecordInfo);
      }
      if (TakenScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TakenScore);
      }
      if (lBLELCPPLCI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LBLELCPPLCI);
      }
      if (ANBFGOKNEIA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ANBFGOKNEIA);
      }
      if (scoreRewardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ScoreRewardInfo);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      if (iPNGMMIOJJB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IPNGMMIOJJB);
      }
      if (ReachRoomCount != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ReachRoomCount);
      }
      if (BCKPHBOPCCN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BCKPHBOPCCN);
      }
      if (iCOCLPBLFNN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ICOCLPBLFNN);
      }
      if (TotalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueFinishInfo other) {
      if (other == null) {
        return;
      }
      if (other.PassRoomCount != 0) {
        PassRoomCount = other.PassRoomCount;
      }
      if (other.BFCBHPCPAOI != false) {
        BFCBHPCPAOI = other.BFCBHPCPAOI;
      }
      if (other.curScoreRewardInfo_ != null) {
        if (curScoreRewardInfo_ == null) {
          CurScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        CurScoreRewardInfo.MergeFrom(other.CurScoreRewardInfo);
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      if (other.recordInfo_ != null) {
        if (recordInfo_ == null) {
          RecordInfo = new global::EggLink.DanhengServer.Proto.RogueRecordInfo();
        }
        RecordInfo.MergeFrom(other.RecordInfo);
      }
      if (other.TakenScore != 0) {
        TakenScore = other.TakenScore;
      }
      if (other.lBLELCPPLCI_ != null) {
        if (lBLELCPPLCI_ == null) {
          LBLELCPPLCI = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        LBLELCPPLCI.MergeFrom(other.LBLELCPPLCI);
      }
      if (other.ANBFGOKNEIA != 0) {
        ANBFGOKNEIA = other.ANBFGOKNEIA;
      }
      if (other.scoreRewardInfo_ != null) {
        if (scoreRewardInfo_ == null) {
          ScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
        }
        ScoreRewardInfo.MergeFrom(other.ScoreRewardInfo);
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      if (other.iPNGMMIOJJB_ != null) {
        if (iPNGMMIOJJB_ == null) {
          IPNGMMIOJJB = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        IPNGMMIOJJB.MergeFrom(other.IPNGMMIOJJB);
      }
      if (other.ReachRoomCount != 0) {
        ReachRoomCount = other.ReachRoomCount;
      }
      if (other.BCKPHBOPCCN != 0) {
        BCKPHBOPCCN = other.BCKPHBOPCCN;
      }
      if (other.iCOCLPBLFNN_ != null) {
        if (iCOCLPBLFNN_ == null) {
          ICOCLPBLFNN = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        ICOCLPBLFNN.MergeFrom(other.ICOCLPBLFNN);
      }
      if (other.TotalScore != 0) {
        TotalScore = other.TotalScore;
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
            TotalScore = input.ReadUInt32();
            break;
          }
          case 16: {
            BFCBHPCPAOI = input.ReadBool();
            break;
          }
          case 26: {
            if (iCOCLPBLFNN_ == null) {
              ICOCLPBLFNN = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ICOCLPBLFNN);
            break;
          }
          case 32: {
            ANBFGOKNEIA = input.ReadUInt32();
            break;
          }
          case 42: {
            if (scoreRewardInfo_ == null) {
              ScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(ScoreRewardInfo);
            break;
          }
          case 48: {
            TakenScore = input.ReadUInt32();
            break;
          }
          case 64: {
            BCKPHBOPCCN = input.ReadUInt32();
            break;
          }
          case 72: {
            IsWin = input.ReadBool();
            break;
          }
          case 82: {
            if (curScoreRewardInfo_ == null) {
              CurScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(CurScoreRewardInfo);
            break;
          }
          case 96: {
            PassRoomCount = input.ReadUInt32();
            break;
          }
          case 106: {
            if (lBLELCPPLCI_ == null) {
              LBLELCPPLCI = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(LBLELCPPLCI);
            break;
          }
          case 114: {
            if (iPNGMMIOJJB_ == null) {
              IPNGMMIOJJB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(IPNGMMIOJJB);
            break;
          }
          case 122: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.RogueRecordInfo();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 2080: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 2168: {
            ReachRoomCount = input.ReadUInt32();
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
            TotalScore = input.ReadUInt32();
            break;
          }
          case 16: {
            BFCBHPCPAOI = input.ReadBool();
            break;
          }
          case 26: {
            if (iCOCLPBLFNN_ == null) {
              ICOCLPBLFNN = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(ICOCLPBLFNN);
            break;
          }
          case 32: {
            ANBFGOKNEIA = input.ReadUInt32();
            break;
          }
          case 42: {
            if (scoreRewardInfo_ == null) {
              ScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(ScoreRewardInfo);
            break;
          }
          case 48: {
            TakenScore = input.ReadUInt32();
            break;
          }
          case 64: {
            BCKPHBOPCCN = input.ReadUInt32();
            break;
          }
          case 72: {
            IsWin = input.ReadBool();
            break;
          }
          case 82: {
            if (curScoreRewardInfo_ == null) {
              CurScoreRewardInfo = new global::EggLink.DanhengServer.Proto.RogueScoreRewardInfo();
            }
            input.ReadMessage(CurScoreRewardInfo);
            break;
          }
          case 96: {
            PassRoomCount = input.ReadUInt32();
            break;
          }
          case 106: {
            if (lBLELCPPLCI_ == null) {
              LBLELCPPLCI = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(LBLELCPPLCI);
            break;
          }
          case 114: {
            if (iPNGMMIOJJB_ == null) {
              IPNGMMIOJJB = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(IPNGMMIOJJB);
            break;
          }
          case 122: {
            if (recordInfo_ == null) {
              RecordInfo = new global::EggLink.DanhengServer.Proto.RogueRecordInfo();
            }
            input.ReadMessage(RecordInfo);
            break;
          }
          case 2080: {
            AreaId = input.ReadUInt32();
            break;
          }
          case 2168: {
            ReachRoomCount = input.ReadUInt32();
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