﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyClient.MCU {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MCU.McuMathSoap")]
    public interface McuMathSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Minus", ReplyAction="*")]
        int Minus(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Minus", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MinusAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cross", ReplyAction="*")]
        int Cross(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Cross", ReplyAction="*")]
        System.Threading.Tasks.Task<int> CrossAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        int Divide(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivideAsync(int a, int b);
        
        // CODEGEN: 命名空間 http://tempuri.org/ 的元素名稱  HelloWorldResult 未標示為 nillable，正在產生訊息合約
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        MyClient.MCU.HelloWorldResponse HelloWorld(MyClient.MCU.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<MyClient.MCU.HelloWorldResponse> HelloWorldAsync(MyClient.MCU.HelloWorldRequest request);
        string HelloWorld();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public MyClient.MCU.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(MyClient.MCU.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyClient.MCU.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(MyClient.MCU.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface McuMathSoapChannel : MyClient.MCU.McuMathSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class McuMathSoapClient : System.ServiceModel.ClientBase<MyClient.MCU.McuMathSoap>, MyClient.MCU.McuMathSoap {
        
        public McuMathSoapClient() {
        }
        
        public McuMathSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public McuMathSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public McuMathSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public McuMathSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public int Minus(int a, int b) {
            return base.Channel.Minus(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MinusAsync(int a, int b) {
            return base.Channel.MinusAsync(a, b);
        }
        
        public int Cross(int a, int b) {
            return base.Channel.Cross(a, b);
        }
        
        public System.Threading.Tasks.Task<int> CrossAsync(int a, int b) {
            return base.Channel.CrossAsync(a, b);
        }
        
        public int Divide(int a, int b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int a, int b) {
            return base.Channel.DivideAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyClient.MCU.HelloWorldResponse MyClient.MCU.McuMathSoap.HelloWorld(MyClient.MCU.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            MyClient.MCU.HelloWorldRequest inValue = new MyClient.MCU.HelloWorldRequest();
            inValue.Body = new MyClient.MCU.HelloWorldRequestBody();
            MyClient.MCU.HelloWorldResponse retVal = ((MyClient.MCU.McuMathSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyClient.MCU.HelloWorldResponse> MyClient.MCU.McuMathSoap.HelloWorldAsync(MyClient.MCU.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyClient.MCU.HelloWorldResponse> HelloWorldAsync() {
            MyClient.MCU.HelloWorldRequest inValue = new MyClient.MCU.HelloWorldRequest();
            inValue.Body = new MyClient.MCU.HelloWorldRequestBody();
            return ((MyClient.MCU.McuMathSoap)(this)).HelloWorldAsync(inValue);
        }
    }
}
