// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CurChallenge.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CurChallenge.proto</summary>
  public static partial class CurChallengeReflection {

    #region Descriptor
    /// <summary>File descriptor for CurChallenge.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CurChallengeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJDdXJDaGFsbGVuZ2UucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5wcm90bxoR",
            "R0NHQU5ET09MT0UucHJvdG8aFUtpbGxNb25zdGVySW5mby5wcm90bxoVQ2hh",
            "bGxlbmdlU3RhdHVzLnByb3RvIpoCCgxDdXJDaGFsbGVuZ2USIQoLcGxheWVy",
            "X2luZm8YAyABKAsyDC5HQ0dBTkRPT0xPRRIgCgZzdGF0dXMYCyABKA4yEC5D",
            "aGFsbGVuZ2VTdGF0dXMSFAoMY2hhbGxlbmdlX2lkGAkgASgNEisKEWV4dHJh",
            "X2xpbmV1cF90eXBlGAEgASgOMhAuRXh0cmFMaW5ldXBUeXBlEhMKC0hQQURK",
            "SVBLR0hKGA0gASgNEhMKC0xOUE9OR0JMQk1DGAQgASgNEhMKC05JTE5NUEVC",
            "R0NBGAUgASgNEhAKCHNjb3JlX2lkGAwgASgNEjEKF2FyY2hpdmVfbW9uc3Rl",
            "cl9pZF9saXN0GA4gAygLMhAuS2lsbE1vbnN0ZXJJbmZvQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ExtraLineupTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.GCGANDOOLOEReflection.Descriptor, global::EggLink.DanhengServer.Proto.KillMonsterInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChallengeStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CurChallenge), global::EggLink.DanhengServer.Proto.CurChallenge.Parser, new[]{ "PlayerInfo", "Status", "ChallengeId", "ExtraLineupType", "HPADJIPKGHJ", "LNPONGBLBMC", "NILNMPEBGCA", "ScoreId", "ArchiveMonsterIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CurChallenge : pb::IMessage<CurChallenge>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CurChallenge> _parser = new pb::MessageParser<CurChallenge>(() => new CurChallenge());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CurChallenge> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CurChallengeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CurChallenge() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CurChallenge(CurChallenge other) : this() {
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      status_ = other.status_;
      challengeId_ = other.challengeId_;
      extraLineupType_ = other.extraLineupType_;
      hPADJIPKGHJ_ = other.hPADJIPKGHJ_;
      lNPONGBLBMC_ = other.lNPONGBLBMC_;
      nILNMPEBGCA_ = other.nILNMPEBGCA_;
      scoreId_ = other.scoreId_;
      archiveMonsterIdList_ = other.archiveMonsterIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CurChallenge Clone() {
      return new CurChallenge(this);
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.GCGANDOOLOE playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GCGANDOOLOE PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChallengeStatus status_ = global::EggLink.DanhengServer.Proto.ChallengeStatus.ChallengeUnknown;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChallengeStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 9;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "extra_lineup_type" field.</summary>
    public const int ExtraLineupTypeFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ExtraLineupType extraLineupType_ = global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ExtraLineupType ExtraLineupType {
      get { return extraLineupType_; }
      set {
        extraLineupType_ = value;
      }
    }

    /// <summary>Field number for the "HPADJIPKGHJ" field.</summary>
    public const int HPADJIPKGHJFieldNumber = 13;
    private uint hPADJIPKGHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HPADJIPKGHJ {
      get { return hPADJIPKGHJ_; }
      set {
        hPADJIPKGHJ_ = value;
      }
    }

    /// <summary>Field number for the "LNPONGBLBMC" field.</summary>
    public const int LNPONGBLBMCFieldNumber = 4;
    private uint lNPONGBLBMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LNPONGBLBMC {
      get { return lNPONGBLBMC_; }
      set {
        lNPONGBLBMC_ = value;
      }
    }

    /// <summary>Field number for the "NILNMPEBGCA" field.</summary>
    public const int NILNMPEBGCAFieldNumber = 5;
    private uint nILNMPEBGCA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NILNMPEBGCA {
      get { return nILNMPEBGCA_; }
      set {
        nILNMPEBGCA_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 12;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "archive_monster_id_list" field.</summary>
    public const int ArchiveMonsterIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.KillMonsterInfo> _repeated_archiveMonsterIdList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.KillMonsterInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KillMonsterInfo> archiveMonsterIdList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KillMonsterInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.KillMonsterInfo> ArchiveMonsterIdList {
      get { return archiveMonsterIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CurChallenge);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CurChallenge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (Status != other.Status) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (ExtraLineupType != other.ExtraLineupType) return false;
      if (HPADJIPKGHJ != other.HPADJIPKGHJ) return false;
      if (LNPONGBLBMC != other.LNPONGBLBMC) return false;
      if (NILNMPEBGCA != other.NILNMPEBGCA) return false;
      if (ScoreId != other.ScoreId) return false;
      if(!archiveMonsterIdList_.Equals(other.archiveMonsterIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (Status != global::EggLink.DanhengServer.Proto.ChallengeStatus.ChallengeUnknown) hash ^= Status.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) hash ^= ExtraLineupType.GetHashCode();
      if (HPADJIPKGHJ != 0) hash ^= HPADJIPKGHJ.GetHashCode();
      if (LNPONGBLBMC != 0) hash ^= LNPONGBLBMC.GetHashCode();
      if (NILNMPEBGCA != 0) hash ^= NILNMPEBGCA.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      hash ^= archiveMonsterIdList_.GetHashCode();
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
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PlayerInfo);
      }
      if (LNPONGBLBMC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LNPONGBLBMC);
      }
      if (NILNMPEBGCA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NILNMPEBGCA);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.ChallengeStatus.ChallengeUnknown) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScoreId);
      }
      if (HPADJIPKGHJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(HPADJIPKGHJ);
      }
      archiveMonsterIdList_.WriteTo(output, _repeated_archiveMonsterIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ExtraLineupType);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PlayerInfo);
      }
      if (LNPONGBLBMC != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LNPONGBLBMC);
      }
      if (NILNMPEBGCA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NILNMPEBGCA);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChallengeId);
      }
      if (Status != global::EggLink.DanhengServer.Proto.ChallengeStatus.ChallengeUnknown) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScoreId);
      }
      if (HPADJIPKGHJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(HPADJIPKGHJ);
      }
      archiveMonsterIdList_.WriteTo(ref output, _repeated_archiveMonsterIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (Status != global::EggLink.DanhengServer.Proto.ChallengeStatus.ChallengeUnknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtraLineupType);
      }
      if (HPADJIPKGHJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HPADJIPKGHJ);
      }
      if (LNPONGBLBMC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LNPONGBLBMC);
      }
      if (NILNMPEBGCA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NILNMPEBGCA);
      }
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      size += archiveMonsterIdList_.CalculateSize(_repeated_archiveMonsterIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CurChallenge other) {
      if (other == null) {
        return;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::EggLink.DanhengServer.Proto.GCGANDOOLOE();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.Status != global::EggLink.DanhengServer.Proto.ChallengeStatus.ChallengeUnknown) {
        Status = other.Status;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.ExtraLineupType != global::EggLink.DanhengServer.Proto.ExtraLineupType.LineupNone) {
        ExtraLineupType = other.ExtraLineupType;
      }
      if (other.HPADJIPKGHJ != 0) {
        HPADJIPKGHJ = other.HPADJIPKGHJ;
      }
      if (other.LNPONGBLBMC != 0) {
        LNPONGBLBMC = other.LNPONGBLBMC;
      }
      if (other.NILNMPEBGCA != 0) {
        NILNMPEBGCA = other.NILNMPEBGCA;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      archiveMonsterIdList_.Add(other.archiveMonsterIdList_);
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
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 26: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.GCGANDOOLOE();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 32: {
            LNPONGBLBMC = input.ReadUInt32();
            break;
          }
          case 40: {
            NILNMPEBGCA = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 88: {
            Status = (global::EggLink.DanhengServer.Proto.ChallengeStatus) input.ReadEnum();
            break;
          }
          case 96: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 104: {
            HPADJIPKGHJ = input.ReadUInt32();
            break;
          }
          case 114: {
            archiveMonsterIdList_.AddEntriesFrom(input, _repeated_archiveMonsterIdList_codec);
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
            ExtraLineupType = (global::EggLink.DanhengServer.Proto.ExtraLineupType) input.ReadEnum();
            break;
          }
          case 26: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::EggLink.DanhengServer.Proto.GCGANDOOLOE();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 32: {
            LNPONGBLBMC = input.ReadUInt32();
            break;
          }
          case 40: {
            NILNMPEBGCA = input.ReadUInt32();
            break;
          }
          case 72: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 88: {
            Status = (global::EggLink.DanhengServer.Proto.ChallengeStatus) input.ReadEnum();
            break;
          }
          case 96: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 104: {
            HPADJIPKGHJ = input.ReadUInt32();
            break;
          }
          case 114: {
            archiveMonsterIdList_.AddEntriesFrom(ref input, _repeated_archiveMonsterIdList_codec);
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
