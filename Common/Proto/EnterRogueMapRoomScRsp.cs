// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterRogueMapRoomScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EnterRogueMapRoomScRsp.proto</summary>
  public static partial class EnterRogueMapRoomScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterRogueMapRoomScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterRogueMapRoomScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFbnRlclJvZ3VlTWFwUm9vbVNjUnNwLnByb3RvGg9TY2VuZUluZm8ucHJv",
            "dG8aEExpbmV1cEluZm8ucHJvdG8aEUFMSk9BTU1LT01PLnByb3RvIpkBChZF",
            "bnRlclJvZ3VlTWFwUm9vbVNjUnNwEhsKBmxpbmV1cBgFIAEoCzILLkxpbmV1",
            "cEluZm8SEwoLY3VyX3NpdGVfaWQYASABKA0SIQoLTENBQU5NSktCTUoYBCAB",
            "KAsyDC5BTEpPQU1NS09NTxIZCgVzY2VuZRgKIAEoCzIKLlNjZW5lSW5mbxIP",
            "CgdyZXRjb2RlGAYgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ALJOAMMKOMOReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EnterRogueMapRoomScRsp), global::EggLink.DanhengServer.Proto.EnterRogueMapRoomScRsp.Parser, new[]{ "Lineup", "CurSiteId", "LCAANMJKBMJ", "Scene", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EnterRogueMapRoomScRsp : pb::IMessage<EnterRogueMapRoomScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterRogueMapRoomScRsp> _parser = new pb::MessageParser<EnterRogueMapRoomScRsp>(() => new EnterRogueMapRoomScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterRogueMapRoomScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EnterRogueMapRoomScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueMapRoomScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueMapRoomScRsp(EnterRogueMapRoomScRsp other) : this() {
      lineup_ = other.lineup_ != null ? other.lineup_.Clone() : null;
      curSiteId_ = other.curSiteId_;
      lCAANMJKBMJ_ = other.lCAANMJKBMJ_ != null ? other.lCAANMJKBMJ_.Clone() : null;
      scene_ = other.scene_ != null ? other.scene_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueMapRoomScRsp Clone() {
      return new EnterRogueMapRoomScRsp(this);
    }

    /// <summary>Field number for the "lineup" field.</summary>
    public const int LineupFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.LineupInfo lineup_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LineupInfo Lineup {
      get { return lineup_; }
      set {
        lineup_ = value;
      }
    }

    /// <summary>Field number for the "cur_site_id" field.</summary>
    public const int CurSiteIdFieldNumber = 1;
    private uint curSiteId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurSiteId {
      get { return curSiteId_; }
      set {
        curSiteId_ = value;
      }
    }

    /// <summary>Field number for the "LCAANMJKBMJ" field.</summary>
    public const int LCAANMJKBMJFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ALJOAMMKOMO lCAANMJKBMJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ALJOAMMKOMO LCAANMJKBMJ {
      get { return lCAANMJKBMJ_; }
      set {
        lCAANMJKBMJ_ = value;
      }
    }

    /// <summary>Field number for the "scene" field.</summary>
    public const int SceneFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.SceneInfo scene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneInfo Scene {
      get { return scene_; }
      set {
        scene_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
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
      return Equals(other as EnterRogueMapRoomScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterRogueMapRoomScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Lineup, other.Lineup)) return false;
      if (CurSiteId != other.CurSiteId) return false;
      if (!object.Equals(LCAANMJKBMJ, other.LCAANMJKBMJ)) return false;
      if (!object.Equals(Scene, other.Scene)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lineup_ != null) hash ^= Lineup.GetHashCode();
      if (CurSiteId != 0) hash ^= CurSiteId.GetHashCode();
      if (lCAANMJKBMJ_ != null) hash ^= LCAANMJKBMJ.GetHashCode();
      if (scene_ != null) hash ^= Scene.GetHashCode();
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
      if (CurSiteId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurSiteId);
      }
      if (lCAANMJKBMJ_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LCAANMJKBMJ);
      }
      if (lineup_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Lineup);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (scene_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Scene);
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
      if (CurSiteId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurSiteId);
      }
      if (lCAANMJKBMJ_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LCAANMJKBMJ);
      }
      if (lineup_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Lineup);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
      }
      if (scene_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Scene);
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
      if (lineup_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lineup);
      }
      if (CurSiteId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurSiteId);
      }
      if (lCAANMJKBMJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LCAANMJKBMJ);
      }
      if (scene_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scene);
      }
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
    public void MergeFrom(EnterRogueMapRoomScRsp other) {
      if (other == null) {
        return;
      }
      if (other.lineup_ != null) {
        if (lineup_ == null) {
          Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
        }
        Lineup.MergeFrom(other.Lineup);
      }
      if (other.CurSiteId != 0) {
        CurSiteId = other.CurSiteId;
      }
      if (other.lCAANMJKBMJ_ != null) {
        if (lCAANMJKBMJ_ == null) {
          LCAANMJKBMJ = new global::EggLink.DanhengServer.Proto.ALJOAMMKOMO();
        }
        LCAANMJKBMJ.MergeFrom(other.LCAANMJKBMJ);
      }
      if (other.scene_ != null) {
        if (scene_ == null) {
          Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
        }
        Scene.MergeFrom(other.Scene);
      }
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
            CurSiteId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (lCAANMJKBMJ_ == null) {
              LCAANMJKBMJ = new global::EggLink.DanhengServer.Proto.ALJOAMMKOMO();
            }
            input.ReadMessage(LCAANMJKBMJ);
            break;
          }
          case 42: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
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
            CurSiteId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (lCAANMJKBMJ_ == null) {
              LCAANMJKBMJ = new global::EggLink.DanhengServer.Proto.ALJOAMMKOMO();
            }
            input.ReadMessage(LCAANMJKBMJ);
            break;
          }
          case 42: {
            if (lineup_ == null) {
              Lineup = new global::EggLink.DanhengServer.Proto.LineupInfo();
            }
            input.ReadMessage(Lineup);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (scene_ == null) {
              Scene = new global::EggLink.DanhengServer.Proto.SceneInfo();
            }
            input.ReadMessage(Scene);
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
