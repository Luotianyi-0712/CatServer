// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MDGEBOCFJBL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MDGEBOCFJBL.proto</summary>
  public static partial class MDGEBOCFJBLReflection {

    #region Descriptor
    /// <summary>File descriptor for MDGEBOCFJBL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MDGEBOCFJBLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNREdFQk9DRkpCTC5wcm90byJeCgtNREdFQk9DRkpCTBITCgtPREVGSkdD",
            "REdLUBgNIAMoDRIQCghldmVudF9pZBgKIAEoDRITCgtNQkFEREtKS0xLRRgH",
            "IAEoDRITCgtKTUdKR01KT0NIQhgOIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MDGEBOCFJBL), global::EggLink.DanhengServer.Proto.MDGEBOCFJBL.Parser, new[]{ "ODEFJGCDGKP", "EventId", "MBADDKJKLKE", "JMGJGMJOCHB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MDGEBOCFJBL : pb::IMessage<MDGEBOCFJBL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MDGEBOCFJBL> _parser = new pb::MessageParser<MDGEBOCFJBL>(() => new MDGEBOCFJBL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MDGEBOCFJBL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MDGEBOCFJBLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MDGEBOCFJBL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MDGEBOCFJBL(MDGEBOCFJBL other) : this() {
      oDEFJGCDGKP_ = other.oDEFJGCDGKP_.Clone();
      eventId_ = other.eventId_;
      mBADDKJKLKE_ = other.mBADDKJKLKE_;
      jMGJGMJOCHB_ = other.jMGJGMJOCHB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MDGEBOCFJBL Clone() {
      return new MDGEBOCFJBL(this);
    }

    /// <summary>Field number for the "ODEFJGCDGKP" field.</summary>
    public const int ODEFJGCDGKPFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_oDEFJGCDGKP_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> oDEFJGCDGKP_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ODEFJGCDGKP {
      get { return oDEFJGCDGKP_; }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 10;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "MBADDKJKLKE" field.</summary>
    public const int MBADDKJKLKEFieldNumber = 7;
    private uint mBADDKJKLKE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MBADDKJKLKE {
      get { return mBADDKJKLKE_; }
      set {
        mBADDKJKLKE_ = value;
      }
    }

    /// <summary>Field number for the "JMGJGMJOCHB" field.</summary>
    public const int JMGJGMJOCHBFieldNumber = 14;
    private uint jMGJGMJOCHB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JMGJGMJOCHB {
      get { return jMGJGMJOCHB_; }
      set {
        jMGJGMJOCHB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MDGEBOCFJBL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MDGEBOCFJBL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!oDEFJGCDGKP_.Equals(other.oDEFJGCDGKP_)) return false;
      if (EventId != other.EventId) return false;
      if (MBADDKJKLKE != other.MBADDKJKLKE) return false;
      if (JMGJGMJOCHB != other.JMGJGMJOCHB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= oDEFJGCDGKP_.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (MBADDKJKLKE != 0) hash ^= MBADDKJKLKE.GetHashCode();
      if (JMGJGMJOCHB != 0) hash ^= JMGJGMJOCHB.GetHashCode();
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
      if (MBADDKJKLKE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MBADDKJKLKE);
      }
      if (EventId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EventId);
      }
      oDEFJGCDGKP_.WriteTo(output, _repeated_oDEFJGCDGKP_codec);
      if (JMGJGMJOCHB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(JMGJGMJOCHB);
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
      if (MBADDKJKLKE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MBADDKJKLKE);
      }
      if (EventId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EventId);
      }
      oDEFJGCDGKP_.WriteTo(ref output, _repeated_oDEFJGCDGKP_codec);
      if (JMGJGMJOCHB != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(JMGJGMJOCHB);
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
      size += oDEFJGCDGKP_.CalculateSize(_repeated_oDEFJGCDGKP_codec);
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (MBADDKJKLKE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MBADDKJKLKE);
      }
      if (JMGJGMJOCHB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JMGJGMJOCHB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MDGEBOCFJBL other) {
      if (other == null) {
        return;
      }
      oDEFJGCDGKP_.Add(other.oDEFJGCDGKP_);
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.MBADDKJKLKE != 0) {
        MBADDKJKLKE = other.MBADDKJKLKE;
      }
      if (other.JMGJGMJOCHB != 0) {
        JMGJGMJOCHB = other.JMGJGMJOCHB;
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
          case 56: {
            MBADDKJKLKE = input.ReadUInt32();
            break;
          }
          case 80: {
            EventId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            oDEFJGCDGKP_.AddEntriesFrom(input, _repeated_oDEFJGCDGKP_codec);
            break;
          }
          case 112: {
            JMGJGMJOCHB = input.ReadUInt32();
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
          case 56: {
            MBADDKJKLKE = input.ReadUInt32();
            break;
          }
          case 80: {
            EventId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            oDEFJGCDGKP_.AddEntriesFrom(ref input, _repeated_oDEFJGCDGKP_codec);
            break;
          }
          case 112: {
            JMGJGMJOCHB = input.ReadUInt32();
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
