// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneInfo.proto</summary>
  public static partial class SceneInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TY2VuZUluZm8ucHJvdG8aFEN1c3RvbVNhdmVEYXRhLnByb3RvGh5NaXNz",
            "aW9uU3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aFEVudGl0eUJ1ZmZJbmZvLnBy",
            "b3RvGhZNZWNoYW5pc21CYXJJbmZvLnByb3RvGhVTY2VuZUVudGl0eUluZm8u",
            "cHJvdG8aFVNjZW5lR3JvdXBTdGF0ZS5wcm90bxoaU2NlbmVFbnRpdHlHcm91",
            "cEluZm8ucHJvdG8aEURGRk1CR0pCRkNBLnByb3RvGg5CdWZmSW5mby5wcm90",
            "byK3BgoJU2NlbmVJbmZvEjEKEWVudGl0eV9ncm91cF9saXN0GPEMIAMoCzIV",
            "LlNjZW5lRW50aXR5R3JvdXBJbmZvEhoKEmNsaWVudF9wb3NfdmVyc2lvbhgH",
            "IAEoDRIwCgtOTUFHQUZCS0lDThgMIAMoCzIbLlNjZW5lSW5mby5OTUFHQUZC",
            "S0lDTkVudHJ5EjEKC0pCT1BEQ0xKUEdEGPoKIAMoCzIbLlNjZW5lSW5mby5K",
            "Qk9QRENMSlBHREVudHJ5EhUKDWdyb3VwX2lkX2xpc3QYDSADKA0SEAoIcGxh",
            "bmVfaWQYCCABKA0SEAoId29ybGRfaWQYCyABKA0SHAoUbGlnaHRlbl9zZWN0",
            "aW9uX2xpc3QYAyADKA0SGAoQbGVhZGVyX2VudGl0eV9pZBgOIAEoDRIQCghm",
            "bG9vcl9pZBgKIAEoDRIUCgtLSUdMTEtJQk5MSRjmAiABKA0SEAoIZW50cnlf",
            "aWQYBSABKA0SPwocbWlzc2lvbl9zdGF0dXNfYnlfc2NlbmVfaW5mbxhwIAEo",
            "CzIZLk1pc3Npb25TdGF0dXNCeVNjZW5lSW5mbxIWCg5nYW1lX21vZGVfdHlw",
            "ZRgCIAEoDRIpChBjdXN0b21fc2F2ZV9kYXRhGA8gAygLMg8uQ3VzdG9tU2F2",
            "ZURhdGESLQoSbWVjaGFuaXNtX2Jhcl9pbmZvGAkgASgLMhEuTWVjaGFuaXNt",
            "QmFySW5mbxIlCgtlbnRpdHlfbGlzdBgGIAMoCzIQLlNjZW5lRW50aXR5SW5m",
            "bxIpChBlbnRpdHlfYnVmZl9saXN0GAEgAygLMg8uRW50aXR5QnVmZkluZm8S",
            "IQoOc3luY19idWZmX2luZm8YBCADKAsyCS5CdWZmSW5mbxIrChBncm91cF9z",
            "dGF0ZV9saXN0GNwJIAMoCzIQLlNjZW5lR3JvdXBTdGF0ZRpAChBOTUFHQUZC",
            "S0lDTkVudHJ5EgsKA2tleRgBIAEoDRIbCgV2YWx1ZRgCIAEoCzIMLkRGRk1C",
            "R0pCRkNBOgI4ARoyChBKQk9QRENMSlBHREVudHJ5EgsKA2tleRgBIAEoCRIN",
            "CgV2YWx1ZRgCIAEoBToCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CustomSaveDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.EntityBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MechanismBarInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneGroupStateReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.DFFMBGJBFCAReflection.Descriptor, global::EggLink.DanhengServer.Proto.BuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneInfo), global::EggLink.DanhengServer.Proto.SceneInfo.Parser, new[]{ "EntityGroupList", "ClientPosVersion", "NMAGAFBKICN", "JBOPDCLJPGD", "GroupIdList", "PlaneId", "WorldId", "LightenSectionList", "LeaderEntityId", "FloorId", "KIGLLKIBNLI", "EntryId", "MissionStatusBySceneInfo", "GameModeType", "CustomSaveData", "MechanismBarInfo", "EntityList", "EntityBuffList", "SyncBuffInfo", "GroupStateList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneInfo : pb::IMessage<SceneInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneInfo> _parser = new pb::MessageParser<SceneInfo>(() => new SceneInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo(SceneInfo other) : this() {
      entityGroupList_ = other.entityGroupList_.Clone();
      clientPosVersion_ = other.clientPosVersion_;
      nMAGAFBKICN_ = other.nMAGAFBKICN_.Clone();
      jBOPDCLJPGD_ = other.jBOPDCLJPGD_.Clone();
      groupIdList_ = other.groupIdList_.Clone();
      planeId_ = other.planeId_;
      worldId_ = other.worldId_;
      lightenSectionList_ = other.lightenSectionList_.Clone();
      leaderEntityId_ = other.leaderEntityId_;
      floorId_ = other.floorId_;
      kIGLLKIBNLI_ = other.kIGLLKIBNLI_;
      entryId_ = other.entryId_;
      missionStatusBySceneInfo_ = other.missionStatusBySceneInfo_ != null ? other.missionStatusBySceneInfo_.Clone() : null;
      gameModeType_ = other.gameModeType_;
      customSaveData_ = other.customSaveData_.Clone();
      mechanismBarInfo_ = other.mechanismBarInfo_ != null ? other.mechanismBarInfo_.Clone() : null;
      entityList_ = other.entityList_.Clone();
      entityBuffList_ = other.entityBuffList_.Clone();
      syncBuffInfo_ = other.syncBuffInfo_.Clone();
      groupStateList_ = other.groupStateList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo Clone() {
      return new SceneInfo(this);
    }

    /// <summary>Field number for the "entity_group_list" field.</summary>
    public const int EntityGroupListFieldNumber = 1649;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> _repeated_entityGroupList_codec
        = pb::FieldCodec.ForMessage(13194, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> entityGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> EntityGroupList {
      get { return entityGroupList_; }
    }

    /// <summary>Field number for the "client_pos_version" field.</summary>
    public const int ClientPosVersionFieldNumber = 7;
    private uint clientPosVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientPosVersion {
      get { return clientPosVersion_; }
      set {
        clientPosVersion_ = value;
      }
    }

    /// <summary>Field number for the "NMAGAFBKICN" field.</summary>
    public const int NMAGAFBKICNFieldNumber = 12;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DFFMBGJBFCA>.Codec _map_nMAGAFBKICN_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DFFMBGJBFCA>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.DFFMBGJBFCA.Parser), 98);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DFFMBGJBFCA> nMAGAFBKICN_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DFFMBGJBFCA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DFFMBGJBFCA> NMAGAFBKICN {
      get { return nMAGAFBKICN_; }
    }

    /// <summary>Field number for the "JBOPDCLJPGD" field.</summary>
    public const int JBOPDCLJPGDFieldNumber = 1402;
    private static readonly pbc::MapField<string, int>.Codec _map_jBOPDCLJPGD_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 11218);
    private readonly pbc::MapField<string, int> jBOPDCLJPGD_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> JBOPDCLJPGD {
      get { return jBOPDCLJPGD_; }
    }

    /// <summary>Field number for the "group_id_list" field.</summary>
    public const int GroupIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_groupIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> groupIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GroupIdList {
      get { return groupIdList_; }
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

    /// <summary>Field number for the "world_id" field.</summary>
    public const int WorldIdFieldNumber = 11;
    private uint worldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldId {
      get { return worldId_; }
      set {
        worldId_ = value;
      }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    /// <summary>Field number for the "leader_entity_id" field.</summary>
    public const int LeaderEntityIdFieldNumber = 14;
    private uint leaderEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeaderEntityId {
      get { return leaderEntityId_; }
      set {
        leaderEntityId_ = value;
      }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 10;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "KIGLLKIBNLI" field.</summary>
    public const int KIGLLKIBNLIFieldNumber = 358;
    private uint kIGLLKIBNLI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KIGLLKIBNLI {
      get { return kIGLLKIBNLI_; }
      set {
        kIGLLKIBNLI_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 5;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "mission_status_by_scene_info" field.</summary>
    public const int MissionStatusBySceneInfoFieldNumber = 112;
    private global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo missionStatusBySceneInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo MissionStatusBySceneInfo {
      get { return missionStatusBySceneInfo_; }
      set {
        missionStatusBySceneInfo_ = value;
      }
    }

    /// <summary>Field number for the "game_mode_type" field.</summary>
    public const int GameModeTypeFieldNumber = 2;
    private uint gameModeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameModeType {
      get { return gameModeType_; }
      set {
        gameModeType_ = value;
      }
    }

    /// <summary>Field number for the "custom_save_data" field.</summary>
    public const int CustomSaveDataFieldNumber = 15;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CustomSaveData> _repeated_customSaveData_codec
        = pb::FieldCodec.ForMessage(122, global::EggLink.DanhengServer.Proto.CustomSaveData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> customSaveData_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> CustomSaveData {
      get { return customSaveData_; }
    }

    /// <summary>Field number for the "mechanism_bar_info" field.</summary>
    public const int MechanismBarInfoFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.MechanismBarInfo mechanismBarInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MechanismBarInfo MechanismBarInfo {
      get { return mechanismBarInfo_; }
      set {
        mechanismBarInfo_ = value;
      }
    }

    /// <summary>Field number for the "entity_list" field.</summary>
    public const int EntityListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityInfo> _repeated_entityList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.SceneEntityInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> entityList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> EntityList {
      get { return entityList_; }
    }

    /// <summary>Field number for the "entity_buff_list" field.</summary>
    public const int EntityBuffListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EntityBuffInfo> _repeated_entityBuffList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.EntityBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> entityBuffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> EntityBuffList {
      get { return entityBuffList_; }
    }

    /// <summary>Field number for the "sync_buff_info" field.</summary>
    public const int SyncBuffInfoFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BuffInfo> _repeated_syncBuffInfo_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.BuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> syncBuffInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> SyncBuffInfo {
      get { return syncBuffInfo_; }
    }

    /// <summary>Field number for the "group_state_list" field.</summary>
    public const int GroupStateListFieldNumber = 1244;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneGroupState> _repeated_groupStateList_codec
        = pb::FieldCodec.ForMessage(9954, global::EggLink.DanhengServer.Proto.SceneGroupState.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> groupStateList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> GroupStateList {
      get { return groupStateList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entityGroupList_.Equals(other.entityGroupList_)) return false;
      if (ClientPosVersion != other.ClientPosVersion) return false;
      if (!NMAGAFBKICN.Equals(other.NMAGAFBKICN)) return false;
      if (!JBOPDCLJPGD.Equals(other.JBOPDCLJPGD)) return false;
      if(!groupIdList_.Equals(other.groupIdList_)) return false;
      if (PlaneId != other.PlaneId) return false;
      if (WorldId != other.WorldId) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      if (LeaderEntityId != other.LeaderEntityId) return false;
      if (FloorId != other.FloorId) return false;
      if (KIGLLKIBNLI != other.KIGLLKIBNLI) return false;
      if (EntryId != other.EntryId) return false;
      if (!object.Equals(MissionStatusBySceneInfo, other.MissionStatusBySceneInfo)) return false;
      if (GameModeType != other.GameModeType) return false;
      if(!customSaveData_.Equals(other.customSaveData_)) return false;
      if (!object.Equals(MechanismBarInfo, other.MechanismBarInfo)) return false;
      if(!entityList_.Equals(other.entityList_)) return false;
      if(!entityBuffList_.Equals(other.entityBuffList_)) return false;
      if(!syncBuffInfo_.Equals(other.syncBuffInfo_)) return false;
      if(!groupStateList_.Equals(other.groupStateList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entityGroupList_.GetHashCode();
      if (ClientPosVersion != 0) hash ^= ClientPosVersion.GetHashCode();
      hash ^= NMAGAFBKICN.GetHashCode();
      hash ^= JBOPDCLJPGD.GetHashCode();
      hash ^= groupIdList_.GetHashCode();
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (WorldId != 0) hash ^= WorldId.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
      if (LeaderEntityId != 0) hash ^= LeaderEntityId.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      if (KIGLLKIBNLI != 0) hash ^= KIGLLKIBNLI.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      if (missionStatusBySceneInfo_ != null) hash ^= MissionStatusBySceneInfo.GetHashCode();
      if (GameModeType != 0) hash ^= GameModeType.GetHashCode();
      hash ^= customSaveData_.GetHashCode();
      if (mechanismBarInfo_ != null) hash ^= MechanismBarInfo.GetHashCode();
      hash ^= entityList_.GetHashCode();
      hash ^= entityBuffList_.GetHashCode();
      hash ^= syncBuffInfo_.GetHashCode();
      hash ^= groupStateList_.GetHashCode();
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
      entityBuffList_.WriteTo(output, _repeated_entityBuffList_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameModeType);
      }
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      syncBuffInfo_.WriteTo(output, _repeated_syncBuffInfo_codec);
      if (EntryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EntryId);
      }
      entityList_.WriteTo(output, _repeated_entityList_codec);
      if (ClientPosVersion != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ClientPosVersion);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlaneId);
      }
      if (mechanismBarInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MechanismBarInfo);
      }
      if (FloorId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FloorId);
      }
      if (WorldId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldId);
      }
      nMAGAFBKICN_.WriteTo(output, _map_nMAGAFBKICN_codec);
      groupIdList_.WriteTo(output, _repeated_groupIdList_codec);
      if (LeaderEntityId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LeaderEntityId);
      }
      customSaveData_.WriteTo(output, _repeated_customSaveData_codec);
      if (missionStatusBySceneInfo_ != null) {
        output.WriteRawTag(130, 7);
        output.WriteMessage(MissionStatusBySceneInfo);
      }
      if (KIGLLKIBNLI != 0) {
        output.WriteRawTag(176, 22);
        output.WriteUInt32(KIGLLKIBNLI);
      }
      groupStateList_.WriteTo(output, _repeated_groupStateList_codec);
      jBOPDCLJPGD_.WriteTo(output, _map_jBOPDCLJPGD_codec);
      entityGroupList_.WriteTo(output, _repeated_entityGroupList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      entityBuffList_.WriteTo(ref output, _repeated_entityBuffList_codec);
      if (GameModeType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameModeType);
      }
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      syncBuffInfo_.WriteTo(ref output, _repeated_syncBuffInfo_codec);
      if (EntryId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EntryId);
      }
      entityList_.WriteTo(ref output, _repeated_entityList_codec);
      if (ClientPosVersion != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ClientPosVersion);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PlaneId);
      }
      if (mechanismBarInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MechanismBarInfo);
      }
      if (FloorId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FloorId);
      }
      if (WorldId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(WorldId);
      }
      nMAGAFBKICN_.WriteTo(ref output, _map_nMAGAFBKICN_codec);
      groupIdList_.WriteTo(ref output, _repeated_groupIdList_codec);
      if (LeaderEntityId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LeaderEntityId);
      }
      customSaveData_.WriteTo(ref output, _repeated_customSaveData_codec);
      if (missionStatusBySceneInfo_ != null) {
        output.WriteRawTag(130, 7);
        output.WriteMessage(MissionStatusBySceneInfo);
      }
      if (KIGLLKIBNLI != 0) {
        output.WriteRawTag(176, 22);
        output.WriteUInt32(KIGLLKIBNLI);
      }
      groupStateList_.WriteTo(ref output, _repeated_groupStateList_codec);
      jBOPDCLJPGD_.WriteTo(ref output, _map_jBOPDCLJPGD_codec);
      entityGroupList_.WriteTo(ref output, _repeated_entityGroupList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += entityGroupList_.CalculateSize(_repeated_entityGroupList_codec);
      if (ClientPosVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
      }
      size += nMAGAFBKICN_.CalculateSize(_map_nMAGAFBKICN_codec);
      size += jBOPDCLJPGD_.CalculateSize(_map_jBOPDCLJPGD_codec);
      size += groupIdList_.CalculateSize(_repeated_groupIdList_codec);
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (WorldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldId);
      }
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      if (LeaderEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeaderEntityId);
      }
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      if (KIGLLKIBNLI != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(KIGLLKIBNLI);
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      if (missionStatusBySceneInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MissionStatusBySceneInfo);
      }
      if (GameModeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameModeType);
      }
      size += customSaveData_.CalculateSize(_repeated_customSaveData_codec);
      if (mechanismBarInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MechanismBarInfo);
      }
      size += entityList_.CalculateSize(_repeated_entityList_codec);
      size += entityBuffList_.CalculateSize(_repeated_entityBuffList_codec);
      size += syncBuffInfo_.CalculateSize(_repeated_syncBuffInfo_codec);
      size += groupStateList_.CalculateSize(_repeated_groupStateList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneInfo other) {
      if (other == null) {
        return;
      }
      entityGroupList_.Add(other.entityGroupList_);
      if (other.ClientPosVersion != 0) {
        ClientPosVersion = other.ClientPosVersion;
      }
      nMAGAFBKICN_.MergeFrom(other.nMAGAFBKICN_);
      jBOPDCLJPGD_.MergeFrom(other.jBOPDCLJPGD_);
      groupIdList_.Add(other.groupIdList_);
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.WorldId != 0) {
        WorldId = other.WorldId;
      }
      lightenSectionList_.Add(other.lightenSectionList_);
      if (other.LeaderEntityId != 0) {
        LeaderEntityId = other.LeaderEntityId;
      }
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      if (other.KIGLLKIBNLI != 0) {
        KIGLLKIBNLI = other.KIGLLKIBNLI;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      if (other.missionStatusBySceneInfo_ != null) {
        if (missionStatusBySceneInfo_ == null) {
          MissionStatusBySceneInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
        }
        MissionStatusBySceneInfo.MergeFrom(other.MissionStatusBySceneInfo);
      }
      if (other.GameModeType != 0) {
        GameModeType = other.GameModeType;
      }
      customSaveData_.Add(other.customSaveData_);
      if (other.mechanismBarInfo_ != null) {
        if (mechanismBarInfo_ == null) {
          MechanismBarInfo = new global::EggLink.DanhengServer.Proto.MechanismBarInfo();
        }
        MechanismBarInfo.MergeFrom(other.MechanismBarInfo);
      }
      entityList_.Add(other.entityList_);
      entityBuffList_.Add(other.entityBuffList_);
      syncBuffInfo_.Add(other.syncBuffInfo_);
      groupStateList_.Add(other.groupStateList_);
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
          case 10: {
            entityBuffList_.AddEntriesFrom(input, _repeated_entityBuffList_codec);
            break;
          }
          case 16: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 34: {
            syncBuffInfo_.AddEntriesFrom(input, _repeated_syncBuffInfo_codec);
            break;
          }
          case 40: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 50: {
            entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
            break;
          }
          case 56: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 64: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (mechanismBarInfo_ == null) {
              MechanismBarInfo = new global::EggLink.DanhengServer.Proto.MechanismBarInfo();
            }
            input.ReadMessage(MechanismBarInfo);
            break;
          }
          case 80: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 88: {
            WorldId = input.ReadUInt32();
            break;
          }
          case 98: {
            nMAGAFBKICN_.AddEntriesFrom(input, _map_nMAGAFBKICN_codec);
            break;
          }
          case 106:
          case 104: {
            groupIdList_.AddEntriesFrom(input, _repeated_groupIdList_codec);
            break;
          }
          case 112: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 122: {
            customSaveData_.AddEntriesFrom(input, _repeated_customSaveData_codec);
            break;
          }
          case 898: {
            if (missionStatusBySceneInfo_ == null) {
              MissionStatusBySceneInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(MissionStatusBySceneInfo);
            break;
          }
          case 2864: {
            KIGLLKIBNLI = input.ReadUInt32();
            break;
          }
          case 9954: {
            groupStateList_.AddEntriesFrom(input, _repeated_groupStateList_codec);
            break;
          }
          case 11218: {
            jBOPDCLJPGD_.AddEntriesFrom(input, _map_jBOPDCLJPGD_codec);
            break;
          }
          case 13194: {
            entityGroupList_.AddEntriesFrom(input, _repeated_entityGroupList_codec);
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
          case 10: {
            entityBuffList_.AddEntriesFrom(ref input, _repeated_entityBuffList_codec);
            break;
          }
          case 16: {
            GameModeType = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 34: {
            syncBuffInfo_.AddEntriesFrom(ref input, _repeated_syncBuffInfo_codec);
            break;
          }
          case 40: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 50: {
            entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
            break;
          }
          case 56: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 64: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (mechanismBarInfo_ == null) {
              MechanismBarInfo = new global::EggLink.DanhengServer.Proto.MechanismBarInfo();
            }
            input.ReadMessage(MechanismBarInfo);
            break;
          }
          case 80: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 88: {
            WorldId = input.ReadUInt32();
            break;
          }
          case 98: {
            nMAGAFBKICN_.AddEntriesFrom(ref input, _map_nMAGAFBKICN_codec);
            break;
          }
          case 106:
          case 104: {
            groupIdList_.AddEntriesFrom(ref input, _repeated_groupIdList_codec);
            break;
          }
          case 112: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 122: {
            customSaveData_.AddEntriesFrom(ref input, _repeated_customSaveData_codec);
            break;
          }
          case 898: {
            if (missionStatusBySceneInfo_ == null) {
              MissionStatusBySceneInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(MissionStatusBySceneInfo);
            break;
          }
          case 2864: {
            KIGLLKIBNLI = input.ReadUInt32();
            break;
          }
          case 9954: {
            groupStateList_.AddEntriesFrom(ref input, _repeated_groupStateList_codec);
            break;
          }
          case 11218: {
            jBOPDCLJPGD_.AddEntriesFrom(ref input, _map_jBOPDCLJPGD_codec);
            break;
          }
          case 13194: {
            entityGroupList_.AddEntriesFrom(ref input, _repeated_entityGroupList_codec);
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
