// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EPEPEAEIJEE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from EPEPEAEIJEE.proto</summary>
  public static partial class EPEPEAEIJEEReflection {

    #region Descriptor
    /// <summary>File descriptor for EPEPEAEIJEE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EPEPEAEIJEEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFUEVQRUFFSUpFRS5wcm90byJGCgtFUEVQRUFFSUpFRRITCgtOUE1PUE9B",
            "RElMRRgGIAEoDRINCgVsZXZlbBgOIAEoDRITCgtLQUlCRURCRk5LTBgMIAEo",
            "DUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.EPEPEAEIJEE), global::EggLink.DanhengServer.Proto.EPEPEAEIJEE.Parser, new[]{ "NPMOPOADILE", "Level", "KAIBEDBFNKL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class EPEPEAEIJEE : pb::IMessage<EPEPEAEIJEE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EPEPEAEIJEE> _parser = new pb::MessageParser<EPEPEAEIJEE>(() => new EPEPEAEIJEE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EPEPEAEIJEE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EPEPEAEIJEEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EPEPEAEIJEE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EPEPEAEIJEE(EPEPEAEIJEE other) : this() {
      nPMOPOADILE_ = other.nPMOPOADILE_;
      level_ = other.level_;
      kAIBEDBFNKL_ = other.kAIBEDBFNKL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EPEPEAEIJEE Clone() {
      return new EPEPEAEIJEE(this);
    }

    /// <summary>Field number for the "NPMOPOADILE" field.</summary>
    public const int NPMOPOADILEFieldNumber = 6;
    private uint nPMOPOADILE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NPMOPOADILE {
      get { return nPMOPOADILE_; }
      set {
        nPMOPOADILE_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 14;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "KAIBEDBFNKL" field.</summary>
    public const int KAIBEDBFNKLFieldNumber = 12;
    private uint kAIBEDBFNKL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KAIBEDBFNKL {
      get { return kAIBEDBFNKL_; }
      set {
        kAIBEDBFNKL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EPEPEAEIJEE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EPEPEAEIJEE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NPMOPOADILE != other.NPMOPOADILE) return false;
      if (Level != other.Level) return false;
      if (KAIBEDBFNKL != other.KAIBEDBFNKL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NPMOPOADILE != 0) hash ^= NPMOPOADILE.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (KAIBEDBFNKL != 0) hash ^= KAIBEDBFNKL.GetHashCode();
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
      if (NPMOPOADILE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NPMOPOADILE);
      }
      if (KAIBEDBFNKL != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KAIBEDBFNKL);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
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
      if (NPMOPOADILE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NPMOPOADILE);
      }
      if (KAIBEDBFNKL != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KAIBEDBFNKL);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
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
      if (NPMOPOADILE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NPMOPOADILE);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (KAIBEDBFNKL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KAIBEDBFNKL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EPEPEAEIJEE other) {
      if (other == null) {
        return;
      }
      if (other.NPMOPOADILE != 0) {
        NPMOPOADILE = other.NPMOPOADILE;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.KAIBEDBFNKL != 0) {
        KAIBEDBFNKL = other.KAIBEDBFNKL;
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
          case 48: {
            NPMOPOADILE = input.ReadUInt32();
            break;
          }
          case 96: {
            KAIBEDBFNKL = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
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
          case 48: {
            NPMOPOADILE = input.ReadUInt32();
            break;
          }
          case 96: {
            KAIBEDBFNKL = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
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
