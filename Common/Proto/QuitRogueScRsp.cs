// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuitRogueScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from QuitRogueScRsp.proto</summary>
  public static partial class QuitRogueScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QuitRogueScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuitRogueScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRRdWl0Um9ndWVTY1JzcC5wcm90bxoVUm9ndWVGaW5pc2hJbmZvLnByb3Rv",
            "Gg9Sb2d1ZUluZm8ucHJvdG8iaAoOUXVpdFJvZ3VlU2NSc3ASHgoKcm9ndWVf",
            "aW5mbxgMIAEoCzIKLlJvZ3VlSW5mbxIPCgdyZXRjb2RlGAogASgNEiUKC2Zp",
            "bmlzaF9pbmZvGAcgASgLMhAuUm9ndWVGaW5pc2hJbmZvQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueFinishInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.QuitRogueScRsp), global::EggLink.DanhengServer.Proto.QuitRogueScRsp.Parser, new[]{ "RogueInfo", "Retcode", "FinishInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class QuitRogueScRsp : pb::IMessage<QuitRogueScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuitRogueScRsp> _parser = new pb::MessageParser<QuitRogueScRsp>(() => new QuitRogueScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuitRogueScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.QuitRogueScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitRogueScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitRogueScRsp(QuitRogueScRsp other) : this() {
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      retcode_ = other.retcode_;
      finishInfo_ = other.finishInfo_ != null ? other.finishInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuitRogueScRsp Clone() {
      return new QuitRogueScRsp(this);
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueInfo rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueInfo RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "finish_info" field.</summary>
    public const int FinishInfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.RogueFinishInfo finishInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueFinishInfo FinishInfo {
      get { return finishInfo_; }
      set {
        finishInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuitRogueScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuitRogueScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(FinishInfo, other.FinishInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (finishInfo_ != null) hash ^= FinishInfo.GetHashCode();
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
      if (finishInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FinishInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueInfo);
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
      if (finishInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FinishInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RogueInfo);
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
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (finishInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinishInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuitRogueScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.RogueInfo();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.finishInfo_ != null) {
        if (finishInfo_ == null) {
          FinishInfo = new global::EggLink.DanhengServer.Proto.RogueFinishInfo();
        }
        FinishInfo.MergeFrom(other.FinishInfo);
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
          case 58: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.RogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.RogueInfo();
            }
            input.ReadMessage(RogueInfo);
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
          case 58: {
            if (finishInfo_ == null) {
              FinishInfo = new global::EggLink.DanhengServer.Proto.RogueFinishInfo();
            }
            input.ReadMessage(FinishInfo);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.RogueInfo();
            }
            input.ReadMessage(RogueInfo);
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