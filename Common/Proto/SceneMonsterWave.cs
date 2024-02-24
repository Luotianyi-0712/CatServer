// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneMonsterWave.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneMonsterWave.proto</summary>
  public static partial class SceneMonsterWaveReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneMonsterWave.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneMonsterWaveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTY2VuZU1vbnN0ZXJXYXZlLnByb3RvGhJTY2VuZU1vbnN0ZXIucHJvdG8a",
            "G1NjZW5lTW9uc3RlcldhdmVQYXJhbS5wcm90bxoOSXRlbUxpc3QucHJvdG8i",
            "pAEKEFNjZW5lTW9uc3RlcldhdmUSDwoHd2F2ZV9pZBgEIAEoDRIcCglkcm9w",
            "X2xpc3QYDCADKAsyCS5JdGVtTGlzdBIQCghzdGFnZV9pZBgPIAEoDRIjCgxt",
            "b25zdGVyX2xpc3QYBiADKAsyDS5TY2VuZU1vbnN0ZXISKgoKd2F2ZV9wYXJh",
            "bRgLIAEoCzIWLlNjZW5lTW9uc3RlcldhdmVQYXJhbUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneMonsterReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneMonsterWaveParamReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneMonsterWave), global::EggLink.DanhengServer.Proto.SceneMonsterWave.Parser, new[]{ "WaveId", "DropList", "StageId", "MonsterList", "WaveParam" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneMonsterWave : pb::IMessage<SceneMonsterWave>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneMonsterWave> _parser = new pb::MessageParser<SceneMonsterWave>(() => new SceneMonsterWave());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneMonsterWave> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneMonsterWaveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonsterWave() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonsterWave(SceneMonsterWave other) : this() {
      waveId_ = other.waveId_;
      dropList_ = other.dropList_.Clone();
      stageId_ = other.stageId_;
      monsterList_ = other.monsterList_.Clone();
      waveParam_ = other.waveParam_ != null ? other.waveParam_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneMonsterWave Clone() {
      return new SceneMonsterWave(this);
    }

    /// <summary>Field number for the "wave_id" field.</summary>
    public const int WaveIdFieldNumber = 4;
    private uint waveId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaveId {
      get { return waveId_; }
      set {
        waveId_ = value;
      }
    }

    /// <summary>Field number for the "drop_list" field.</summary>
    public const int DropListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ItemList> _repeated_dropList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.ItemList.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> dropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ItemList> DropList {
      get { return dropList_; }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 15;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "monster_list" field.</summary>
    public const int MonsterListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneMonster> _repeated_monsterList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.SceneMonster.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonster> monsterList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonster>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonster> MonsterList {
      get { return monsterList_; }
    }

    /// <summary>Field number for the "wave_param" field.</summary>
    public const int WaveParamFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam waveParam_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam WaveParam {
      get { return waveParam_; }
      set {
        waveParam_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneMonsterWave);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneMonsterWave other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WaveId != other.WaveId) return false;
      if(!dropList_.Equals(other.dropList_)) return false;
      if (StageId != other.StageId) return false;
      if(!monsterList_.Equals(other.monsterList_)) return false;
      if (!object.Equals(WaveParam, other.WaveParam)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WaveId != 0) hash ^= WaveId.GetHashCode();
      hash ^= dropList_.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= monsterList_.GetHashCode();
      if (waveParam_ != null) hash ^= WaveParam.GetHashCode();
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
      if (WaveId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WaveId);
      }
      monsterList_.WriteTo(output, _repeated_monsterList_codec);
      if (waveParam_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(WaveParam);
      }
      dropList_.WriteTo(output, _repeated_dropList_codec);
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
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
      if (WaveId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WaveId);
      }
      monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
      if (waveParam_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(WaveParam);
      }
      dropList_.WriteTo(ref output, _repeated_dropList_codec);
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
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
      if (WaveId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaveId);
      }
      size += dropList_.CalculateSize(_repeated_dropList_codec);
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += monsterList_.CalculateSize(_repeated_monsterList_codec);
      if (waveParam_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WaveParam);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneMonsterWave other) {
      if (other == null) {
        return;
      }
      if (other.WaveId != 0) {
        WaveId = other.WaveId;
      }
      dropList_.Add(other.dropList_);
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      monsterList_.Add(other.monsterList_);
      if (other.waveParam_ != null) {
        if (waveParam_ == null) {
          WaveParam = new global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam();
        }
        WaveParam.MergeFrom(other.WaveParam);
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
          case 32: {
            WaveId = input.ReadUInt32();
            break;
          }
          case 50: {
            monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
            break;
          }
          case 90: {
            if (waveParam_ == null) {
              WaveParam = new global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam();
            }
            input.ReadMessage(WaveParam);
            break;
          }
          case 98: {
            dropList_.AddEntriesFrom(input, _repeated_dropList_codec);
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
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
          case 32: {
            WaveId = input.ReadUInt32();
            break;
          }
          case 50: {
            monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
            break;
          }
          case 90: {
            if (waveParam_ == null) {
              WaveParam = new global::EggLink.DanhengServer.Proto.SceneMonsterWaveParam();
            }
            input.ReadMessage(WaveParam);
            break;
          }
          case 98: {
            dropList_.AddEntriesFrom(ref input, _repeated_dropList_codec);
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
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
