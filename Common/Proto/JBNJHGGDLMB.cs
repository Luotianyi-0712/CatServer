// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JBNJHGGDLMB.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JBNJHGGDLMB.proto</summary>
  public static partial class JBNJHGGDLMBReflection {

    #region Descriptor
    /// <summary>File descriptor for JBNJHGGDLMB.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JBNJHGGDLMBReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFKQk5KSEdHRExNQi5wcm90bxoRQUJDR09ER05MSkYucHJvdG8iRQoLSkJO",
            "SkhHR0RMTUISIQoLR0ZLQ05MSlBPT0MYBiABKAsyDC5BQkNHT0RHTkxKRhIT",
            "CgtQS0RKSkhLQUpQTxgIIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ABCGODGNLJFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JBNJHGGDLMB), global::EggLink.DanhengServer.Proto.JBNJHGGDLMB.Parser, new[]{ "GFKCNLJPOOC", "PKDJJHKAJPO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JBNJHGGDLMB : pb::IMessage<JBNJHGGDLMB>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JBNJHGGDLMB> _parser = new pb::MessageParser<JBNJHGGDLMB>(() => new JBNJHGGDLMB());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JBNJHGGDLMB> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JBNJHGGDLMBReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JBNJHGGDLMB() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JBNJHGGDLMB(JBNJHGGDLMB other) : this() {
      gFKCNLJPOOC_ = other.gFKCNLJPOOC_ != null ? other.gFKCNLJPOOC_.Clone() : null;
      pKDJJHKAJPO_ = other.pKDJJHKAJPO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JBNJHGGDLMB Clone() {
      return new JBNJHGGDLMB(this);
    }

    /// <summary>Field number for the "GFKCNLJPOOC" field.</summary>
    public const int GFKCNLJPOOCFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.ABCGODGNLJF gFKCNLJPOOC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ABCGODGNLJF GFKCNLJPOOC {
      get { return gFKCNLJPOOC_; }
      set {
        gFKCNLJPOOC_ = value;
      }
    }

    /// <summary>Field number for the "PKDJJHKAJPO" field.</summary>
    public const int PKDJJHKAJPOFieldNumber = 8;
    private uint pKDJJHKAJPO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PKDJJHKAJPO {
      get { return pKDJJHKAJPO_; }
      set {
        pKDJJHKAJPO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JBNJHGGDLMB);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JBNJHGGDLMB other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GFKCNLJPOOC, other.GFKCNLJPOOC)) return false;
      if (PKDJJHKAJPO != other.PKDJJHKAJPO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gFKCNLJPOOC_ != null) hash ^= GFKCNLJPOOC.GetHashCode();
      if (PKDJJHKAJPO != 0) hash ^= PKDJJHKAJPO.GetHashCode();
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
      if (gFKCNLJPOOC_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GFKCNLJPOOC);
      }
      if (PKDJJHKAJPO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PKDJJHKAJPO);
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
      if (gFKCNLJPOOC_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GFKCNLJPOOC);
      }
      if (PKDJJHKAJPO != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PKDJJHKAJPO);
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
      if (gFKCNLJPOOC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GFKCNLJPOOC);
      }
      if (PKDJJHKAJPO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PKDJJHKAJPO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JBNJHGGDLMB other) {
      if (other == null) {
        return;
      }
      if (other.gFKCNLJPOOC_ != null) {
        if (gFKCNLJPOOC_ == null) {
          GFKCNLJPOOC = new global::EggLink.DanhengServer.Proto.ABCGODGNLJF();
        }
        GFKCNLJPOOC.MergeFrom(other.GFKCNLJPOOC);
      }
      if (other.PKDJJHKAJPO != 0) {
        PKDJJHKAJPO = other.PKDJJHKAJPO;
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
          case 50: {
            if (gFKCNLJPOOC_ == null) {
              GFKCNLJPOOC = new global::EggLink.DanhengServer.Proto.ABCGODGNLJF();
            }
            input.ReadMessage(GFKCNLJPOOC);
            break;
          }
          case 64: {
            PKDJJHKAJPO = input.ReadUInt32();
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
          case 50: {
            if (gFKCNLJPOOC_ == null) {
              GFKCNLJPOOC = new global::EggLink.DanhengServer.Proto.ABCGODGNLJF();
            }
            input.ReadMessage(GFKCNLJPOOC);
            break;
          }
          case 64: {
            PKDJJHKAJPO = input.ReadUInt32();
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