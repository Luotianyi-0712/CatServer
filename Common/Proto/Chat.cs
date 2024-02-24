// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Chat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Chat.proto</summary>
  public static partial class ChatReflection {

    #region Descriptor
    /// <summary>File descriptor for Chat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpDaGF0LnByb3RvGg1Nc2dUeXBlLnByb3RvImYKBENoYXQSDAoEdGV4dBgF",
            "IAEoCRIaCghtc2dfdHlwZRgCIAEoDjIILk1zZ1R5cGUSDQoFZW1vdGUYBiAB",
            "KA0SEQoJc2VudF90aW1lGAkgASgEEhIKCnNlbmRlcl91aWQYBCABKA1CHqoC",
            "G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MsgTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Chat), global::EggLink.DanhengServer.Proto.Chat.Parser, new[]{ "Text", "MsgType", "Emote", "SentTime", "SenderUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Chat : pb::IMessage<Chat>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Chat> _parser = new pb::MessageParser<Chat>(() => new Chat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Chat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Chat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Chat(Chat other) : this() {
      text_ = other.text_;
      msgType_ = other.msgType_;
      emote_ = other.emote_;
      sentTime_ = other.sentTime_;
      senderUid_ = other.senderUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Chat Clone() {
      return new Chat(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 5;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "msg_type" field.</summary>
    public const int MsgTypeFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.MsgType msgType_ = global::EggLink.DanhengServer.Proto.MsgType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MsgType MsgType {
      get { return msgType_; }
      set {
        msgType_ = value;
      }
    }

    /// <summary>Field number for the "emote" field.</summary>
    public const int EmoteFieldNumber = 6;
    private uint emote_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Emote {
      get { return emote_; }
      set {
        emote_ = value;
      }
    }

    /// <summary>Field number for the "sent_time" field.</summary>
    public const int SentTimeFieldNumber = 9;
    private ulong sentTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SentTime {
      get { return sentTime_; }
      set {
        sentTime_ = value;
      }
    }

    /// <summary>Field number for the "sender_uid" field.</summary>
    public const int SenderUidFieldNumber = 4;
    private uint senderUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SenderUid {
      get { return senderUid_; }
      set {
        senderUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Chat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Chat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if (MsgType != other.MsgType) return false;
      if (Emote != other.Emote) return false;
      if (SentTime != other.SentTime) return false;
      if (SenderUid != other.SenderUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) hash ^= MsgType.GetHashCode();
      if (Emote != 0) hash ^= Emote.GetHashCode();
      if (SentTime != 0UL) hash ^= SentTime.GetHashCode();
      if (SenderUid != 0) hash ^= SenderUid.GetHashCode();
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
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MsgType);
      }
      if (SenderUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SenderUid);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Text);
      }
      if (Emote != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Emote);
      }
      if (SentTime != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(SentTime);
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
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MsgType);
      }
      if (SenderUid != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SenderUid);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Text);
      }
      if (Emote != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Emote);
      }
      if (SentTime != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(SentTime);
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
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MsgType);
      }
      if (Emote != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Emote);
      }
      if (SentTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SentTime);
      }
      if (SenderUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SenderUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Chat other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
      }
      if (other.MsgType != global::EggLink.DanhengServer.Proto.MsgType.None) {
        MsgType = other.MsgType;
      }
      if (other.Emote != 0) {
        Emote = other.Emote;
      }
      if (other.SentTime != 0UL) {
        SentTime = other.SentTime;
      }
      if (other.SenderUid != 0) {
        SenderUid = other.SenderUid;
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
          case 16: {
            MsgType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 32: {
            SenderUid = input.ReadUInt32();
            break;
          }
          case 42: {
            Text = input.ReadString();
            break;
          }
          case 48: {
            Emote = input.ReadUInt32();
            break;
          }
          case 72: {
            SentTime = input.ReadUInt64();
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
          case 16: {
            MsgType = (global::EggLink.DanhengServer.Proto.MsgType) input.ReadEnum();
            break;
          }
          case 32: {
            SenderUid = input.ReadUInt32();
            break;
          }
          case 42: {
            Text = input.ReadString();
            break;
          }
          case 48: {
            Emote = input.ReadUInt32();
            break;
          }
          case 72: {
            SentTime = input.ReadUInt64();
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
