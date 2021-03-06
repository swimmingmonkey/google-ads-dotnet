// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/product_type_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/product_type_level.proto</summary>
  public static partial class ProductTypeLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/product_type_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductTypeLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wcm9kdWN0X3R5cGVf",
            "bGV2ZWwucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zIrIB",
            "ChRQcm9kdWN0VHlwZUxldmVsRW51bSKZAQoQUHJvZHVjdFR5cGVMZXZlbBIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARITCg9QUk9EVUNUX1RZUEVf",
            "TDEQAhITCg9QUk9EVUNUX1RZUEVfTDIQAxITCg9QUk9EVUNUX1RZUEVfTDMQ",
            "BBITCg9QUk9EVUNUX1RZUEVfTDQQBRITCg9QUk9EVUNUX1RZUEVfTDUQBkLG",
            "AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zQhVQcm9kdWN0",
            "VHlwZUxldmVsUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zO2VudW1zogIDR0FB",
            "qgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMFxFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.ProductTypeLevelEnum), global::Google.Ads.GoogleAds.V0.Enums.ProductTypeLevelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.ProductTypeLevelEnum.Types.ProductTypeLevel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Level of the type of a product offer.
  /// </summary>
  public sealed partial class ProductTypeLevelEnum : pb::IMessage<ProductTypeLevelEnum> {
    private static readonly pb::MessageParser<ProductTypeLevelEnum> _parser = new pb::MessageParser<ProductTypeLevelEnum>(() => new ProductTypeLevelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductTypeLevelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.ProductTypeLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductTypeLevelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductTypeLevelEnum(ProductTypeLevelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductTypeLevelEnum Clone() {
      return new ProductTypeLevelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductTypeLevelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductTypeLevelEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductTypeLevelEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProductTypeLevelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the level of the type of a product offer.
      /// </summary>
      public enum ProductTypeLevel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Level 1.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TYPE_L1")] ProductTypeL1 = 2,
        /// <summary>
        /// Level 2.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TYPE_L2")] ProductTypeL2 = 3,
        /// <summary>
        /// Level 3.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TYPE_L3")] ProductTypeL3 = 4,
        /// <summary>
        /// Level 4.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TYPE_L4")] ProductTypeL4 = 5,
        /// <summary>
        /// Level 5.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TYPE_L5")] ProductTypeL5 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
