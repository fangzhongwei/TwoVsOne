// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: src/depositrecordresp.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from src/depositrecordresp.proto</summary>
public static partial class DepositrecordrespReflection {

  #region Descriptor
  /// <summary>File descriptor for src/depositrecordresp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DepositrecordrespReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtzcmMvZGVwb3NpdHJlY29yZHJlc3AucHJvdG8imwIKEURlcG9zaXRSZWNv",
          "cmRSZXNwEgwKBGNvZGUYASABKAkSGAoQcGF5bWVudFZvdWNoZXJObxgCIAEo",
          "CRIRCglhY2NvdW50SWQYAyABKAMSEAoIbWVtYmVySWQYBCABKAMSEQoJdHJh",
          "ZGVUeXBlGAUgASgFEhMKC3RyYWRlU3RhdHVzGAYgASgFEhUKDWRpYW1vbmRB",
          "Y291bnQYByABKAUSDgoGYW1vdW50GAggASgJEhEKCWdtdENyZWF0ZRgJIAEo",
          "CRIRCglnbXRVcGRhdGUYCiABKAkSDAoEZXh0MRgLIAEoCRIMCgRleHQyGAwg",
          "ASgJEgwKBGV4dDMYDSABKAkSDAoEZXh0NBgOIAEoCRIMCgRleHQ1GA8gASgJ",
          "Qi4KLGNvbS5sYXdzb2ZuYXR1cmUuYXBpZ2F0ZXdheS5kb21haW4uaHR0cC5y",
          "ZXNwYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DepositRecordResp), global::DepositRecordResp.Parser, new[]{ "Code", "PaymentVoucherNo", "AccountId", "MemberId", "TradeType", "TradeStatus", "DiamondAcount", "Amount", "GmtCreate", "GmtUpdate", "Ext1", "Ext2", "Ext3", "Ext4", "Ext5" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class DepositRecordResp : pb::IMessage<DepositRecordResp> {
  private static readonly pb::MessageParser<DepositRecordResp> _parser = new pb::MessageParser<DepositRecordResp>(() => new DepositRecordResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<DepositRecordResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DepositrecordrespReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DepositRecordResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DepositRecordResp(DepositRecordResp other) : this() {
    code_ = other.code_;
    paymentVoucherNo_ = other.paymentVoucherNo_;
    accountId_ = other.accountId_;
    memberId_ = other.memberId_;
    tradeType_ = other.tradeType_;
    tradeStatus_ = other.tradeStatus_;
    diamondAcount_ = other.diamondAcount_;
    amount_ = other.amount_;
    gmtCreate_ = other.gmtCreate_;
    gmtUpdate_ = other.gmtUpdate_;
    ext1_ = other.ext1_;
    ext2_ = other.ext2_;
    ext3_ = other.ext3_;
    ext4_ = other.ext4_;
    ext5_ = other.ext5_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DepositRecordResp Clone() {
    return new DepositRecordResp(this);
  }

  /// <summary>Field number for the "code" field.</summary>
  public const int CodeFieldNumber = 1;
  private string code_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Code {
    get { return code_; }
    set {
      code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "paymentVoucherNo" field.</summary>
  public const int PaymentVoucherNoFieldNumber = 2;
  private string paymentVoucherNo_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string PaymentVoucherNo {
    get { return paymentVoucherNo_; }
    set {
      paymentVoucherNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "accountId" field.</summary>
  public const int AccountIdFieldNumber = 3;
  private long accountId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long AccountId {
    get { return accountId_; }
    set {
      accountId_ = value;
    }
  }

  /// <summary>Field number for the "memberId" field.</summary>
  public const int MemberIdFieldNumber = 4;
  private long memberId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long MemberId {
    get { return memberId_; }
    set {
      memberId_ = value;
    }
  }

  /// <summary>Field number for the "tradeType" field.</summary>
  public const int TradeTypeFieldNumber = 5;
  private int tradeType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int TradeType {
    get { return tradeType_; }
    set {
      tradeType_ = value;
    }
  }

  /// <summary>Field number for the "tradeStatus" field.</summary>
  public const int TradeStatusFieldNumber = 6;
  private int tradeStatus_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int TradeStatus {
    get { return tradeStatus_; }
    set {
      tradeStatus_ = value;
    }
  }

  /// <summary>Field number for the "diamondAcount" field.</summary>
  public const int DiamondAcountFieldNumber = 7;
  private int diamondAcount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int DiamondAcount {
    get { return diamondAcount_; }
    set {
      diamondAcount_ = value;
    }
  }

  /// <summary>Field number for the "amount" field.</summary>
  public const int AmountFieldNumber = 8;
  private string amount_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Amount {
    get { return amount_; }
    set {
      amount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "gmtCreate" field.</summary>
  public const int GmtCreateFieldNumber = 9;
  private string gmtCreate_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string GmtCreate {
    get { return gmtCreate_; }
    set {
      gmtCreate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "gmtUpdate" field.</summary>
  public const int GmtUpdateFieldNumber = 10;
  private string gmtUpdate_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string GmtUpdate {
    get { return gmtUpdate_; }
    set {
      gmtUpdate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext1" field.</summary>
  public const int Ext1FieldNumber = 11;
  private string ext1_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext1 {
    get { return ext1_; }
    set {
      ext1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext2" field.</summary>
  public const int Ext2FieldNumber = 12;
  private string ext2_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext2 {
    get { return ext2_; }
    set {
      ext2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext3" field.</summary>
  public const int Ext3FieldNumber = 13;
  private string ext3_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext3 {
    get { return ext3_; }
    set {
      ext3_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext4" field.</summary>
  public const int Ext4FieldNumber = 14;
  private string ext4_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext4 {
    get { return ext4_; }
    set {
      ext4_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext5" field.</summary>
  public const int Ext5FieldNumber = 15;
  private string ext5_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext5 {
    get { return ext5_; }
    set {
      ext5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as DepositRecordResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(DepositRecordResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Code != other.Code) return false;
    if (PaymentVoucherNo != other.PaymentVoucherNo) return false;
    if (AccountId != other.AccountId) return false;
    if (MemberId != other.MemberId) return false;
    if (TradeType != other.TradeType) return false;
    if (TradeStatus != other.TradeStatus) return false;
    if (DiamondAcount != other.DiamondAcount) return false;
    if (Amount != other.Amount) return false;
    if (GmtCreate != other.GmtCreate) return false;
    if (GmtUpdate != other.GmtUpdate) return false;
    if (Ext1 != other.Ext1) return false;
    if (Ext2 != other.Ext2) return false;
    if (Ext3 != other.Ext3) return false;
    if (Ext4 != other.Ext4) return false;
    if (Ext5 != other.Ext5) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Code.Length != 0) hash ^= Code.GetHashCode();
    if (PaymentVoucherNo.Length != 0) hash ^= PaymentVoucherNo.GetHashCode();
    if (AccountId != 0L) hash ^= AccountId.GetHashCode();
    if (MemberId != 0L) hash ^= MemberId.GetHashCode();
    if (TradeType != 0) hash ^= TradeType.GetHashCode();
    if (TradeStatus != 0) hash ^= TradeStatus.GetHashCode();
    if (DiamondAcount != 0) hash ^= DiamondAcount.GetHashCode();
    if (Amount.Length != 0) hash ^= Amount.GetHashCode();
    if (GmtCreate.Length != 0) hash ^= GmtCreate.GetHashCode();
    if (GmtUpdate.Length != 0) hash ^= GmtUpdate.GetHashCode();
    if (Ext1.Length != 0) hash ^= Ext1.GetHashCode();
    if (Ext2.Length != 0) hash ^= Ext2.GetHashCode();
    if (Ext3.Length != 0) hash ^= Ext3.GetHashCode();
    if (Ext4.Length != 0) hash ^= Ext4.GetHashCode();
    if (Ext5.Length != 0) hash ^= Ext5.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Code.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Code);
    }
    if (PaymentVoucherNo.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(PaymentVoucherNo);
    }
    if (AccountId != 0L) {
      output.WriteRawTag(24);
      output.WriteInt64(AccountId);
    }
    if (MemberId != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(MemberId);
    }
    if (TradeType != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(TradeType);
    }
    if (TradeStatus != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(TradeStatus);
    }
    if (DiamondAcount != 0) {
      output.WriteRawTag(56);
      output.WriteInt32(DiamondAcount);
    }
    if (Amount.Length != 0) {
      output.WriteRawTag(66);
      output.WriteString(Amount);
    }
    if (GmtCreate.Length != 0) {
      output.WriteRawTag(74);
      output.WriteString(GmtCreate);
    }
    if (GmtUpdate.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(GmtUpdate);
    }
    if (Ext1.Length != 0) {
      output.WriteRawTag(90);
      output.WriteString(Ext1);
    }
    if (Ext2.Length != 0) {
      output.WriteRawTag(98);
      output.WriteString(Ext2);
    }
    if (Ext3.Length != 0) {
      output.WriteRawTag(106);
      output.WriteString(Ext3);
    }
    if (Ext4.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(Ext4);
    }
    if (Ext5.Length != 0) {
      output.WriteRawTag(122);
      output.WriteString(Ext5);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Code.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
    }
    if (PaymentVoucherNo.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentVoucherNo);
    }
    if (AccountId != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(AccountId);
    }
    if (MemberId != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(MemberId);
    }
    if (TradeType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(TradeType);
    }
    if (TradeStatus != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(TradeStatus);
    }
    if (DiamondAcount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(DiamondAcount);
    }
    if (Amount.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Amount);
    }
    if (GmtCreate.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(GmtCreate);
    }
    if (GmtUpdate.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(GmtUpdate);
    }
    if (Ext1.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ext1);
    }
    if (Ext2.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ext2);
    }
    if (Ext3.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ext3);
    }
    if (Ext4.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ext4);
    }
    if (Ext5.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Ext5);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(DepositRecordResp other) {
    if (other == null) {
      return;
    }
    if (other.Code.Length != 0) {
      Code = other.Code;
    }
    if (other.PaymentVoucherNo.Length != 0) {
      PaymentVoucherNo = other.PaymentVoucherNo;
    }
    if (other.AccountId != 0L) {
      AccountId = other.AccountId;
    }
    if (other.MemberId != 0L) {
      MemberId = other.MemberId;
    }
    if (other.TradeType != 0) {
      TradeType = other.TradeType;
    }
    if (other.TradeStatus != 0) {
      TradeStatus = other.TradeStatus;
    }
    if (other.DiamondAcount != 0) {
      DiamondAcount = other.DiamondAcount;
    }
    if (other.Amount.Length != 0) {
      Amount = other.Amount;
    }
    if (other.GmtCreate.Length != 0) {
      GmtCreate = other.GmtCreate;
    }
    if (other.GmtUpdate.Length != 0) {
      GmtUpdate = other.GmtUpdate;
    }
    if (other.Ext1.Length != 0) {
      Ext1 = other.Ext1;
    }
    if (other.Ext2.Length != 0) {
      Ext2 = other.Ext2;
    }
    if (other.Ext3.Length != 0) {
      Ext3 = other.Ext3;
    }
    if (other.Ext4.Length != 0) {
      Ext4 = other.Ext4;
    }
    if (other.Ext5.Length != 0) {
      Ext5 = other.Ext5;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Code = input.ReadString();
          break;
        }
        case 18: {
          PaymentVoucherNo = input.ReadString();
          break;
        }
        case 24: {
          AccountId = input.ReadInt64();
          break;
        }
        case 32: {
          MemberId = input.ReadInt64();
          break;
        }
        case 40: {
          TradeType = input.ReadInt32();
          break;
        }
        case 48: {
          TradeStatus = input.ReadInt32();
          break;
        }
        case 56: {
          DiamondAcount = input.ReadInt32();
          break;
        }
        case 66: {
          Amount = input.ReadString();
          break;
        }
        case 74: {
          GmtCreate = input.ReadString();
          break;
        }
        case 82: {
          GmtUpdate = input.ReadString();
          break;
        }
        case 90: {
          Ext1 = input.ReadString();
          break;
        }
        case 98: {
          Ext2 = input.ReadString();
          break;
        }
        case 106: {
          Ext3 = input.ReadString();
          break;
        }
        case 114: {
          Ext4 = input.ReadString();
          break;
        }
        case 122: {
          Ext5 = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
