﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.HelloWorldResponse HelloWorld(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add", ReplyAction="*")]
        int add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> addAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sub", ReplyAction="*")]
        int sub(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sub", ReplyAction="*")]
        System.Threading.Tasks.Task<int> subAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mul", ReplyAction="*")]
        int mul(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mulAsync(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/divide", ReplyAction="*")]
        int divide(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/divide", ReplyAction="*")]
        System.Threading.Tasks.Task<int> divideAsync(int x, int y);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody Body) {
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
        public WindowsFormsApplication1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsApplication1.ServiceReference1.HelloWorldResponseBody Body) {
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
    public interface WebServiceSoapChannel : WindowsFormsApplication1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.WebServiceSoap>, WindowsFormsApplication1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.HelloWorldResponse WindowsFormsApplication1.ServiceReference1.WebServiceSoap.HelloWorld(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsApplication1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody();
            WindowsFormsApplication1.ServiceReference1.HelloWorldResponse retVal = ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.HelloWorldResponse> WindowsFormsApplication1.ServiceReference1.WebServiceSoap.HelloWorldAsync(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WindowsFormsApplication1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody();
            return ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int add(int x, int y) {
            return base.Channel.add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int x, int y) {
            return base.Channel.addAsync(x, y);
        }
        
        public int sub(int x, int y) {
            return base.Channel.sub(x, y);
        }
        
        public System.Threading.Tasks.Task<int> subAsync(int x, int y) {
            return base.Channel.subAsync(x, y);
        }
        
        public int mul(int x, int y) {
            return base.Channel.mul(x, y);
        }
        
        public System.Threading.Tasks.Task<int> mulAsync(int x, int y) {
            return base.Channel.mulAsync(x, y);
        }
        
        public int divide(int x, int y) {
            return base.Channel.divide(x, y);
        }
        
        public System.Threading.Tasks.Task<int> divideAsync(int x, int y) {
            return base.Channel.divideAsync(x, y);
        }
    }
}
