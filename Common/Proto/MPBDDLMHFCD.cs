// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MPBDDLMHFCD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MPBDDLMHFCD.proto</summary>
  public static partial class MPBDDLMHFCDReflection {

    #region Descriptor
    /// <summary>File descriptor for MPBDDLMHFCD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MPBDDLMHFCDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNUEJERExNSEZDRC5wcm90byJyCgtNUEJERExNSEZDRBITCgtMQUpJT09P",
            "QUNEShgMIAEoBRITCgtGRktHTEpOTEpDThgLIAEoDRITCgtJQUlHSktHQkdI",
            "QRgFIAEoDRITCgtKTkhKSkxQT05ERBgJIAEoBRIPCgdpdGVtX2lkGA4gASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MPBDDLMHFCD), global::EggLink.DanhengServer.Proto.MPBDDLMHFCD.Parser, new[]{ "LAJIOOOACDJ", "FFKGLJNLJCN", "IAIGJKGBGHA", "JNHJJLPONDD", "ItemId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MPBDDLMHFCD : pb::IMessage<MPBDDLMHFCD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MPBDDLMHFCD> _parser = new pb::MessageParser<MPBDDLMHFCD>(() => new MPBDDLMHFCD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MPBDDLMHFCD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MPBDDLMHFCDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MPBDDLMHFCD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MPBDDLMHFCD(MPBDDLMHFCD other) : this() {
      lAJIOOOACDJ_ = other.lAJIOOOACDJ_;
      fFKGLJNLJCN_ = other.fFKGLJNLJCN_;
      iAIGJKGBGHA_ = other.iAIGJKGBGHA_;
      jNHJJLPONDD_ = other.jNHJJLPONDD_;
      itemId_ = other.itemId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MPBDDLMHFCD Clone() {
      return new MPBDDLMHFCD(this);
    }

    /// <summary>Field number for the "LAJIOOOACDJ" field.</summary>
    public const int LAJIOOOACDJFieldNumber = 12;
    private int lAJIOOOACDJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LAJIOOOACDJ {
      get { return lAJIOOOACDJ_; }
      set {
        lAJIOOOACDJ_ = value;
      }
    }

    /// <summary>Field number for the "FFKGLJNLJCN" field.</summary>
    public const int FFKGLJNLJCNFieldNumber = 11;
    private uint fFKGLJNLJCN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FFKGLJNLJCN {
      get { return fFKGLJNLJCN_; }
      set {
        fFKGLJNLJCN_ = value;
      }
    }

    /// <summary>Field number for the "IAIGJKGBGHA" field.</summary>
    public const int IAIGJKGBGHAFieldNumber = 5;
    private uint iAIGJKGBGHA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IAIGJKGBGHA {
      get { return iAIGJKGBGHA_; }
      set {
        iAIGJKGBGHA_ = value;
      }
    }

    /// <summary>Field number for the "JNHJJLPONDD" field.</summary>
    public const int JNHJJLPONDDFieldNumber = 9;
    private int jNHJJLPONDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int JNHJJLPONDD {
      get { return jNHJJLPONDD_; }
      set {
        jNHJJLPONDD_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 14;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MPBDDLMHFCD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MPBDDLMHFCD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LAJIOOOACDJ != other.LAJIOOOACDJ) return false;
      if (FFKGLJNLJCN != other.FFKGLJNLJCN) return false;
      if (IAIGJKGBGHA != other.IAIGJKGBGHA) return false;
      if (JNHJJLPONDD != other.JNHJJLPONDD) return false;
      if (ItemId != other.ItemId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LAJIOOOACDJ != 0) hash ^= LAJIOOOACDJ.GetHashCode();
      if (FFKGLJNLJCN != 0) hash ^= FFKGLJNLJCN.GetHashCode();
      if (IAIGJKGBGHA != 0) hash ^= IAIGJKGBGHA.GetHashCode();
      if (JNHJJLPONDD != 0) hash ^= JNHJJLPONDD.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
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
      if (IAIGJKGBGHA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IAIGJKGBGHA);
      }
      if (JNHJJLPONDD != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(JNHJJLPONDD);
      }
      if (FFKGLJNLJCN != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FFKGLJNLJCN);
      }
      if (LAJIOOOACDJ != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(LAJIOOOACDJ);
      }
      if (ItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ItemId);
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
      if (IAIGJKGBGHA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IAIGJKGBGHA);
      }
      if (JNHJJLPONDD != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(JNHJJLPONDD);
      }
      if (FFKGLJNLJCN != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FFKGLJNLJCN);
      }
      if (LAJIOOOACDJ != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(LAJIOOOACDJ);
      }
      if (ItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ItemId);
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
      if (LAJIOOOACDJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LAJIOOOACDJ);
      }
      if (FFKGLJNLJCN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FFKGLJNLJCN);
      }
      if (IAIGJKGBGHA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IAIGJKGBGHA);
      }
      if (JNHJJLPONDD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(JNHJJLPONDD);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MPBDDLMHFCD other) {
      if (other == null) {
        return;
      }
      if (other.LAJIOOOACDJ != 0) {
        LAJIOOOACDJ = other.LAJIOOOACDJ;
      }
      if (other.FFKGLJNLJCN != 0) {
        FFKGLJNLJCN = other.FFKGLJNLJCN;
      }
      if (other.IAIGJKGBGHA != 0) {
        IAIGJKGBGHA = other.IAIGJKGBGHA;
      }
      if (other.JNHJJLPONDD != 0) {
        JNHJJLPONDD = other.JNHJJLPONDD;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
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
          case 40: {
            IAIGJKGBGHA = input.ReadUInt32();
            break;
          }
          case 72: {
            JNHJJLPONDD = input.ReadInt32();
            break;
          }
          case 88: {
            FFKGLJNLJCN = input.ReadUInt32();
            break;
          }
          case 96: {
            LAJIOOOACDJ = input.ReadInt32();
            break;
          }
          case 112: {
            ItemId = input.ReadUInt32();
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
          case 40: {
            IAIGJKGBGHA = input.ReadUInt32();
            break;
          }
          case 72: {
            JNHJJLPONDD = input.ReadInt32();
            break;
          }
          case 88: {
            FFKGLJNLJCN = input.ReadUInt32();
            break;
          }
          case 96: {
            LAJIOOOACDJ = input.ReadInt32();
            break;
          }
          case 112: {
            ItemId = input.ReadUInt32();
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