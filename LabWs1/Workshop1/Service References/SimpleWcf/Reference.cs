﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Workshop1.SimpleWcf {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SimpleWcf.ISimpleWcf")]
    public interface ISimpleWcf {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleWcf/Greeting", ReplyAction="http://tempuri.org/ISimpleWcf/GreetingResponse")]
        string Greeting(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISimpleWcf/Greeting", ReplyAction="http://tempuri.org/ISimpleWcf/GreetingResponse")]
        System.Threading.Tasks.Task<string> GreetingAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleWcfChannel : Workshop1.SimpleWcf.ISimpleWcf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleWcfClient : System.ServiceModel.ClientBase<Workshop1.SimpleWcf.ISimpleWcf>, Workshop1.SimpleWcf.ISimpleWcf {
        
        public SimpleWcfClient() {
        }
        
        public SimpleWcfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimpleWcfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleWcfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimpleWcfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Greeting(string name) {
            return base.Channel.Greeting(name);
        }
        
        public System.Threading.Tasks.Task<string> GreetingAsync(string name) {
            return base.Channel.GreetingAsync(name);
        }
    }
}
