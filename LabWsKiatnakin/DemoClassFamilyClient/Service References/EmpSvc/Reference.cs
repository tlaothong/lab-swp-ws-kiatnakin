﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoClassFamilyClient.EmpSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/DemoClassFamily.Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(DemoClassFamilyClient.EmpSvc.Manager))]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string EmployeeCode {
            get {
                return this.EmployeeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeCodeField, value) != true)) {
                    this.EmployeeCodeField = value;
                    this.RaisePropertyChanged("EmployeeCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Manager", Namespace="http://schemas.datacontract.org/2004/07/DemoClassFamily.Models")]
    [System.SerializableAttribute()]
    public partial class Manager : DemoClassFamilyClient.EmpSvc.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumOfEmployeesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumOfEmployees {
            get {
                return this.NumOfEmployeesField;
            }
            set {
                if ((this.NumOfEmployeesField.Equals(value) != true)) {
                    this.NumOfEmployeesField = value;
                    this.RaisePropertyChanged("NumOfEmployees");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpSvc.IEmpService")]
    public interface IEmpService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/AddNewEmployee", ReplyAction="http://tempuri.org/IEmpService/AddNewEmployeeResponse")]
        void AddNewEmployee(DemoClassFamilyClient.EmpSvc.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/AddNewEmployee", ReplyAction="http://tempuri.org/IEmpService/AddNewEmployeeResponse")]
        System.Threading.Tasks.Task AddNewEmployeeAsync(DemoClassFamilyClient.EmpSvc.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/ListAllEmployees", ReplyAction="http://tempuri.org/IEmpService/ListAllEmployeesResponse")]
        DemoClassFamilyClient.EmpSvc.Employee[] ListAllEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/ListAllEmployees", ReplyAction="http://tempuri.org/IEmpService/ListAllEmployeesResponse")]
        System.Threading.Tasks.Task<DemoClassFamilyClient.EmpSvc.Employee[]> ListAllEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/SetNumOfEmployee", ReplyAction="http://tempuri.org/IEmpService/SetNumOfEmployeeResponse")]
        void SetNumOfEmployee(DemoClassFamilyClient.EmpSvc.Manager manager, int numOfEmployees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpService/SetNumOfEmployee", ReplyAction="http://tempuri.org/IEmpService/SetNumOfEmployeeResponse")]
        System.Threading.Tasks.Task SetNumOfEmployeeAsync(DemoClassFamilyClient.EmpSvc.Manager manager, int numOfEmployees);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpServiceChannel : DemoClassFamilyClient.EmpSvc.IEmpService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpServiceClient : System.ServiceModel.ClientBase<DemoClassFamilyClient.EmpSvc.IEmpService>, DemoClassFamilyClient.EmpSvc.IEmpService {
        
        public EmpServiceClient() {
        }
        
        public EmpServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddNewEmployee(DemoClassFamilyClient.EmpSvc.Employee emp) {
            base.Channel.AddNewEmployee(emp);
        }
        
        public System.Threading.Tasks.Task AddNewEmployeeAsync(DemoClassFamilyClient.EmpSvc.Employee emp) {
            return base.Channel.AddNewEmployeeAsync(emp);
        }
        
        public DemoClassFamilyClient.EmpSvc.Employee[] ListAllEmployees() {
            return base.Channel.ListAllEmployees();
        }
        
        public System.Threading.Tasks.Task<DemoClassFamilyClient.EmpSvc.Employee[]> ListAllEmployeesAsync() {
            return base.Channel.ListAllEmployeesAsync();
        }
        
        public void SetNumOfEmployee(DemoClassFamilyClient.EmpSvc.Manager manager, int numOfEmployees) {
            base.Channel.SetNumOfEmployee(manager, numOfEmployees);
        }
        
        public System.Threading.Tasks.Task SetNumOfEmployeeAsync(DemoClassFamilyClient.EmpSvc.Manager manager, int numOfEmployees) {
            return base.Channel.SetNumOfEmployeeAsync(manager, numOfEmployees);
        }
    }
}