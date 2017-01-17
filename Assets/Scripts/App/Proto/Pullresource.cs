// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: src/pullresource.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from src/pullresource.proto</summary>
public static partial class PullresourceReflection {

  #region Descriptor
  /// <summary>File descriptor for src/pullresource.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PullresourceReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZzcmMvcHVsbHJlc291cmNlLnByb3RvInUKD1B1bGxSZXNvdXJjZVJlcRIP",
          "Cgd2ZXJzaW9uGAEgASgFEgsKA2xhbhgCIAEoCRIMCgRleHQxGAMgASgJEgwK",
          "BGV4dDIYBCABKAkSDAoEZXh0MxgFIAEoCRIMCgRleHQ0GAYgASgJEgwKBGV4",
          "dDUYByABKAlCLQorY29tLmxhd3NvZm5hdHVyZS5hcGlnYXRld2F5LmRvbWFp",
          "bi5odHRwLnJlcWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PullResourceReq), global::PullResourceReq.Parser, new[]{ "Version", "Lan", "Ext1", "Ext2", "Ext3", "Ext4", "Ext5" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PullResourceReq : pb::IMessage<PullResourceReq> {
  private static readonly pb::MessageParser<PullResourceReq> _parser = new pb::MessageParser<PullResourceReq>(() => new PullResourceReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<PullResourceReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PullresourceReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PullResourceReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PullResourceReq(PullResourceReq other) : this() {
    version_ = other.version_;
    lan_ = other.lan_;
    ext1_ = other.ext1_;
    ext2_ = other.ext2_;
    ext3_ = other.ext3_;
    ext4_ = other.ext4_;
    ext5_ = other.ext5_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PullResourceReq Clone() {
    return new PullResourceReq(this);
  }

  /// <summary>Field number for the "version" field.</summary>
  public const int VersionFieldNumber = 1;
  private int version_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Version {
    get { return version_; }
    set {
      version_ = value;
    }
  }

  /// <summary>Field number for the "lan" field.</summary>
  public const int LanFieldNumber = 2;
  private string lan_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Lan {
    get { return lan_; }
    set {
      lan_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext1" field.</summary>
  public const int Ext1FieldNumber = 3;
  private string ext1_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext1 {
    get { return ext1_; }
    set {
      ext1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext2" field.</summary>
  public const int Ext2FieldNumber = 4;
  private string ext2_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext2 {
    get { return ext2_; }
    set {
      ext2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext3" field.</summary>
  public const int Ext3FieldNumber = 5;
  private string ext3_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext3 {
    get { return ext3_; }
    set {
      ext3_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext4" field.</summary>
  public const int Ext4FieldNumber = 6;
  private string ext4_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Ext4 {
    get { return ext4_; }
    set {
      ext4_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "ext5" field.</summary>
  public const int Ext5FieldNumber = 7;
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
    return Equals(other as PullResourceReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(PullResourceReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Version != other.Version) return false;
    if (Lan != other.Lan) return false;
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
    if (Version != 0) hash ^= Version.GetHashCode();
    if (Lan.Length != 0) hash ^= Lan.GetHashCode();
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
    if (Version != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Version);
    }
    if (Lan.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Lan);
    }
    if (Ext1.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Ext1);
    }
    if (Ext2.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Ext2);
    }
    if (Ext3.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Ext3);
    }
    if (Ext4.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(Ext4);
    }
    if (Ext5.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Ext5);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Version != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Version);
    }
    if (Lan.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Lan);
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
  public void MergeFrom(PullResourceReq other) {
    if (other == null) {
      return;
    }
    if (other.Version != 0) {
      Version = other.Version;
    }
    if (other.Lan.Length != 0) {
      Lan = other.Lan;
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
        case 8: {
          Version = input.ReadInt32();
          break;
        }
        case 18: {
          Lan = input.ReadString();
          break;
        }
        case 26: {
          Ext1 = input.ReadString();
          break;
        }
        case 34: {
          Ext2 = input.ReadString();
          break;
        }
        case 42: {
          Ext3 = input.ReadString();
          break;
        }
        case 50: {
          Ext4 = input.ReadString();
          break;
        }
        case 58: {
          Ext5 = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code