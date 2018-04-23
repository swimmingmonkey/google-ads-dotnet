// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/ad_network_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/ad_network_type.proto</summary>
  public static partial class AdNetworkTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/ad_network_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdNetworkTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9hZF9uZXR3b3JrX3R5",
            "cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zIpgBChFB",
            "ZE5ldHdvcmtUeXBlRW51bSKCAQoNQWROZXR3b3JrVHlwZRIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIKCgZTRUFSQ0gQAhITCg9TRUFSQ0hfUEFS",
            "VE5FUlMQAxILCgdDT05URU5UEAQSEgoOWU9VVFVCRV9TRUFSQ0gQBRIRCg1Z",
            "T1VUVUJFX1dBVENIEAZCwwEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MC5lbnVtc0ISQWROZXR3b3JrVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lbnVt",
            "cztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVudW1z",
            "ygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.AdNetworkTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.AdNetworkTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.AdNetworkTypeEnum.Types.AdNetworkType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of AdWords network types.
  /// </summary>
  public sealed partial class AdNetworkTypeEnum : pb::IMessage<AdNetworkTypeEnum> {
    private static readonly pb::MessageParser<AdNetworkTypeEnum> _parser = new pb::MessageParser<AdNetworkTypeEnum>(() => new AdNetworkTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdNetworkTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.AdNetworkTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdNetworkTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdNetworkTypeEnum(AdNetworkTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdNetworkTypeEnum Clone() {
      return new AdNetworkTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdNetworkTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdNetworkTypeEnum other) {
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
    public void MergeFrom(AdNetworkTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdNetworkTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates AdWords network types.
      /// </summary>
      public enum AdNetworkType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google search.
        /// </summary>
        [pbr::OriginalName("SEARCH")] Search = 2,
        /// <summary>
        /// Search partners.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNERS")] SearchPartners = 3,
        /// <summary>
        /// Display Network.
        /// </summary>
        [pbr::OriginalName("CONTENT")] Content = 4,
        /// <summary>
        /// YouTube Search.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_SEARCH")] YoutubeSearch = 5,
        /// <summary>
        /// YouTube Videos
        /// </summary>
        [pbr::OriginalName("YOUTUBE_WATCH")] YoutubeWatch = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code