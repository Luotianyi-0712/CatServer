// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueCommonActionResultData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueCommonActionResultData.proto</summary>
  public static partial class RogueCommonActionResultDataReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueCommonActionResultData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueCommonActionResultDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSb2d1ZUNvbW1vbkFjdGlvblJlc3VsdERhdGEucHJvdG8aEUlGRkxOR01O",
            "RkNKLnByb3RvGhFPRkdHQ0pCSU9NSS5wcm90bxoRQ05PTkVQQkZKS04ucHJv",
            "dG8aFVJvZ3VlQ29tbW9uQnVmZi5wcm90bxoYUm9ndWVDb21tb25NaXJhY2xl",
            "LnByb3RvGhFMQU9PR0RIUENDTS5wcm90bxoRQUxNSlBBTktORU0ucHJvdG8a",
            "EUJMTk9ISklOQ0hELnByb3RvGhZSb2d1ZUNvbW1vbk1vbmV5LnByb3RvItMD",
            "ChtSb2d1ZUNvbW1vbkFjdGlvblJlc3VsdERhdGESKAoNZ2V0X2l0ZW1fbGlz",
            "dBgNIAEoCzIRLlJvZ3VlQ29tbW9uTW9uZXkSKwoQcmVtb3ZlX2l0ZW1fbGlz",
            "dBgMIAEoCzIRLlJvZ3VlQ29tbW9uTW9uZXkSKAoNZ2V0X2J1ZmZfbGlzdBiv",
            "DCABKAsyEC5Sb2d1ZUNvbW1vbkJ1ZmYSKwoQcmVtb3ZlX2J1ZmZfbGlzdBiy",
            "BiABKAsyEC5Sb2d1ZUNvbW1vbkJ1ZmYSLgoQZ2V0X21pcmFjbGVfbGlzdBiq",
            "CSABKAsyEy5Sb2d1ZUNvbW1vbk1pcmFjbGUSIgoLSE5HTFBJSkdEQUQYtgcg",
            "ASgLMgwuQUxNSlBBTktORU0SIgoLSUlOSE1OR0dNT0UYogogASgLMgwuQ05P",
            "TkVQQkZKS04SIgoLRkdOQ0RQRkFJRk0YpgkgASgLMgwuSUZGTE5HTU5GQ0oS",
            "IgoLREpQRkRQUE1PTUMYlgkgASgLMgwuT0ZHR0NKQklPTUkSIgoLQ0RPRktO",
            "UEdJTUQYlwQgASgLMgwuTEFPT0dESFBDQ00SIgoLRUhGTlBQTkpITk4Y+wcg",
            "ASgLMgwuQkxOT0hKSU5DSERCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.IFFLNGMNFCJReflection.Descriptor, global::EggLink.DanhengServer.Proto.OFGGCJBIOMIReflection.Descriptor, global::EggLink.DanhengServer.Proto.CNONEPBFJKNReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonBuffReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonMiracleReflection.Descriptor, global::EggLink.DanhengServer.Proto.LAOOGDHPCCMReflection.Descriptor, global::EggLink.DanhengServer.Proto.ALMJPANKNEMReflection.Descriptor, global::EggLink.DanhengServer.Proto.BLNOHJINCHDReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueCommonMoneyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueCommonActionResultData), global::EggLink.DanhengServer.Proto.RogueCommonActionResultData.Parser, new[]{ "GetItemList", "RemoveItemList", "GetBuffList", "RemoveBuffList", "GetMiracleList", "HNGLPIJGDAD", "IINHMNGGMOE", "FGNCDPFAIFM", "DJPFDPPMOMC", "CDOFKNPGIMD", "EHFNPPNJHNN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueCommonActionResultData : pb::IMessage<RogueCommonActionResultData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueCommonActionResultData> _parser = new pb::MessageParser<RogueCommonActionResultData>(() => new RogueCommonActionResultData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueCommonActionResultData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueCommonActionResultDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonActionResultData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonActionResultData(RogueCommonActionResultData other) : this() {
      getItemList_ = other.getItemList_ != null ? other.getItemList_.Clone() : null;
      removeItemList_ = other.removeItemList_ != null ? other.removeItemList_.Clone() : null;
      getBuffList_ = other.getBuffList_ != null ? other.getBuffList_.Clone() : null;
      removeBuffList_ = other.removeBuffList_ != null ? other.removeBuffList_.Clone() : null;
      getMiracleList_ = other.getMiracleList_ != null ? other.getMiracleList_.Clone() : null;
      hNGLPIJGDAD_ = other.hNGLPIJGDAD_ != null ? other.hNGLPIJGDAD_.Clone() : null;
      iINHMNGGMOE_ = other.iINHMNGGMOE_ != null ? other.iINHMNGGMOE_.Clone() : null;
      fGNCDPFAIFM_ = other.fGNCDPFAIFM_ != null ? other.fGNCDPFAIFM_.Clone() : null;
      dJPFDPPMOMC_ = other.dJPFDPPMOMC_ != null ? other.dJPFDPPMOMC_.Clone() : null;
      cDOFKNPGIMD_ = other.cDOFKNPGIMD_ != null ? other.cDOFKNPGIMD_.Clone() : null;
      eHFNPPNJHNN_ = other.eHFNPPNJHNN_ != null ? other.eHFNPPNJHNN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueCommonActionResultData Clone() {
      return new RogueCommonActionResultData(this);
    }

    /// <summary>Field number for the "get_item_list" field.</summary>
    public const int GetItemListFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueCommonMoney getItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonMoney GetItemList {
      get { return getItemList_; }
      set {
        getItemList_ = value;
      }
    }

    /// <summary>Field number for the "remove_item_list" field.</summary>
    public const int RemoveItemListFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.RogueCommonMoney removeItemList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonMoney RemoveItemList {
      get { return removeItemList_; }
      set {
        removeItemList_ = value;
      }
    }

    /// <summary>Field number for the "get_buff_list" field.</summary>
    public const int GetBuffListFieldNumber = 1583;
    private global::EggLink.DanhengServer.Proto.RogueCommonBuff getBuffList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonBuff GetBuffList {
      get { return getBuffList_; }
      set {
        getBuffList_ = value;
      }
    }

    /// <summary>Field number for the "remove_buff_list" field.</summary>
    public const int RemoveBuffListFieldNumber = 818;
    private global::EggLink.DanhengServer.Proto.RogueCommonBuff removeBuffList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonBuff RemoveBuffList {
      get { return removeBuffList_; }
      set {
        removeBuffList_ = value;
      }
    }

    /// <summary>Field number for the "get_miracle_list" field.</summary>
    public const int GetMiracleListFieldNumber = 1194;
    private global::EggLink.DanhengServer.Proto.RogueCommonMiracle getMiracleList_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueCommonMiracle GetMiracleList {
      get { return getMiracleList_; }
      set {
        getMiracleList_ = value;
      }
    }

    /// <summary>Field number for the "HNGLPIJGDAD" field.</summary>
    public const int HNGLPIJGDADFieldNumber = 950;
    private global::EggLink.DanhengServer.Proto.ALMJPANKNEM hNGLPIJGDAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ALMJPANKNEM HNGLPIJGDAD {
      get { return hNGLPIJGDAD_; }
      set {
        hNGLPIJGDAD_ = value;
      }
    }

    /// <summary>Field number for the "IINHMNGGMOE" field.</summary>
    public const int IINHMNGGMOEFieldNumber = 1314;
    private global::EggLink.DanhengServer.Proto.CNONEPBFJKN iINHMNGGMOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CNONEPBFJKN IINHMNGGMOE {
      get { return iINHMNGGMOE_; }
      set {
        iINHMNGGMOE_ = value;
      }
    }

    /// <summary>Field number for the "FGNCDPFAIFM" field.</summary>
    public const int FGNCDPFAIFMFieldNumber = 1190;
    private global::EggLink.DanhengServer.Proto.IFFLNGMNFCJ fGNCDPFAIFM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IFFLNGMNFCJ FGNCDPFAIFM {
      get { return fGNCDPFAIFM_; }
      set {
        fGNCDPFAIFM_ = value;
      }
    }

    /// <summary>Field number for the "DJPFDPPMOMC" field.</summary>
    public const int DJPFDPPMOMCFieldNumber = 1174;
    private global::EggLink.DanhengServer.Proto.OFGGCJBIOMI dJPFDPPMOMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OFGGCJBIOMI DJPFDPPMOMC {
      get { return dJPFDPPMOMC_; }
      set {
        dJPFDPPMOMC_ = value;
      }
    }

    /// <summary>Field number for the "CDOFKNPGIMD" field.</summary>
    public const int CDOFKNPGIMDFieldNumber = 535;
    private global::EggLink.DanhengServer.Proto.LAOOGDHPCCM cDOFKNPGIMD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LAOOGDHPCCM CDOFKNPGIMD {
      get { return cDOFKNPGIMD_; }
      set {
        cDOFKNPGIMD_ = value;
      }
    }

    /// <summary>Field number for the "EHFNPPNJHNN" field.</summary>
    public const int EHFNPPNJHNNFieldNumber = 1019;
    private global::EggLink.DanhengServer.Proto.BLNOHJINCHD eHFNPPNJHNN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BLNOHJINCHD EHFNPPNJHNN {
      get { return eHFNPPNJHNN_; }
      set {
        eHFNPPNJHNN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueCommonActionResultData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueCommonActionResultData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GetItemList, other.GetItemList)) return false;
      if (!object.Equals(RemoveItemList, other.RemoveItemList)) return false;
      if (!object.Equals(GetBuffList, other.GetBuffList)) return false;
      if (!object.Equals(RemoveBuffList, other.RemoveBuffList)) return false;
      if (!object.Equals(GetMiracleList, other.GetMiracleList)) return false;
      if (!object.Equals(HNGLPIJGDAD, other.HNGLPIJGDAD)) return false;
      if (!object.Equals(IINHMNGGMOE, other.IINHMNGGMOE)) return false;
      if (!object.Equals(FGNCDPFAIFM, other.FGNCDPFAIFM)) return false;
      if (!object.Equals(DJPFDPPMOMC, other.DJPFDPPMOMC)) return false;
      if (!object.Equals(CDOFKNPGIMD, other.CDOFKNPGIMD)) return false;
      if (!object.Equals(EHFNPPNJHNN, other.EHFNPPNJHNN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (getItemList_ != null) hash ^= GetItemList.GetHashCode();
      if (removeItemList_ != null) hash ^= RemoveItemList.GetHashCode();
      if (getBuffList_ != null) hash ^= GetBuffList.GetHashCode();
      if (removeBuffList_ != null) hash ^= RemoveBuffList.GetHashCode();
      if (getMiracleList_ != null) hash ^= GetMiracleList.GetHashCode();
      if (hNGLPIJGDAD_ != null) hash ^= HNGLPIJGDAD.GetHashCode();
      if (iINHMNGGMOE_ != null) hash ^= IINHMNGGMOE.GetHashCode();
      if (fGNCDPFAIFM_ != null) hash ^= FGNCDPFAIFM.GetHashCode();
      if (dJPFDPPMOMC_ != null) hash ^= DJPFDPPMOMC.GetHashCode();
      if (cDOFKNPGIMD_ != null) hash ^= CDOFKNPGIMD.GetHashCode();
      if (eHFNPPNJHNN_ != null) hash ^= EHFNPPNJHNN.GetHashCode();
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
        output.WriteRawTag(98);
        output.WriteMessage(RemoveItemList);
      }
      if (getItemList_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(GetItemList);
      }
      if (cDOFKNPGIMD_ != null) {
        output.WriteRawTag(186, 33);
        output.WriteMessage(CDOFKNPGIMD);
      }
      if (removeBuffList_ != null) {
        output.WriteRawTag(146, 51);
        output.WriteMessage(RemoveBuffList);
      }
      if (hNGLPIJGDAD_ != null) {
        output.WriteRawTag(178, 59);
        output.WriteMessage(HNGLPIJGDAD);
      }
      if (eHFNPPNJHNN_ != null) {
        output.WriteRawTag(218, 63);
        output.WriteMessage(EHFNPPNJHNN);
      }
      if (dJPFDPPMOMC_ != null) {
        output.WriteRawTag(178, 73);
        output.WriteMessage(DJPFDPPMOMC);
      }
      if (fGNCDPFAIFM_ != null) {
        output.WriteRawTag(178, 74);
        output.WriteMessage(FGNCDPFAIFM);
      }
      if (getMiracleList_ != null) {
        output.WriteRawTag(210, 74);
        output.WriteMessage(GetMiracleList);
      }
      if (iINHMNGGMOE_ != null) {
        output.WriteRawTag(146, 82);
        output.WriteMessage(IINHMNGGMOE);
      }
      if (getBuffList_ != null) {
        output.WriteRawTag(250, 98);
        output.WriteMessage(GetBuffList);
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
        output.WriteRawTag(98);
        output.WriteMessage(RemoveItemList);
      }
      if (getItemList_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(GetItemList);
      }
      if (cDOFKNPGIMD_ != null) {
        output.WriteRawTag(186, 33);
        output.WriteMessage(CDOFKNPGIMD);
      }
      if (removeBuffList_ != null) {
        output.WriteRawTag(146, 51);
        output.WriteMessage(RemoveBuffList);
      }
      if (hNGLPIJGDAD_ != null) {
        output.WriteRawTag(178, 59);
        output.WriteMessage(HNGLPIJGDAD);
      }
      if (eHFNPPNJHNN_ != null) {
        output.WriteRawTag(218, 63);
        output.WriteMessage(EHFNPPNJHNN);
      }
      if (dJPFDPPMOMC_ != null) {
        output.WriteRawTag(178, 73);
        output.WriteMessage(DJPFDPPMOMC);
      }
      if (fGNCDPFAIFM_ != null) {
        output.WriteRawTag(178, 74);
        output.WriteMessage(FGNCDPFAIFM);
      }
      if (getMiracleList_ != null) {
        output.WriteRawTag(210, 74);
        output.WriteMessage(GetMiracleList);
      }
      if (iINHMNGGMOE_ != null) {
        output.WriteRawTag(146, 82);
        output.WriteMessage(IINHMNGGMOE);
      }
      if (getBuffList_ != null) {
        output.WriteRawTag(250, 98);
        output.WriteMessage(GetBuffList);
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
      if (getItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GetItemList);
      }
      if (removeItemList_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RemoveItemList);
      }
      if (getBuffList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GetBuffList);
      }
      if (removeBuffList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RemoveBuffList);
      }
      if (getMiracleList_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(GetMiracleList);
      }
      if (hNGLPIJGDAD_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(HNGLPIJGDAD);
      }
      if (iINHMNGGMOE_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IINHMNGGMOE);
      }
      if (fGNCDPFAIFM_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(FGNCDPFAIFM);
      }
      if (dJPFDPPMOMC_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DJPFDPPMOMC);
      }
      if (cDOFKNPGIMD_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(CDOFKNPGIMD);
      }
      if (eHFNPPNJHNN_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EHFNPPNJHNN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueCommonActionResultData other) {
      if (other == null) {
        return;
      }
      if (other.getItemList_ != null) {
        if (getItemList_ == null) {
          GetItemList = new global::EggLink.DanhengServer.Proto.RogueCommonMoney();
        }
        GetItemList.MergeFrom(other.GetItemList);
      }
      if (other.removeItemList_ != null) {
        if (removeItemList_ == null) {
          RemoveItemList = new global::EggLink.DanhengServer.Proto.RogueCommonMoney();
        }
        RemoveItemList.MergeFrom(other.RemoveItemList);
      }
      if (other.getBuffList_ != null) {
        if (getBuffList_ == null) {
          GetBuffList = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
        }
        GetBuffList.MergeFrom(other.GetBuffList);
      }
      if (other.removeBuffList_ != null) {
        if (removeBuffList_ == null) {
          RemoveBuffList = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
        }
        RemoveBuffList.MergeFrom(other.RemoveBuffList);
      }
      if (other.getMiracleList_ != null) {
        if (getMiracleList_ == null) {
          GetMiracleList = new global::EggLink.DanhengServer.Proto.RogueCommonMiracle();
        }
        GetMiracleList.MergeFrom(other.GetMiracleList);
      }
      if (other.hNGLPIJGDAD_ != null) {
        if (hNGLPIJGDAD_ == null) {
          HNGLPIJGDAD = new global::EggLink.DanhengServer.Proto.ALMJPANKNEM();
        }
        HNGLPIJGDAD.MergeFrom(other.HNGLPIJGDAD);
      }
      if (other.iINHMNGGMOE_ != null) {
        if (iINHMNGGMOE_ == null) {
          IINHMNGGMOE = new global::EggLink.DanhengServer.Proto.CNONEPBFJKN();
        }
        IINHMNGGMOE.MergeFrom(other.IINHMNGGMOE);
      }
      if (other.fGNCDPFAIFM_ != null) {
        if (fGNCDPFAIFM_ == null) {
          FGNCDPFAIFM = new global::EggLink.DanhengServer.Proto.IFFLNGMNFCJ();
        }
        FGNCDPFAIFM.MergeFrom(other.FGNCDPFAIFM);
      }
      if (other.dJPFDPPMOMC_ != null) {
        if (dJPFDPPMOMC_ == null) {
          DJPFDPPMOMC = new global::EggLink.DanhengServer.Proto.OFGGCJBIOMI();
        }
        DJPFDPPMOMC.MergeFrom(other.DJPFDPPMOMC);
      }
      if (other.cDOFKNPGIMD_ != null) {
        if (cDOFKNPGIMD_ == null) {
          CDOFKNPGIMD = new global::EggLink.DanhengServer.Proto.LAOOGDHPCCM();
        }
        CDOFKNPGIMD.MergeFrom(other.CDOFKNPGIMD);
      }
      if (other.eHFNPPNJHNN_ != null) {
        if (eHFNPPNJHNN_ == null) {
          EHFNPPNJHNN = new global::EggLink.DanhengServer.Proto.BLNOHJINCHD();
        }
        EHFNPPNJHNN.MergeFrom(other.EHFNPPNJHNN);
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
            if (removeItemList_ == null) {
              RemoveItemList = new global::EggLink.DanhengServer.Proto.RogueCommonMoney();
            }
            input.ReadMessage(RemoveItemList);
            break;
          }
          case 106: {
            if (getItemList_ == null) {
              GetItemList = new global::EggLink.DanhengServer.Proto.RogueCommonMoney();
            }
            input.ReadMessage(GetItemList);
            break;
          }
          case 4282: {
            if (cDOFKNPGIMD_ == null) {
              CDOFKNPGIMD = new global::EggLink.DanhengServer.Proto.LAOOGDHPCCM();
            }
            input.ReadMessage(CDOFKNPGIMD);
            break;
          }
          case 6546: {
            if (removeBuffList_ == null) {
              RemoveBuffList = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
            }
            input.ReadMessage(RemoveBuffList);
            break;
          }
          case 7602: {
            if (hNGLPIJGDAD_ == null) {
              HNGLPIJGDAD = new global::EggLink.DanhengServer.Proto.ALMJPANKNEM();
            }
            input.ReadMessage(HNGLPIJGDAD);
            break;
          }
          case 8154: {
            if (eHFNPPNJHNN_ == null) {
              EHFNPPNJHNN = new global::EggLink.DanhengServer.Proto.BLNOHJINCHD();
            }
            input.ReadMessage(EHFNPPNJHNN);
            break;
          }
          case 9394: {
            if (dJPFDPPMOMC_ == null) {
              DJPFDPPMOMC = new global::EggLink.DanhengServer.Proto.OFGGCJBIOMI();
            }
            input.ReadMessage(DJPFDPPMOMC);
            break;
          }
          case 9522: {
            if (fGNCDPFAIFM_ == null) {
              FGNCDPFAIFM = new global::EggLink.DanhengServer.Proto.IFFLNGMNFCJ();
            }
            input.ReadMessage(FGNCDPFAIFM);
            break;
          }
          case 9554: {
            if (getMiracleList_ == null) {
              GetMiracleList = new global::EggLink.DanhengServer.Proto.RogueCommonMiracle();
            }
            input.ReadMessage(GetMiracleList);
            break;
          }
          case 10514: {
            if (iINHMNGGMOE_ == null) {
              IINHMNGGMOE = new global::EggLink.DanhengServer.Proto.CNONEPBFJKN();
            }
            input.ReadMessage(IINHMNGGMOE);
            break;
          }
          case 12666: {
            if (getBuffList_ == null) {
              GetBuffList = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
            }
            input.ReadMessage(GetBuffList);
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
            if (removeItemList_ == null) {
              RemoveItemList = new global::EggLink.DanhengServer.Proto.RogueCommonMoney();
            }
            input.ReadMessage(RemoveItemList);
            break;
          }
          case 106: {
            if (getItemList_ == null) {
              GetItemList = new global::EggLink.DanhengServer.Proto.RogueCommonMoney();
            }
            input.ReadMessage(GetItemList);
            break;
          }
          case 4282: {
            if (cDOFKNPGIMD_ == null) {
              CDOFKNPGIMD = new global::EggLink.DanhengServer.Proto.LAOOGDHPCCM();
            }
            input.ReadMessage(CDOFKNPGIMD);
            break;
          }
          case 6546: {
            if (removeBuffList_ == null) {
              RemoveBuffList = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
            }
            input.ReadMessage(RemoveBuffList);
            break;
          }
          case 7602: {
            if (hNGLPIJGDAD_ == null) {
              HNGLPIJGDAD = new global::EggLink.DanhengServer.Proto.ALMJPANKNEM();
            }
            input.ReadMessage(HNGLPIJGDAD);
            break;
          }
          case 8154: {
            if (eHFNPPNJHNN_ == null) {
              EHFNPPNJHNN = new global::EggLink.DanhengServer.Proto.BLNOHJINCHD();
            }
            input.ReadMessage(EHFNPPNJHNN);
            break;
          }
          case 9394: {
            if (dJPFDPPMOMC_ == null) {
              DJPFDPPMOMC = new global::EggLink.DanhengServer.Proto.OFGGCJBIOMI();
            }
            input.ReadMessage(DJPFDPPMOMC);
            break;
          }
          case 9522: {
            if (fGNCDPFAIFM_ == null) {
              FGNCDPFAIFM = new global::EggLink.DanhengServer.Proto.IFFLNGMNFCJ();
            }
            input.ReadMessage(FGNCDPFAIFM);
            break;
          }
          case 9554: {
            if (getMiracleList_ == null) {
              GetMiracleList = new global::EggLink.DanhengServer.Proto.RogueCommonMiracle();
            }
            input.ReadMessage(GetMiracleList);
            break;
          }
          case 10514: {
            if (iINHMNGGMOE_ == null) {
              IINHMNGGMOE = new global::EggLink.DanhengServer.Proto.CNONEPBFJKN();
            }
            input.ReadMessage(IINHMNGGMOE);
            break;
          }
          case 12666: {
            if (getBuffList_ == null) {
              GetBuffList = new global::EggLink.DanhengServer.Proto.RogueCommonBuff();
            }
            input.ReadMessage(GetBuffList);
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
