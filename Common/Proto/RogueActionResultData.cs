// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueActionResultData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueActionResultData.proto</summary>
  public static partial class RogueActionResultDataReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueActionResultData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueActionResultDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtSb2d1ZUFjdGlvblJlc3VsdERhdGEucHJvdG8aE1JvZ3VlQnVmZkRhdGEu",
            "cHJvdG8aFlJvZ3VlTWlyYWNsZURhdGEucHJvdG8aGlJvZ3VlVmlydHVhbEl0",
            "ZW1EYXRhLnByb3RvIvcBChVSb2d1ZUFjdGlvblJlc3VsdERhdGESLAoNYWRk",
            "X2l0ZW1fbGlzdBgMIAEoCzIVLlJvZ3VlVmlydHVhbEl0ZW1EYXRhEi8KEHJl",
            "bW92ZV9pdGVtX2xpc3QYCyABKAsyFS5Sb2d1ZVZpcnR1YWxJdGVtRGF0YRIm",
            "Cg1hZGRfYnVmZl9saXN0GL8CIAEoCzIOLlJvZ3VlQnVmZkRhdGESKQoQcmVt",
            "b3ZlX2J1ZmZfbGlzdBi3AyABKAsyDi5Sb2d1ZUJ1ZmZEYXRhEiwKEGFkZF9t",
            "aXJhY2xlX2xpc3QYqAEgASgLMhEuUm9ndWVNaXJhY2xlRGF0YUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueBuffDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueVirtualItemDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueActionResultData), global::EggLink.DanhengServer.Proto.RogueActionResultData.Parser, new[]{ "AddItemList", "RemoveItemList", "AddBuffList", "RemoveBuffList", "AddMiracleList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueActionResultData : pb::IMessage<RogueActionResultData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueActionResultData> _parser = new pb::MessageParser<RogueActionResultData>(() => new RogueActionResultData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueActionResultData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueActionResultDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueActionResultData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueActionResultData(RogueActionResultData other) : this() {
      addItemList_ = other.addItemList_ != null ? other.addItemList_.Clone() : null;
      removeItemList_ = other.removeItemList_ != null ? other.removeItemList_.Clone() : null;
      addBuffList_ = other.addBuffList_ != null ? other.addBuffList_.Clone() : null;
      removeBuffList_ = other.removeBuffList_ != null ? other.removeBuffList_.Clone() : null;
      addMiracleList_ = other.addMiracleList_ != null ? other.addMiracleList_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueActionResultData Clone() {
      return new RogueActionResultData(this);
    }

    /// <summary>Field number for the "add_item_list" field.</summary>
    public const int AddItemListFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueVirtualItemData addItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueVirtualItemData AddItemList {
      get { return addItemList_; }
      set {
        addItemList_ = value;
      }
    }

    /// <summary>Field number for the "remove_item_list" field.</summary>
    public const int RemoveItemListFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.RogueVirtualItemData removeItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueVirtualItemData RemoveItemList {
      get { return removeItemList_; }
      set {
        removeItemList_ = value;
      }
    }

    /// <summary>Field number for the "add_buff_list" field.</summary>
    public const int AddBuffListFieldNumber = 319;
    private global::EggLink.DanhengServer.Proto.RogueBuffData addBuffList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffData AddBuffList {
      get { return addBuffList_; }
      set {
        addBuffList_ = value;
      }
    }

    /// <summary>Field number for the "remove_buff_list" field.</summary>
    public const int RemoveBuffListFieldNumber = 439;
    private global::EggLink.DanhengServer.Proto.RogueBuffData removeBuffList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffData RemoveBuffList {
      get { return removeBuffList_; }
      set {
        removeBuffList_ = value;
      }
    }

    /// <summary>Field number for the "add_miracle_list" field.</summary>
    public const int AddMiracleListFieldNumber = 168;
    private global::EggLink.DanhengServer.Proto.RogueMiracleData addMiracleList_;
    /// <summary>
    ///MCFPILGOKJL LBHBDGKKJIJ = 167;
    ///PONBIJNJGJN CANDAIPCPJK = 1473;
    ///KALADHPCJPN CDCGLLGKBPA = 1188;
    ///CNEKDDFMKCK FGHCBKGDKAB = 1032;
    ///HICHEGNFHNG IIDMFNJOBOG = 1742;
    ///PGJANLDGLEM DPCCLAKMHLJ = 477;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleData AddMiracleList {
      get { return addMiracleList_; }
      set {
        addMiracleList_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueActionResultData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueActionResultData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AddItemList, other.AddItemList)) return false;
      if (!object.Equals(RemoveItemList, other.RemoveItemList)) return false;
      if (!object.Equals(AddBuffList, other.AddBuffList)) return false;
      if (!object.Equals(RemoveBuffList, other.RemoveBuffList)) return false;
      if (!object.Equals(AddMiracleList, other.AddMiracleList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (addItemList_ != null) hash ^= AddItemList.GetHashCode();
      if (removeItemList_ != null) hash ^= RemoveItemList.GetHashCode();
      if (addBuffList_ != null) hash ^= AddBuffList.GetHashCode();
      if (removeBuffList_ != null) hash ^= RemoveBuffList.GetHashCode();
      if (addMiracleList_ != null) hash ^= AddMiracleList.GetHashCode();
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
      if (removeItemList_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RemoveItemList);
      }
      if (addItemList_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AddItemList);
      }
      if (addMiracleList_ != null) {
        output.WriteRawTag(194, 10);
        output.WriteMessage(AddMiracleList);
      }
      if (addBuffList_ != null) {
        output.WriteRawTag(250, 19);
        output.WriteMessage(AddBuffList);
      }
      if (removeBuffList_ != null) {
        output.WriteRawTag(186, 27);
        output.WriteMessage(RemoveBuffList);
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
      if (removeItemList_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RemoveItemList);
      }
      if (addItemList_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AddItemList);
      }
      if (addMiracleList_ != null) {
        output.WriteRawTag(194, 10);
        output.WriteMessage(AddMiracleList);
      }
      if (addBuffList_ != null) {
        output.WriteRawTag(250, 19);
        output.WriteMessage(AddBuffList);
      }
      if (removeBuffList_ != null) {
        output.WriteRawTag(186, 27);
        output.WriteMessage(RemoveBuffList);
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
      if (addItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AddItemList);
      }
      if (removeItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RemoveItemList);
      }
      if (addBuffList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(AddBuffList);
      }
      if (removeBuffList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RemoveBuffList);
      }
      if (addMiracleList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(AddMiracleList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueActionResultData other) {
      if (other == null) {
        return;
      }
      if (other.addItemList_ != null) {
        if (addItemList_ == null) {
          AddItemList = new global::EggLink.DanhengServer.Proto.RogueVirtualItemData();
        }
        AddItemList.MergeFrom(other.AddItemList);
      }
      if (other.removeItemList_ != null) {
        if (removeItemList_ == null) {
          RemoveItemList = new global::EggLink.DanhengServer.Proto.RogueVirtualItemData();
        }
        RemoveItemList.MergeFrom(other.RemoveItemList);
      }
      if (other.addBuffList_ != null) {
        if (addBuffList_ == null) {
          AddBuffList = new global::EggLink.DanhengServer.Proto.RogueBuffData();
        }
        AddBuffList.MergeFrom(other.AddBuffList);
      }
      if (other.removeBuffList_ != null) {
        if (removeBuffList_ == null) {
          RemoveBuffList = new global::EggLink.DanhengServer.Proto.RogueBuffData();
        }
        RemoveBuffList.MergeFrom(other.RemoveBuffList);
      }
      if (other.addMiracleList_ != null) {
        if (addMiracleList_ == null) {
          AddMiracleList = new global::EggLink.DanhengServer.Proto.RogueMiracleData();
        }
        AddMiracleList.MergeFrom(other.AddMiracleList);
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
          case 90: {
            if (removeItemList_ == null) {
              RemoveItemList = new global::EggLink.DanhengServer.Proto.RogueVirtualItemData();
            }
            input.ReadMessage(RemoveItemList);
            break;
          }
          case 98: {
            if (addItemList_ == null) {
              AddItemList = new global::EggLink.DanhengServer.Proto.RogueVirtualItemData();
            }
            input.ReadMessage(AddItemList);
            break;
          }
          case 1346: {
            if (addMiracleList_ == null) {
              AddMiracleList = new global::EggLink.DanhengServer.Proto.RogueMiracleData();
            }
            input.ReadMessage(AddMiracleList);
            break;
          }
          case 2554: {
            if (addBuffList_ == null) {
              AddBuffList = new global::EggLink.DanhengServer.Proto.RogueBuffData();
            }
            input.ReadMessage(AddBuffList);
            break;
          }
          case 3514: {
            if (removeBuffList_ == null) {
              RemoveBuffList = new global::EggLink.DanhengServer.Proto.RogueBuffData();
            }
            input.ReadMessage(RemoveBuffList);
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
          case 90: {
            if (removeItemList_ == null) {
              RemoveItemList = new global::EggLink.DanhengServer.Proto.RogueVirtualItemData();
            }
            input.ReadMessage(RemoveItemList);
            break;
          }
          case 98: {
            if (addItemList_ == null) {
              AddItemList = new global::EggLink.DanhengServer.Proto.RogueVirtualItemData();
            }
            input.ReadMessage(AddItemList);
            break;
          }
          case 1346: {
            if (addMiracleList_ == null) {
              AddMiracleList = new global::EggLink.DanhengServer.Proto.RogueMiracleData();
            }
            input.ReadMessage(AddMiracleList);
            break;
          }
          case 2554: {
            if (addBuffList_ == null) {
              AddBuffList = new global::EggLink.DanhengServer.Proto.RogueBuffData();
            }
            input.ReadMessage(AddBuffList);
            break;
          }
          case 3514: {
            if (removeBuffList_ == null) {
              RemoveBuffList = new global::EggLink.DanhengServer.Proto.RogueBuffData();
            }
            input.ReadMessage(RemoveBuffList);
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
