// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneCastSkillCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneCastSkillCsReq.proto</summary>
  public static partial class SceneCastSkillCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneCastSkillCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneCastSkillCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTY2VuZUNhc3RTa2lsbENzUmVxLnByb3RvGhFPQVBEQ0ZFQ0hIRi5wcm90",
            "bxoQTW90aW9uSW5mby5wcm90bxoTU2tpbGxFeHRyYVRhZy5wcm90byLJAgoT",
            "U2NlbmVDYXN0U2tpbGxDc1JlcRITCgtNRUhFQk9NRk1HTRgPIAMoDRIWCg5j",
            "YXN0X2VudGl0eV9pZBgIIAEoDRITCgtQRUJHTUdITk5MTBgOIAEoDRITCgtz",
            "a2lsbF9pbmRleBgBIAEoDRIoChBza2lsbF9leHRyYV90YWdzGAcgAygOMg4u",
            "U2tpbGxFeHRyYVRhZxIkCg5keW5hbWljX3ZhbHVlcxgEIAMoCzIMLk9BUERD",
            "RkVDSEhGEh0KFWF0dGFja2VkX2J5X2VudGl0eV9pZBgKIAEoDRIlCh1hc3Np",
            "c3RfbW9uc3Rlcl9lbnRpdHlfaWRfbGlzdBgGIAMoDRIiCg10YXJnZXRfbW90",
            "aW9uGAIgASgLMgsuTW90aW9uSW5mbxIhChloaXRfdGFyZ2V0X2VudGl0eV9p",
            "ZF9saXN0GAkgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.OAPDCFECHHFReflection.Descriptor, global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SkillExtraTagReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneCastSkillCsReq), global::EggLink.DanhengServer.Proto.SceneCastSkillCsReq.Parser, new[]{ "MEHEBOMFMGM", "CastEntityId", "PEBGMGHNNLL", "SkillIndex", "SkillExtraTags", "DynamicValues", "AttackedByEntityId", "AssistMonsterEntityIdList", "TargetMotion", "HitTargetEntityIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneCastSkillCsReq : pb::IMessage<SceneCastSkillCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneCastSkillCsReq> _parser = new pb::MessageParser<SceneCastSkillCsReq>(() => new SceneCastSkillCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneCastSkillCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneCastSkillCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCsReq(SceneCastSkillCsReq other) : this() {
      mEHEBOMFMGM_ = other.mEHEBOMFMGM_.Clone();
      castEntityId_ = other.castEntityId_;
      pEBGMGHNNLL_ = other.pEBGMGHNNLL_;
      skillIndex_ = other.skillIndex_;
      skillExtraTags_ = other.skillExtraTags_.Clone();
      dynamicValues_ = other.dynamicValues_.Clone();
      attackedByEntityId_ = other.attackedByEntityId_;
      assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
      targetMotion_ = other.targetMotion_ != null ? other.targetMotion_.Clone() : null;
      hitTargetEntityIdList_ = other.hitTargetEntityIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCsReq Clone() {
      return new SceneCastSkillCsReq(this);
    }

    /// <summary>Field number for the "MEHEBOMFMGM" field.</summary>
    public const int MEHEBOMFMGMFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_mEHEBOMFMGM_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> mEHEBOMFMGM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MEHEBOMFMGM {
      get { return mEHEBOMFMGM_; }
    }

    /// <summary>Field number for the "cast_entity_id" field.</summary>
    public const int CastEntityIdFieldNumber = 8;
    private uint castEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CastEntityId {
      get { return castEntityId_; }
      set {
        castEntityId_ = value;
      }
    }

    /// <summary>Field number for the "PEBGMGHNNLL" field.</summary>
    public const int PEBGMGHNNLLFieldNumber = 14;
    private uint pEBGMGHNNLL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PEBGMGHNNLL {
      get { return pEBGMGHNNLL_; }
      set {
        pEBGMGHNNLL_ = value;
      }
    }

    /// <summary>Field number for the "skill_index" field.</summary>
    public const int SkillIndexFieldNumber = 1;
    private uint skillIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillIndex {
      get { return skillIndex_; }
      set {
        skillIndex_ = value;
      }
    }

    /// <summary>Field number for the "skill_extra_tags" field.</summary>
    public const int SkillExtraTagsFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SkillExtraTag> _repeated_skillExtraTags_codec
        = pb::FieldCodec.ForEnum(58, x => (int) x, x => (global::EggLink.DanhengServer.Proto.SkillExtraTag) x);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SkillExtraTag> skillExtraTags_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SkillExtraTag>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SkillExtraTag> SkillExtraTags {
      get { return skillExtraTags_; }
    }

    /// <summary>Field number for the "dynamic_values" field.</summary>
    public const int DynamicValuesFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.OAPDCFECHHF> _repeated_dynamicValues_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.OAPDCFECHHF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.OAPDCFECHHF> dynamicValues_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.OAPDCFECHHF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.OAPDCFECHHF> DynamicValues {
      get { return dynamicValues_; }
    }

    /// <summary>Field number for the "attacked_by_entity_id" field.</summary>
    public const int AttackedByEntityIdFieldNumber = 10;
    private uint attackedByEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackedByEntityId {
      get { return attackedByEntityId_; }
      set {
        attackedByEntityId_ = value;
      }
    }

    /// <summary>Field number for the "assist_monster_entity_id_list" field.</summary>
    public const int AssistMonsterEntityIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> assistMonsterEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AssistMonsterEntityIdList {
      get { return assistMonsterEntityIdList_; }
    }

    /// <summary>Field number for the "target_motion" field.</summary>
    public const int TargetMotionFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.MotionInfo targetMotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo TargetMotion {
      get { return targetMotion_; }
      set {
        targetMotion_ = value;
      }
    }

    /// <summary>Field number for the "hit_target_entity_id_list" field.</summary>
    public const int HitTargetEntityIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_hitTargetEntityIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> hitTargetEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HitTargetEntityIdList {
      get { return hitTargetEntityIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneCastSkillCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneCastSkillCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mEHEBOMFMGM_.Equals(other.mEHEBOMFMGM_)) return false;
      if (CastEntityId != other.CastEntityId) return false;
      if (PEBGMGHNNLL != other.PEBGMGHNNLL) return false;
      if (SkillIndex != other.SkillIndex) return false;
      if(!skillExtraTags_.Equals(other.skillExtraTags_)) return false;
      if(!dynamicValues_.Equals(other.dynamicValues_)) return false;
      if (AttackedByEntityId != other.AttackedByEntityId) return false;
      if(!assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_)) return false;
      if (!object.Equals(TargetMotion, other.TargetMotion)) return false;
      if(!hitTargetEntityIdList_.Equals(other.hitTargetEntityIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mEHEBOMFMGM_.GetHashCode();
      if (CastEntityId != 0) hash ^= CastEntityId.GetHashCode();
      if (PEBGMGHNNLL != 0) hash ^= PEBGMGHNNLL.GetHashCode();
      if (SkillIndex != 0) hash ^= SkillIndex.GetHashCode();
      hash ^= skillExtraTags_.GetHashCode();
      hash ^= dynamicValues_.GetHashCode();
      if (AttackedByEntityId != 0) hash ^= AttackedByEntityId.GetHashCode();
      hash ^= assistMonsterEntityIdList_.GetHashCode();
      if (targetMotion_ != null) hash ^= TargetMotion.GetHashCode();
      hash ^= hitTargetEntityIdList_.GetHashCode();
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
      if (SkillIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SkillIndex);
      }
      if (targetMotion_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TargetMotion);
      }
      dynamicValues_.WriteTo(output, _repeated_dynamicValues_codec);
      assistMonsterEntityIdList_.WriteTo(output, _repeated_assistMonsterEntityIdList_codec);
      skillExtraTags_.WriteTo(output, _repeated_skillExtraTags_codec);
      if (CastEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CastEntityId);
      }
      hitTargetEntityIdList_.WriteTo(output, _repeated_hitTargetEntityIdList_codec);
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AttackedByEntityId);
      }
      if (PEBGMGHNNLL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PEBGMGHNNLL);
      }
      mEHEBOMFMGM_.WriteTo(output, _repeated_mEHEBOMFMGM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SkillIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(SkillIndex);
      }
      if (targetMotion_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TargetMotion);
      }
      dynamicValues_.WriteTo(ref output, _repeated_dynamicValues_codec);
      assistMonsterEntityIdList_.WriteTo(ref output, _repeated_assistMonsterEntityIdList_codec);
      skillExtraTags_.WriteTo(ref output, _repeated_skillExtraTags_codec);
      if (CastEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CastEntityId);
      }
      hitTargetEntityIdList_.WriteTo(ref output, _repeated_hitTargetEntityIdList_codec);
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AttackedByEntityId);
      }
      if (PEBGMGHNNLL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PEBGMGHNNLL);
      }
      mEHEBOMFMGM_.WriteTo(ref output, _repeated_mEHEBOMFMGM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += mEHEBOMFMGM_.CalculateSize(_repeated_mEHEBOMFMGM_codec);
      if (CastEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CastEntityId);
      }
      if (PEBGMGHNNLL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PEBGMGHNNLL);
      }
      if (SkillIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillIndex);
      }
      size += skillExtraTags_.CalculateSize(_repeated_skillExtraTags_codec);
      size += dynamicValues_.CalculateSize(_repeated_dynamicValues_codec);
      if (AttackedByEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
      }
      size += assistMonsterEntityIdList_.CalculateSize(_repeated_assistMonsterEntityIdList_codec);
      if (targetMotion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetMotion);
      }
      size += hitTargetEntityIdList_.CalculateSize(_repeated_hitTargetEntityIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneCastSkillCsReq other) {
      if (other == null) {
        return;
      }
      mEHEBOMFMGM_.Add(other.mEHEBOMFMGM_);
      if (other.CastEntityId != 0) {
        CastEntityId = other.CastEntityId;
      }
      if (other.PEBGMGHNNLL != 0) {
        PEBGMGHNNLL = other.PEBGMGHNNLL;
      }
      if (other.SkillIndex != 0) {
        SkillIndex = other.SkillIndex;
      }
      skillExtraTags_.Add(other.skillExtraTags_);
      dynamicValues_.Add(other.dynamicValues_);
      if (other.AttackedByEntityId != 0) {
        AttackedByEntityId = other.AttackedByEntityId;
      }
      assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
      if (other.targetMotion_ != null) {
        if (targetMotion_ == null) {
          TargetMotion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        TargetMotion.MergeFrom(other.TargetMotion);
      }
      hitTargetEntityIdList_.Add(other.hitTargetEntityIdList_);
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
            SkillIndex = input.ReadUInt32();
            break;
          }
          case 18: {
            if (targetMotion_ == null) {
              TargetMotion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(TargetMotion);
            break;
          }
          case 34: {
            dynamicValues_.AddEntriesFrom(input, _repeated_dynamicValues_codec);
            break;
          }
          case 50:
          case 48: {
            assistMonsterEntityIdList_.AddEntriesFrom(input, _repeated_assistMonsterEntityIdList_codec);
            break;
          }
          case 58:
          case 56: {
            skillExtraTags_.AddEntriesFrom(input, _repeated_skillExtraTags_codec);
            break;
          }
          case 64: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            hitTargetEntityIdList_.AddEntriesFrom(input, _repeated_hitTargetEntityIdList_codec);
            break;
          }
          case 80: {
            AttackedByEntityId = input.ReadUInt32();
            break;
          }
          case 112: {
            PEBGMGHNNLL = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            mEHEBOMFMGM_.AddEntriesFrom(input, _repeated_mEHEBOMFMGM_codec);
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
            SkillIndex = input.ReadUInt32();
            break;
          }
          case 18: {
            if (targetMotion_ == null) {
              TargetMotion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(TargetMotion);
            break;
          }
          case 34: {
            dynamicValues_.AddEntriesFrom(ref input, _repeated_dynamicValues_codec);
            break;
          }
          case 50:
          case 48: {
            assistMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityIdList_codec);
            break;
          }
          case 58:
          case 56: {
            skillExtraTags_.AddEntriesFrom(ref input, _repeated_skillExtraTags_codec);
            break;
          }
          case 64: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            hitTargetEntityIdList_.AddEntriesFrom(ref input, _repeated_hitTargetEntityIdList_codec);
            break;
          }
          case 80: {
            AttackedByEntityId = input.ReadUInt32();
            break;
          }
          case 112: {
            PEBGMGHNNLL = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            mEHEBOMFMGM_.AddEntriesFrom(ref input, _repeated_mEHEBOMFMGM_codec);
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
