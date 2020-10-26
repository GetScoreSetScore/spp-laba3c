﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient.FilterServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/FilterService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FilterServiceReference.IFilter")]
    public interface IFilter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilter/GetData", ReplyAction="http://tempuri.org/IFilter/GetDataResponse")]
        string GetData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilter/GetData", ReplyAction="http://tempuri.org/IFilter/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilter/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFilter/GetDataUsingDataContractResponse")]
        ConsoleClient.FilterServiceReference.CompositeType GetDataUsingDataContract(ConsoleClient.FilterServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilter/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFilter/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ConsoleClient.FilterServiceReference.CompositeType> GetDataUsingDataContractAsync(ConsoleClient.FilterServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFilterChannel : ConsoleClient.FilterServiceReference.IFilter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FilterClient : System.ServiceModel.ClientBase<ConsoleClient.FilterServiceReference.IFilter>, ConsoleClient.FilterServiceReference.IFilter {
        
        public FilterClient() {
        }
        
        public FilterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FilterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FilterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FilterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(string value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(string value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ConsoleClient.FilterServiceReference.CompositeType GetDataUsingDataContract(ConsoleClient.FilterServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ConsoleClient.FilterServiceReference.CompositeType> GetDataUsingDataContractAsync(ConsoleClient.FilterServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
