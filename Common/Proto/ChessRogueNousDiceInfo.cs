// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueNousDiceInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueNousDiceInfo.proto</summary>
  public static partial class ChessRogueNousDiceInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueNousDiceInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueNousDiceInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDaGVzc1JvZ3VlTm91c0RpY2VJbmZvLnByb3RvGiNDaGVzc1JvZ3VlTm91",
            "c0RpY2VTdXJmYWNlSW5mby5wcm90byKbAQoWQ2hlc3NSb2d1ZU5vdXNEaWNl",
            "SW5mbxIWCg5tYXhfZGlmZmljdWx0eRgOIAEoDRI0CgxkaWNlX3N1cmZhY2UY",
            "AiADKAsyHi5DaGVzc1JvZ3VlTm91c0RpY2VTdXJmYWNlSW5mbxIWCg5kaWNl",
            "X2JyYW5jaF9pZBgFIAEoDRIbChNxdWVzdGlvbl9kaWZmaWN1bHR5GAogASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueNousDiceSurfaceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo), global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfo.Parser, new[]{ "MaxDifficulty", "DiceSurface", "DiceBranchId", "QuestionDifficulty" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueNousDiceInfo : pb::IMessage<ChessRogueNousDiceInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueNousDiceInfo> _parser = new pb::MessageParser<ChessRogueNousDiceInfo>(() => new ChessRogueNousDiceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueNousDiceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueNousDiceInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDiceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDiceInfo(ChessRogueNousDiceInfo other) : this() {
      maxDifficulty_ = other.maxDifficulty_;
      diceSurface_ = other.diceSurface_.Clone();
      diceBranchId_ = other.diceBranchId_;
      questionDifficulty_ = other.questionDifficulty_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDiceInfo Clone() {
      return new ChessRogueNousDiceInfo(this);
    }

    /// <summary>Field number for the "max_difficulty" field.</summary>
    public const int MaxDifficultyFieldNumber = 14;
    private uint maxDifficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxDifficulty {
      get { return maxDifficulty_; }
      set {
        maxDifficulty_ = value;
      }
    }

    /// <summary>Field number for the "dice_surface" field.</summary>
    public const int DiceSurfaceFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChessRogueNousDiceSurfaceInfo> _repeated_diceSurface_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.ChessRogueNousDiceSurfaceInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousDiceSurfaceInfo> diceSurface_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousDiceSurfaceInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChessRogueNousDiceSurfaceInfo> DiceSurface {
      get { return diceSurface_; }
    }

    /// <summary>Field number for the "dice_branch_id" field.</summary>
    public const int DiceBranchIdFieldNumber = 5;
    private uint diceBranchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiceBranchId {
      get { return diceBranchId_; }
      set {
        diceBranchId_ = value;
      }
    }

    /// <summary>Field number for the "question_difficulty" field.</summary>
    public const int QuestionDifficultyFieldNumber = 10;
    private uint questionDifficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestionDifficulty {
      get { return questionDifficulty_; }
      set {
        questionDifficulty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueNousDiceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueNousDiceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxDifficulty != other.MaxDifficulty) return false;
      if(!diceSurface_.Equals(other.diceSurface_)) return false;
      if (DiceBranchId != other.DiceBranchId) return false;
      if (QuestionDifficulty != other.QuestionDifficulty) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaxDifficulty != 0) hash ^= MaxDifficulty.GetHashCode();
      hash ^= diceSurface_.GetHashCode();
      if (DiceBranchId != 0) hash ^= DiceBranchId.GetHashCode();
      if (QuestionDifficulty != 0) hash ^= QuestionDifficulty.GetHashCode();
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
      diceSurface_.WriteTo(output, _repeated_diceSurface_codec);
      if (DiceBranchId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DiceBranchId);
      }
      if (QuestionDifficulty != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(QuestionDifficulty);
      }
      if (MaxDifficulty != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MaxDifficulty);
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
      diceSurface_.WriteTo(ref output, _repeated_diceSurface_codec);
      if (DiceBranchId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DiceBranchId);
      }
      if (QuestionDifficulty != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(QuestionDifficulty);
      }
      if (MaxDifficulty != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MaxDifficulty);
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
      if (MaxDifficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxDifficulty);
      }
      size += diceSurface_.CalculateSize(_repeated_diceSurface_codec);
      if (DiceBranchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiceBranchId);
      }
      if (QuestionDifficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestionDifficulty);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueNousDiceInfo other) {
      if (other == null) {
        return;
      }
      if (other.MaxDifficulty != 0) {
        MaxDifficulty = other.MaxDifficulty;
      }
      diceSurface_.Add(other.diceSurface_);
      if (other.DiceBranchId != 0) {
        DiceBranchId = other.DiceBranchId;
      }
      if (other.QuestionDifficulty != 0) {
        QuestionDifficulty = other.QuestionDifficulty;
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
          case 18: {
            diceSurface_.AddEntriesFrom(input, _repeated_diceSurface_codec);
            break;
          }
          case 40: {
            DiceBranchId = input.ReadUInt32();
            break;
          }
          case 80: {
            QuestionDifficulty = input.ReadUInt32();
            break;
          }
          case 112: {
            MaxDifficulty = input.ReadUInt32();
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
          case 18: {
            diceSurface_.AddEntriesFrom(ref input, _repeated_diceSurface_codec);
            break;
          }
          case 40: {
            DiceBranchId = input.ReadUInt32();
            break;
          }
          case 80: {
            QuestionDifficulty = input.ReadUInt32();
            break;
          }
          case 112: {
            MaxDifficulty = input.ReadUInt32();
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
