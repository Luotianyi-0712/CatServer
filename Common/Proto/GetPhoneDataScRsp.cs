// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetPhoneDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetPhoneDataScRsp.proto</summary>
  public static partial class GetPhoneDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetPhoneDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPhoneDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHZXRQaG9uZURhdGFTY1JzcC5wcm90byKOAQoRR2V0UGhvbmVEYXRhU2NS",
            "c3ASFwoPY3VyX3Bob25lX3RoZW1lGAogASgNEg8KB3JldGNvZGUYDiABKA0S",
            "GgoSb3duZWRfY2hhdF9idWJibGVzGAkgAygNEhcKD2N1cl9jaGF0X2J1YmJs",
            "ZRgNIAEoDRIaChJvd25lZF9waG9uZV90aGVtZXMYCyADKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetPhoneDataScRsp), global::EggLink.DanhengServer.Proto.GetPhoneDataScRsp.Parser, new[]{ "CurPhoneTheme", "Retcode", "OwnedChatBubbles", "CurChatBubble", "OwnedPhoneThemes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetPhoneDataScRsp : pb::IMessage<GetPhoneDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetPhoneDataScRsp> _parser = new pb::MessageParser<GetPhoneDataScRsp>(() => new GetPhoneDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetPhoneDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetPhoneDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPhoneDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPhoneDataScRsp(GetPhoneDataScRsp other) : this() {
      curPhoneTheme_ = other.curPhoneTheme_;
      retcode_ = other.retcode_;
      ownedChatBubbles_ = other.ownedChatBubbles_.Clone();
      curChatBubble_ = other.curChatBubble_;
      ownedPhoneThemes_ = other.ownedPhoneThemes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPhoneDataScRsp Clone() {
      return new GetPhoneDataScRsp(this);
    }

    /// <summary>Field number for the "cur_phone_theme" field.</summary>
    public const int CurPhoneThemeFieldNumber = 10;
    private uint curPhoneTheme_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurPhoneTheme {
      get { return curPhoneTheme_; }
      set {
        curPhoneTheme_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "owned_chat_bubbles" field.</summary>
    public const int OwnedChatBubblesFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_ownedChatBubbles_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> ownedChatBubbles_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OwnedChatBubbles {
      get { return ownedChatBubbles_; }
    }

    /// <summary>Field number for the "cur_chat_bubble" field.</summary>
    public const int CurChatBubbleFieldNumber = 13;
    private uint curChatBubble_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurChatBubble {
      get { return curChatBubble_; }
      set {
        curChatBubble_ = value;
      }
    }

    /// <summary>Field number for the "owned_phone_themes" field.</summary>
    public const int OwnedPhoneThemesFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_ownedPhoneThemes_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> ownedPhoneThemes_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OwnedPhoneThemes {
      get { return ownedPhoneThemes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetPhoneDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetPhoneDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurPhoneTheme != other.CurPhoneTheme) return false;
      if (Retcode != other.Retcode) return false;
      if(!ownedChatBubbles_.Equals(other.ownedChatBubbles_)) return false;
      if (CurChatBubble != other.CurChatBubble) return false;
      if(!ownedPhoneThemes_.Equals(other.ownedPhoneThemes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurPhoneTheme != 0) hash ^= CurPhoneTheme.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= ownedChatBubbles_.GetHashCode();
      if (CurChatBubble != 0) hash ^= CurChatBubble.GetHashCode();
      hash ^= ownedPhoneThemes_.GetHashCode();
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
      ownedChatBubbles_.WriteTo(output, _repeated_ownedChatBubbles_codec);
      if (CurPhoneTheme != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurPhoneTheme);
      }
      ownedPhoneThemes_.WriteTo(output, _repeated_ownedPhoneThemes_codec);
      if (CurChatBubble != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CurChatBubble);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      ownedChatBubbles_.WriteTo(ref output, _repeated_ownedChatBubbles_codec);
      if (CurPhoneTheme != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurPhoneTheme);
      }
      ownedPhoneThemes_.WriteTo(ref output, _repeated_ownedPhoneThemes_codec);
      if (CurChatBubble != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CurChatBubble);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Retcode);
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
      if (CurPhoneTheme != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurPhoneTheme);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += ownedChatBubbles_.CalculateSize(_repeated_ownedChatBubbles_codec);
      if (CurChatBubble != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurChatBubble);
      }
      size += ownedPhoneThemes_.CalculateSize(_repeated_ownedPhoneThemes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetPhoneDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.CurPhoneTheme != 0) {
        CurPhoneTheme = other.CurPhoneTheme;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      ownedChatBubbles_.Add(other.ownedChatBubbles_);
      if (other.CurChatBubble != 0) {
        CurChatBubble = other.CurChatBubble;
      }
      ownedPhoneThemes_.Add(other.ownedPhoneThemes_);
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
          case 74:
          case 72: {
            ownedChatBubbles_.AddEntriesFrom(input, _repeated_ownedChatBubbles_codec);
            break;
          }
          case 80: {
            CurPhoneTheme = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            ownedPhoneThemes_.AddEntriesFrom(input, _repeated_ownedPhoneThemes_codec);
            break;
          }
          case 104: {
            CurChatBubble = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
          case 74:
          case 72: {
            ownedChatBubbles_.AddEntriesFrom(ref input, _repeated_ownedChatBubbles_codec);
            break;
          }
          case 80: {
            CurPhoneTheme = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            ownedPhoneThemes_.AddEntriesFrom(ref input, _repeated_ownedPhoneThemes_codec);
            break;
          }
          case 104: {
            CurChatBubble = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadUInt32();
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
