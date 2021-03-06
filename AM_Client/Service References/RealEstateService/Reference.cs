﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AM_Client.RealEstateService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RealEstateListing", Namespace="http://schemas.datacontract.org/2004/07/AM_Backend.RealEstateService")]
    [System.SerializableAttribute()]
    public partial class RealEstateListing : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HouseNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZillowIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HouseNumber {
            get {
                return this.HouseNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.HouseNumberField, value) != true)) {
                    this.HouseNumberField = value;
                    this.RaisePropertyChanged("HouseNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetName {
            get {
                return this.StreetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetNameField, value) != true)) {
                    this.StreetNameField = value;
                    this.RaisePropertyChanged("StreetName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZillowId {
            get {
                return this.ZillowIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ZillowIdField, value) != true)) {
                    this.ZillowIdField = value;
                    this.RaisePropertyChanged("ZillowId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RealEstateService.IRealEstateService")]
    public interface IRealEstateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRealEstateService/GetListings", ReplyAction="http://tempuri.org/IRealEstateService/GetListingsResponse")]
        AM_Client.RealEstateService.GetListingsResponse GetListings(AM_Client.RealEstateService.GetListingsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRealEstateService/GetListings", ReplyAction="http://tempuri.org/IRealEstateService/GetListingsResponse")]
        System.Threading.Tasks.Task<AM_Client.RealEstateService.GetListingsResponse> GetListingsAsync(AM_Client.RealEstateService.GetListingsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetListings", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetListingsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string zipcode;
        
        public GetListingsRequest() {
        }
        
        public GetListingsRequest(string zipcode) {
            this.zipcode = zipcode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetListingsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetListingsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<AM_Client.RealEstateService.RealEstateListing> GetListingsResult;
        
        public GetListingsResponse() {
        }
        
        public GetListingsResponse(System.Collections.Generic.List<AM_Client.RealEstateService.RealEstateListing> GetListingsResult) {
            this.GetListingsResult = GetListingsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRealEstateServiceChannel : AM_Client.RealEstateService.IRealEstateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RealEstateServiceClient : System.ServiceModel.ClientBase<AM_Client.RealEstateService.IRealEstateService>, AM_Client.RealEstateService.IRealEstateService {
        
        public RealEstateServiceClient() {
        }
        
        public RealEstateServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RealEstateServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RealEstateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RealEstateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AM_Client.RealEstateService.GetListingsResponse GetListings(AM_Client.RealEstateService.GetListingsRequest request) {
            return base.Channel.GetListings(request);
        }
        
        public System.Threading.Tasks.Task<AM_Client.RealEstateService.GetListingsResponse> GetListingsAsync(AM_Client.RealEstateService.GetListingsRequest request) {
            return base.Channel.GetListingsAsync(request);
        }
    }
}
