﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workshop1.FirstWcfSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FirstWcfSvc.IFirstWcfService")]
    public interface IFirstWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/NumToEng", ReplyAction="http://tempuri.org/IFirstWcfService/NumToEngResponse")]
        string NumToEng(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/NumToEng", ReplyAction="http://tempuri.org/IFirstWcfService/NumToEngResponse")]
        System.Threading.Tasks.Task<string> NumToEngAsync(int number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFirstWcfServiceChannel : Workshop1.FirstWcfSvc.IFirstWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FirstWcfServiceClient : System.ServiceModel.ClientBase<Workshop1.FirstWcfSvc.IFirstWcfService>, Workshop1.FirstWcfSvc.IFirstWcfService {
        
        public FirstWcfServiceClient() {
        }
        
        public FirstWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FirstWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string NumToEng(int number) {
            return base.Channel.NumToEng(number);
        }
        
        public System.Threading.Tasks.Task<string> NumToEngAsync(int number) {
            return base.Channel.NumToEngAsync(number);
        }
    }
}