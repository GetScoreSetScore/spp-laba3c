﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlService.FilterServiceReferenceCon {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FilterServiceReferenceCon.IFilter")]
    public interface IFilter {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilter/FilterItems", ReplyAction="http://tempuri.org/IFilter/FilterItemsResponse")]
        CommonLibrary.SynItems FilterItems(CommonLibrary.SynItems items, string[] tags);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFilter/FilterItems", ReplyAction="http://tempuri.org/IFilter/FilterItemsResponse")]
        System.Threading.Tasks.Task<CommonLibrary.SynItems> FilterItemsAsync(CommonLibrary.SynItems items, string[] tags);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFilterChannel : ControlService.FilterServiceReferenceCon.IFilter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FilterClient : System.ServiceModel.ClientBase<ControlService.FilterServiceReferenceCon.IFilter>, ControlService.FilterServiceReferenceCon.IFilter {
        
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
        
        public CommonLibrary.SynItems FilterItems(CommonLibrary.SynItems items, string[] tags) {
            return base.Channel.FilterItems(items, tags);
        }
        
        public System.Threading.Tasks.Task<CommonLibrary.SynItems> FilterItemsAsync(CommonLibrary.SynItems items, string[] tags) {
            return base.Channel.FilterItemsAsync(items, tags);
        }
    }
}
