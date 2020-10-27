﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormClient.ControlServiceReferenceCon {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ControlServiceReferenceCon.IControl")]
    public interface IControl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControl/ProcessFeeds", ReplyAction="http://tempuri.org/IControl/ProcessFeedsResponse")]
        CommonLibrary.SynItems ProcessFeeds(string[] feeds, string[] tags, string[] mails);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControl/ProcessFeeds", ReplyAction="http://tempuri.org/IControl/ProcessFeedsResponse")]
        System.Threading.Tasks.Task<CommonLibrary.SynItems> ProcessFeedsAsync(string[] feeds, string[] tags, string[] mails);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControlChannel : FormClient.ControlServiceReferenceCon.IControl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControlClient : System.ServiceModel.ClientBase<FormClient.ControlServiceReferenceCon.IControl>, FormClient.ControlServiceReferenceCon.IControl {
        
        public ControlClient() {
        }
        
        public ControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CommonLibrary.SynItems ProcessFeeds(string[] feeds, string[] tags, string[] mails) {
            return base.Channel.ProcessFeeds(feeds, tags, mails);
        }
        
        public System.Threading.Tasks.Task<CommonLibrary.SynItems> ProcessFeedsAsync(string[] feeds, string[] tags, string[] mails) {
            return base.Channel.ProcessFeedsAsync(feeds, tags, mails);
        }
    }
}