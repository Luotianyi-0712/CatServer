// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DMAOMCBEANI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DMAOMCBEANI.proto</summary>
  public static partial class DMAOMCBEANIReflection {

    #region Descriptor
    /// <summary>File descriptor for DMAOMCBEANI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DMAOMCBEANIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFETUFPTUNCRUFOSS5wcm90byJJCgtETUFPTUNCRUFOSRITCgtBUERJRkND",
            "RkFHRxgGIAEoAhIQCghncm91cF9pZBgCIAEoDRITCgtGSE9CSEdIS0hQTRgM",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DMAOMCBEANI), global::EggLink.DanhengServer.Proto.DMAOMCBEANI.Parser, new[]{ "APDIFCCFAGG", "GroupId", "FHOBHGHKHPM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DMAOMCBEANI : pb::IMessage<DMAOMCBEANI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DMAOMCBEANI> _parser = new pb::MessageParser<DMAOMCBEANI>(() => new DMAOMCBEANI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DMAOMCBEANI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DMAOMCBEANIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DMAOMCBEANI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DMAOMCBEANI(DMAOMCBEANI other) : this() {
      aPDIFCCFAGG_ = other.aPDIFCCFAGG_;
      groupId_ = other.groupId_;
      fHOBHGHKHPM_ = other.fHOBHGHKHPM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DMAOMCBEANI Clone() {
      return new DMAOMCBEANI(this);
    }

    /// <summary>Field number for the "APDIFCCFAGG" field.</summary>
    public const int APDIFCCFAGGFieldNumber = 6;
    private float aPDIFCCFAGG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float APDIFCCFAGG {
      get { return aPDIFCCFAGG_; }
      set {
        aPDIFCCFAGG_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "FHOBHGHKHPM" field.</summary>
    public const int FHOBHGHKHPMFieldNumber = 12;
    private uint fHOBHGHKHPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FHOBHGHKHPM {
      get { return fHOBHGHKHPM_; }
      set {
        fHOBHGHKHPM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DMAOMCBEANI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DMAOMCBEANI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(APDIFCCFAGG, other.APDIFCCFAGG)) return false;
      if (GroupId != other.GroupId) return false;
      if (FHOBHGHKHPM != other.FHOBHGHKHPM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (APDIFCCFAGG != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(APDIFCCFAGG);
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (FHOBHGHKHPM != 0) hash ^= FHOBHGHKHPM.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (APDIFCCFAGG != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(APDIFCCFAGG);
      }
      if (FHOBHGHKHPM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FHOBHGHKHPM);
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (APDIFCCFAGG != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(APDIFCCFAGG);
      }
      if (FHOBHGHKHPM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FHOBHGHKHPM);
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
      if (APDIFCCFAGG != 0F) {
        size += 1 + 4;
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (FHOBHGHKHPM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FHOBHGHKHPM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DMAOMCBEANI other) {
      if (other == null) {
        return;
      }
      if (other.APDIFCCFAGG != 0F) {
        APDIFCCFAGG = other.APDIFCCFAGG;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.FHOBHGHKHPM != 0) {
        FHOBHGHKHPM = other.FHOBHGHKHPM;
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 53: {
            APDIFCCFAGG = input.ReadFloat();
            break;
          }
          case 96: {
            FHOBHGHKHPM = input.ReadUInt32();
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 53: {
            APDIFCCFAGG = input.ReadFloat();
            break;
          }
          case 96: {
            FHOBHGHKHPM = input.ReadUInt32();
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
