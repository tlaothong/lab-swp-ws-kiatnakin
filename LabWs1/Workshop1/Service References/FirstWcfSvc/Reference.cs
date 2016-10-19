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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DivFault", Namespace="http://schemas.datacontract.org/2004/07/SimpleWebApp")]
    [System.SerializableAttribute()]
    public partial class DivFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BField;
        
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
        public int A {
            get {
                return this.AField;
            }
            set {
                if ((this.AField.Equals(value) != true)) {
                    this.AField = value;
                    this.RaisePropertyChanged("A");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int B {
            get {
                return this.BField;
            }
            set {
                if ((this.BField.Equals(value) != true)) {
                    this.BField = value;
                    this.RaisePropertyChanged("B");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FirstWcfSvc.IFirstWcfService")]
    public interface IFirstWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/NumToEng", ReplyAction="http://tempuri.org/IFirstWcfService/NumToEngResponse")]
        string NumToEng(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/NumToEng", ReplyAction="http://tempuri.org/IFirstWcfService/NumToEngResponse")]
        System.Threading.Tasks.Task<string> NumToEngAsync(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/Add200", ReplyAction="http://tempuri.org/IFirstWcfService/Add200Response")]
        string Add200(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/Add200", ReplyAction="http://tempuri.org/IFirstWcfService/Add200Response")]
        System.Threading.Tasks.Task<string> Add200Async(int number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/Div", ReplyAction="http://tempuri.org/IFirstWcfService/DivResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Workshop1.FirstWcfSvc.DivFault), Action="http://tempuri.org/IFirstWcfService/DivDivFaultFault", Name="DivFault", Namespace="http://schemas.datacontract.org/2004/07/SimpleWebApp")]
        int Div(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWcfService/Div", ReplyAction="http://tempuri.org/IFirstWcfService/DivResponse")]
        System.Threading.Tasks.Task<int> DivAsync(int a, int b);
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
        
        public string Add200(int number) {
            return base.Channel.Add200(number);
        }
        
        public System.Threading.Tasks.Task<string> Add200Async(int number) {
            return base.Channel.Add200Async(number);
        }
        
        public int Div(int a, int b) {
            return base.Channel.Div(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivAsync(int a, int b) {
            return base.Channel.DivAsync(a, b);
        }
    }
}
