﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PUS_Zad_3_Klient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name lancuch from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PierwszaMetoda", ReplyAction="*")]
        PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaResponse PierwszaMetoda(PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PierwszaMetodaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PierwszaMetoda", Namespace="http://tempuri.org/", Order=0)]
        public PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequestBody Body;
        
        public PierwszaMetodaRequest() {
        }
        
        public PierwszaMetodaRequest(PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PierwszaMetodaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string lancuch;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nazwa;
        
        public PierwszaMetodaRequestBody() {
        }
        
        public PierwszaMetodaRequestBody(string lancuch, string nazwa) {
            this.lancuch = lancuch;
            this.nazwa = nazwa;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PierwszaMetodaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PierwszaMetodaResponse", Namespace="http://tempuri.org/", Order=0)]
        public PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaResponseBody Body;
        
        public PierwszaMetodaResponse() {
        }
        
        public PierwszaMetodaResponse(PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PierwszaMetodaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PierwszaMetodaResult;
        
        public PierwszaMetodaResponseBody() {
        }
        
        public PierwszaMetodaResponseBody(string PierwszaMetodaResult) {
            this.PierwszaMetodaResult = PierwszaMetodaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : PUS_Zad_3_Klient.ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<PUS_Zad_3_Klient.ServiceReference1.ServiceSoap>, PUS_Zad_3_Klient.ServiceReference1.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaResponse PUS_Zad_3_Klient.ServiceReference1.ServiceSoap.PierwszaMetoda(PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequest request) {
            return base.Channel.PierwszaMetoda(request);
        }
        
        public string PierwszaMetoda(string lancuch, string nazwa) {
            PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequest inValue = new PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequest();
            inValue.Body = new PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaRequestBody();
            inValue.Body.lancuch = lancuch;
            inValue.Body.nazwa = nazwa;
            PUS_Zad_3_Klient.ServiceReference1.PierwszaMetodaResponse retVal = ((PUS_Zad_3_Klient.ServiceReference1.ServiceSoap)(this)).PierwszaMetoda(inValue);
            return retVal.Body.PierwszaMetodaResult;
        }
    }
}
