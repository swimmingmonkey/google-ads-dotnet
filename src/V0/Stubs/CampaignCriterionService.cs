// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/campaign_criterion_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/campaign_criterion_service.proto</summary>
  public static partial class CampaignCriterionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/campaign_criterion_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9jYW1wYWlnbl9j",
            "cml0ZXJpb25fc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djAuc2VydmljZXMaOmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YwL3Jlc291cmNl",
            "cy9jYW1wYWlnbl9jcml0ZXJpb24ucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8aIGdvb2dsZS9wcm90b2J1Zi9maWVsZF9tYXNrLnByb3Rv",
            "IjQKG0dldENhbXBhaWduQ3JpdGVyaW9uUmVxdWVzdBIVCg1yZXNvdXJjZV9u",
            "YW1lGAEgASgJIoYBCh1NdXRhdGVDYW1wYWlnbkNyaXRlcmlhUmVxdWVzdBIT",
            "CgtjdXN0b21lcl9pZBgBIAEoCRJQCgpvcGVyYXRpb25zGAIgAygLMjwuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjAuc2VydmljZXMuQ2FtcGFpZ25Dcml0ZXJp",
            "b25PcGVyYXRpb24i/AEKGkNhbXBhaWduQ3JpdGVyaW9uT3BlcmF0aW9uEi8K",
            "C3VwZGF0ZV9tYXNrGAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLkZpZWxkTWFz",
            "axJGCgZjcmVhdGUYASABKAsyNC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5y",
            "ZXNvdXJjZXMuQ2FtcGFpZ25Dcml0ZXJpb25IABJGCgZ1cGRhdGUYAiABKAsy",
            "NC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5yZXNvdXJjZXMuQ2FtcGFpZ25D",
            "cml0ZXJpb25IABIQCgZyZW1vdmUYAyABKAlIAEILCglvcGVyYXRpb24icgoe",
            "TXV0YXRlQ2FtcGFpZ25Dcml0ZXJpYVJlc3BvbnNlElAKB3Jlc3VsdHMYAiAD",
            "KAsyPy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlcy5NdXRhdGVD",
            "YW1wYWlnbkNyaXRlcmlvblJlc3VsdCI2Ch1NdXRhdGVDYW1wYWlnbkNyaXRl",
            "cmlvblJlc3VsdBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJMsQDChhDYW1wYWln",
            "bkNyaXRlcmlvblNlcnZpY2USxwEKFEdldENhbXBhaWduQ3JpdGVyaW9uEj0u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjAuc2VydmljZXMuR2V0Q2FtcGFpZ25D",
            "cml0ZXJpb25SZXF1ZXN0GjQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVz",
            "b3VyY2VzLkNhbXBhaWduQ3JpdGVyaW9uIjqC0+STAjQSMi92MC97cmVzb3Vy",
            "Y2VfbmFtZT1jdXN0b21lcnMvKi9jYW1wYWlnbkNyaXRlcmlhLyp9Et0BChZN",
            "dXRhdGVDYW1wYWlnbkNyaXRlcmlhEj8uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djAuc2VydmljZXMuTXV0YXRlQ2FtcGFpZ25Dcml0ZXJpYVJlcXVlc3QaQC5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlcy5NdXRhdGVDYW1wYWln",
            "bkNyaXRlcmlhUmVzcG9uc2UiQILT5JMCOiI1L3YwL2N1c3RvbWVycy97Y3Vz",
            "dG9tZXJfaWQ9Kn0vY2FtcGFpZ25Dcml0ZXJpYTptdXRhdGU6ASpC3QEKJGNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlc0IdQ2FtcGFpZ25D",
            "cml0ZXJpb25TZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL3NlcnZpY2VzO3Nl",
            "cnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuU2Vydmlj",
            "ZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterionReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetCampaignCriterionRequest), global::Google.Ads.GoogleAds.V0.Services.GetCampaignCriterionRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriteriaRequest), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriteriaRequest.Parser, new[]{ "CustomerId", "Operations" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation), global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation.Parser, new[]{ "UpdateMask", "Create", "Update", "Remove" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriteriaResponse), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriteriaResponse.Parser, new[]{ "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [CampaignCriterionService.GetCampaignCriterion][google.ads.googleads.v0.services.CampaignCriterionService.GetCampaignCriterion].
  /// </summary>
  public sealed partial class GetCampaignCriterionRequest : pb::IMessage<GetCampaignCriterionRequest> {
    private static readonly pb::MessageParser<GetCampaignCriterionRequest> _parser = new pb::MessageParser<GetCampaignCriterionRequest>(() => new GetCampaignCriterionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCampaignCriterionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignCriterionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignCriterionRequest(GetCampaignCriterionRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignCriterionRequest Clone() {
      return new GetCampaignCriterionRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the criterion to fetch.
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
      return Equals(other as GetCampaignCriterionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCampaignCriterionRequest other) {
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
    public void MergeFrom(GetCampaignCriterionRequest other) {
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

  /// <summary>
  /// Request message for [CampaignCriterionService.MutateCampaignCriteria][google.ads.googleads.v0.services.CampaignCriterionService.MutateCampaignCriteria].
  /// </summary>
  public sealed partial class MutateCampaignCriteriaRequest : pb::IMessage<MutateCampaignCriteriaRequest> {
    private static readonly pb::MessageParser<MutateCampaignCriteriaRequest> _parser = new pb::MessageParser<MutateCampaignCriteriaRequest>(() => new MutateCampaignCriteriaRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCampaignCriteriaRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriteriaRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriteriaRequest(MutateCampaignCriteriaRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriteriaRequest Clone() {
      return new MutateCampaignCriteriaRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer whose criteria are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation>();
    /// <summary>
    /// The list of operations to perform on individual criteria.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionOperation> Operations {
      get { return operations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateCampaignCriteriaRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCampaignCriteriaRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateCampaignCriteriaRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
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
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation (create, update, remove) on a campaign criterion.
  /// </summary>
  public sealed partial class CampaignCriterionOperation : pb::IMessage<CampaignCriterionOperation> {
    private static readonly pb::MessageParser<CampaignCriterionOperation> _parser = new pb::MessageParser<CampaignCriterionOperation>(() => new CampaignCriterionOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignCriterionOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionOperation(CampaignCriterionOperation other) : this() {
      updateMask_ = other.updateMask_ != null ? other.updateMask_.Clone() : null;
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Update:
          Update = other.Update.Clone();
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionOperation Clone() {
      return new CampaignCriterionOperation(this);
    }

    /// <summary>Field number for the "update_mask" field.</summary>
    public const int UpdateMaskFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
    /// <summary>
    /// FieldMask that determines which resource fields are modified in an update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.FieldMask UpdateMask {
      get { return updateMask_; }
      set {
        updateMask_ = value;
      }
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "update" field.</summary>
    public const int UpdateFieldNumber = 2;
    /// <summary>
    /// Update operation: The criterion is expected to have a valid resource
    /// name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion Update {
      get { return operationCase_ == OperationOneofCase.Update ? (global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Update;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 3;
    /// <summary>
    /// Remove operation: A resource name for the removed criterion is expected,
    /// in this format:
    ///
    /// `customers/{customer_id}/campaignCriteria/{campaign_id}_{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Remove {
      get { return operationCase_ == OperationOneofCase.Remove ? (string) operation_ : ""; }
      set {
        operation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        operationCase_ = OperationOneofCase.Remove;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Update = 2,
      Remove = 3,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterionOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignCriterionOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UpdateMask, other.UpdateMask)) return false;
      if (!object.Equals(Create, other.Create)) return false;
      if (!object.Equals(Update, other.Update)) return false;
      if (Remove != other.Remove) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Update) hash ^= Update.GetHashCode();
      if (operationCase_ == OperationOneofCase.Remove) hash ^= Remove.GetHashCode();
      hash ^= (int) operationCase_;
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
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        output.WriteRawTag(18);
        output.WriteMessage(Update);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(26);
        output.WriteString(Remove);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (updateMask_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateMask);
      }
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Update);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Remove);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignCriterionOperation other) {
      if (other == null) {
        return;
      }
      if (other.updateMask_ != null) {
        if (updateMask_ == null) {
          updateMask_ = new global::Google.Protobuf.WellKnownTypes.FieldMask();
        }
        UpdateMask.MergeFrom(other.UpdateMask);
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Update:
          if (Update == null) {
            Update = new global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion();
          }
          Update.MergeFrom(other.Update);
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
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
            global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion subBuilder = new global::Google.Ads.GoogleAds.V0.Resources.CampaignCriterion();
            if (operationCase_ == OperationOneofCase.Update) {
              subBuilder.MergeFrom(Update);
            }
            input.ReadMessage(subBuilder);
            Update = subBuilder;
            break;
          }
          case 26: {
            Remove = input.ReadString();
            break;
          }
          case 34: {
            if (updateMask_ == null) {
              updateMask_ = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(updateMask_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for campaign criterion mutate.
  /// </summary>
  public sealed partial class MutateCampaignCriteriaResponse : pb::IMessage<MutateCampaignCriteriaResponse> {
    private static readonly pb::MessageParser<MutateCampaignCriteriaResponse> _parser = new pb::MessageParser<MutateCampaignCriteriaResponse>(() => new MutateCampaignCriteriaResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCampaignCriteriaResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriteriaResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriteriaResponse(MutateCampaignCriteriaResponse other) : this() {
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriteriaResponse Clone() {
      return new MutateCampaignCriteriaResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignCriterionResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateCampaignCriteriaResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCampaignCriteriaResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
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
      results_.WriteTo(output, _repeated_results_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateCampaignCriteriaResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
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
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for the criterion mutate.
  /// </summary>
  public sealed partial class MutateCampaignCriterionResult : pb::IMessage<MutateCampaignCriterionResult> {
    private static readonly pb::MessageParser<MutateCampaignCriterionResult> _parser = new pb::MessageParser<MutateCampaignCriterionResult>(() => new MutateCampaignCriterionResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateCampaignCriterionResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.CampaignCriterionServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriterionResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriterionResult(MutateCampaignCriterionResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateCampaignCriterionResult Clone() {
      return new MutateCampaignCriterionResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations.
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
      return Equals(other as MutateCampaignCriterionResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateCampaignCriterionResult other) {
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
    public void MergeFrom(MutateCampaignCriterionResult other) {
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
