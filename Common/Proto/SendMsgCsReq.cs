// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SendMsgCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SendMsgCsReq.proto</summary>
  public static partial class SendMsgCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SendMsgCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendMsgCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJTZW5kTXNnQ3NSZXEucHJvdG8aDkNoYXRUeXBlLnByb3RvGg1Nc2dUeXBl",
            "LnByb3RvInoKDFNlbmRNc2dDc1JlcRITCgt0b191aWRfbGlzdBgEIAMoDRIN",
            "CgVlbW90ZRgNIAEoDRIaCghtc2dfdHlwZRgFIAEoDjIILk1zZ1R5cGUSDAoE",
            "dGV4dBgMIAEoCRIcCgljaGF0X3R5cGUYBiABKA4yCS5DaGF0VHlwZUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChatTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SendMsgCsReq), global::EggLink.DanhengServer.Proto.SendMsgCsReq.Parser, new[]{ "ToUidList", "Emote", "MsgType", "Text", "ChatType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SendMsgCsReq : pb::IMessage<SendMsgCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SendMsgCsReq> _parser = new pb::MessageParser<SendMsgCsReq>(() => new SendMsgCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SendMsgCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SendMsgCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq(SendMsgCsReq other) : this() {
      toUidList_ = other.toUidList_.Clone();
      emote_ = other.emote_;
      msgType_ = other.msgType_;
      text_ = other.text_;
      chatType_ = other.chatType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SendMsgCsReq Clone() {
      return new SendMsgCsReq(this);
    }

    /// <summary>Field number for the "to_uid_list" field.</summary>
    public const int ToUidListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_toUidList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> toUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ToUidList {
      get { return toUidList_; }
    }

    /// <summary>Field number for the "emote" field.</summary>
    public const int EmoteFieldNumber = 13;
    private uint emote_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Emote {
      get { return emote_; }
      set {
        emote_ = value;
      }
    }

    /// <summary>Field number for the "msg_type" field.</summary>
    public const int MsgTypeFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.MsgType msgType_ = global::EggLink.DanhengServer.Proto.MsgType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MsgType MsgType {
      get { return msgType_; }
      set {
        msgType_ = value;
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 12;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chat_type" field.</summary>
    public const int ChatTypeFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ChatType chatType_ = global::EggLink.DanhengServer.Proto.ChatType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChatType ChatType {
      get { return chatType_; }
      set {
        chatType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SendMsgCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SendMsgCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!toUidList_.Equals(other.toUidList_)) return false;
      if (Emote != other.Emote) return false;
      if (MsgType != other.MsgType) return false;
      if (Text != other.Text) return false;
      if (ChatType != other.ChatType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= toUidList_.GetHashCode();
      if (Emote != 0) hash ^= Emote.GetHashCode();
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MsgType.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) hash ^= ChatType.GetHashCode();
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
      toUidList_.WriteTo(output, _repeated_toUidList_codec);
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MsgType);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ChatType);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Text);
      }
      if (Emote != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Emote);
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
      toUidList_.WriteTo(ref output, _repeated_toUidList_codec);
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MsgType);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ChatType);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Text);
      }
      if (Emote != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Emote);
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
      size += toUidList_.CalculateSize(_repeated_toUidList_codec);
      if (Emote != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Emote);
      }
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MsgType);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ChatType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SendMsgCsReq other) {
      if (other == null) {
        return;
      }
      toUidList_.Add(other.toUidList_);
      if (other.Emote != 0) {
        Emote = other.Emote;
      }
      if (other.MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MsgType = other.MsgType;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.ChatType != global::EggLink.DanhengServer.Proto.ChatType.None) {
        ChatType = other.ChatType;
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
          case 34:
          case 32: {
            toUidList_.AddEntriesFrom(input, _repeated_toUidList_codec);
            break;
          }
          case 40: {
            MsgType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 48: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 98: {
            Text = input.ReadString();
            break;
          }
          case 104: {
            Emote = input.ReadUInt32();
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
          case 34:
          case 32: {
            toUidList_.AddEntriesFrom(ref input, _repeated_toUidList_codec);
            break;
          }
          case 40: {
            MsgType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 48: {
            ChatType = (global::EggLink.DanhengServer.Proto.ChatType) input.ReadEnum();
            break;
          }
          case 98: {
            Text = input.ReadString();
            break;
          }
          case 104: {
            Emote = input.ReadUInt32();
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
