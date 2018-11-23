﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bank_Consumer.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IBank")]
    public interface IBank {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/Diposite", ReplyAction="http://tempuri.org/IBank/DipositeResponse")]
        string Diposite();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/Diposite", ReplyAction="http://tempuri.org/IBank/DipositeResponse")]
        System.Threading.Tasks.Task<string> DipositeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/Withdraw", ReplyAction="http://tempuri.org/IBank/WithdrawResponse")]
        string Withdraw();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/Withdraw", ReplyAction="http://tempuri.org/IBank/WithdrawResponse")]
        System.Threading.Tasks.Task<string> WithdrawAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/Increment", ReplyAction="http://tempuri.org/IBank/IncrementResponse")]
        string Increment();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBank/Increment", ReplyAction="http://tempuri.org/IBank/IncrementResponse")]
        System.Threading.Tasks.Task<string> IncrementAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankChannel : Bank_Consumer.ServiceReference1.IBank, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankClient : System.ServiceModel.ClientBase<Bank_Consumer.ServiceReference1.IBank>, Bank_Consumer.ServiceReference1.IBank {
        
        public BankClient() {
        }
        
        public BankClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Diposite() {
            return base.Channel.Diposite();
        }
        
        public System.Threading.Tasks.Task<string> DipositeAsync() {
            return base.Channel.DipositeAsync();
        }
        
        public string Withdraw() {
            return base.Channel.Withdraw();
        }
        
        public System.Threading.Tasks.Task<string> WithdrawAsync() {
            return base.Channel.WithdrawAsync();
        }
        
        public string Increment() {
            return base.Channel.Increment();
        }
        
        public System.Threading.Tasks.Task<string> IncrementAsync() {
            return base.Channel.IncrementAsync();
        }
    }
}
