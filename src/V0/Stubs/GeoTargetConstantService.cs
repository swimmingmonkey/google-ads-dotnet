// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/geo_target_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/geo_target_constant_service.proto</summary>
  public static partial class GeoTargetConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/geo_target_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeoTargetConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9nZW9fdGFyZ2V0",
            "X2NvbnN0YW50X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLnNlcnZpY2VzGjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJj",
            "ZXMvZ2VvX3RhcmdldF9jb25zdGFudC5wcm90bxocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3Rv",
            "IjQKG0dldEdlb1RhcmdldENvbnN0YW50UmVxdWVzdBIVCg1yZXNvdXJjZV9u",
            "YW1lGAEgASgJMtoBChhHZW9UYXJnZXRDb25zdGFudFNlcnZpY2USvQEKFEdl",
            "dEdlb1RhcmdldENvbnN0YW50Ej0uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAu",
            "c2VydmljZXMuR2V0R2VvVGFyZ2V0Q29uc3RhbnRSZXF1ZXN0GjQuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2VzLkdlb1RhcmdldENvbnN0YW50",
            "IjCC0+STAioSKC92MC97cmVzb3VyY2VfbmFtZT1nZW9UYXJnZXRDb25zdGFu",
            "dHMvKn1C3QEKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNl",
            "c0IdR2VvVGFyZ2V0Q29uc3RhbnRTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yw",
            "L3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjAuU2VydmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxTZXJ2",
            "aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.GeoTargetConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetGeoTargetConstantRequest), global::Google.Ads.GoogleAds.V0.Services.GetGeoTargetConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [GeoTargetConstantService.GetGeoTargetConstant][google.ads.googleads.v0.services.GeoTargetConstantService.GetGeoTargetConstant].
  /// </summary>
  public sealed partial class GetGeoTargetConstantRequest : pb::IMessage<GetGeoTargetConstantRequest> {
    private static readonly pb::MessageParser<GetGeoTargetConstantRequest> _parser = new pb::MessageParser<GetGeoTargetConstantRequest>(() => new GetGeoTargetConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGeoTargetConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.GeoTargetConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGeoTargetConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGeoTargetConstantRequest(GetGeoTargetConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGeoTargetConstantRequest Clone() {
      return new GetGeoTargetConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the geo target constant to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGeoTargetConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGeoTargetConstantRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGeoTargetConstantRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
