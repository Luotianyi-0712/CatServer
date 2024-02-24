// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PromoteEquipmentCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PromoteEquipmentCsReq.proto</summary>
  public static partial class PromoteEquipmentCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PromoteEquipmentCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PromoteEquipmentCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQcm9tb3RlRXF1aXBtZW50Q3NSZXEucHJvdG8aEkl0ZW1Db3N0TGlzdC5w",
            "cm90byJbChVQcm9tb3RlRXF1aXBtZW50Q3NSZXESJQoOaXRlbV9jb3N0X2xp",
            "c3QYDCABKAsyDS5JdGVtQ29zdExpc3QSGwoTZXF1aXBtZW50X3VuaXF1ZV9p",
            "ZBgNIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PromoteEquipmentCsReq), global::EggLink.DanhengServer.Proto.PromoteEquipmentCsReq.Parser, new[]{ "ItemCostList", "EquipmentUniqueId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PromoteEquipmentCsReq : pb::IMessage<PromoteEquipmentCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PromoteEquipmentCsReq> _parser = new pb::MessageParser<PromoteEquipmentCsReq>(() => new PromoteEquipmentCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PromoteEquipmentCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PromoteEquipmentCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromoteEquipmentCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromoteEquipmentCsReq(PromoteEquipmentCsReq other) : this() {
      itemCostList_ = other.itemCostList_ != null ? other.itemCostList_.Clone() : null;
      equipmentUniqueId_ = other.equipmentUniqueId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PromoteEquipmentCsReq Clone() {
      return new PromoteEquipmentCsReq(this);
    }

    /// <summary>Field number for the "item_cost_list" field.</summary>
    public const int ItemCostListFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ItemCostList itemCostList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostList ItemCostList {
      get { return itemCostList_; }
      set {
        itemCostList_ = value;
      }
    }

    /// <summary>Field number for the "equipment_unique_id" field.</summary>
    public const int EquipmentUniqueIdFieldNumber = 13;
    private uint equipmentUniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EquipmentUniqueId {
      get { return equipmentUniqueId_; }
      set {
        equipmentUniqueId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PromoteEquipmentCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PromoteEquipmentCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ItemCostList, other.ItemCostList)) return false;
      if (EquipmentUniqueId != other.EquipmentUniqueId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (itemCostList_ != null) hash ^= ItemCostList.GetHashCode();
      if (EquipmentUniqueId != 0) hash ^= EquipmentUniqueId.GetHashCode();
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
      if (itemCostList_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ItemCostList);
      }
      if (EquipmentUniqueId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EquipmentUniqueId);
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
      if (itemCostList_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ItemCostList);
      }
      if (EquipmentUniqueId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EquipmentUniqueId);
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
      if (itemCostList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ItemCostList);
      }
      if (EquipmentUniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EquipmentUniqueId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PromoteEquipmentCsReq other) {
      if (other == null) {
        return;
      }
      if (other.itemCostList_ != null) {
        if (itemCostList_ == null) {
          ItemCostList = new global::EggLink.DanhengServer.Proto.ItemCostList();
        }
        ItemCostList.MergeFrom(other.ItemCostList);
      }
      if (other.EquipmentUniqueId != 0) {
        EquipmentUniqueId = other.EquipmentUniqueId;
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
          case 98: {
            if (itemCostList_ == null) {
              ItemCostList = new global::EggLink.DanhengServer.Proto.ItemCostList();
            }
            input.ReadMessage(ItemCostList);
            break;
          }
          case 104: {
            EquipmentUniqueId = input.ReadUInt32();
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
          case 98: {
            if (itemCostList_ == null) {
              ItemCostList = new global::EggLink.DanhengServer.Proto.ItemCostList();
            }
            input.ReadMessage(ItemCostList);
            break;
          }
          case 104: {
            EquipmentUniqueId = input.ReadUInt32();
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
