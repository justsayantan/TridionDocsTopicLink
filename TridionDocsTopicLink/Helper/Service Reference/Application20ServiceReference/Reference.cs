﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDLKC2016WSSample.Application20ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API20/")]
    [System.SerializableAttribute()]
    public partial class InfoShareFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long InfoShareErrorNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XMLDetailField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long InfoShareErrorNumber {
            get {
                return this.InfoShareErrorNumberField;
            }
            set {
                if ((this.InfoShareErrorNumberField.Equals(value) != true)) {
                    this.InfoShareErrorNumberField = value;
                    this.RaisePropertyChanged("InfoShareErrorNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XMLDetail {
            get {
                return this.XMLDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.XMLDetailField, value) != true)) {
                    this.XMLDetailField = value;
                    this.RaisePropertyChanged("XMLDetail");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", ConfigurationName="Application20ServiceReference.Application")]
    public interface Application {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetReleased" +
            "States", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetReleased" +
            "StatesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.Application20ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetReleased" +
            "StatesInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API20/")]
        SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesResponse GetReleasedStates(SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetReleased" +
            "States", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetReleased" +
            "StatesResponse")]
        System.Threading.Tasks.Task<SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesResponse> GetReleasedStatesAsync(SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetResource" +
            "", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetResource" +
            "Response")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.Application20ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetResource" +
            "InfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API20/")]
        SDLKC2016WSSample.Application20ServiceReference.GetResourceResponse GetResource(SDLKC2016WSSample.Application20ServiceReference.GetResourceRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetResource" +
            "", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetResource" +
            "Response")]
        System.Threading.Tasks.Task<SDLKC2016WSSample.Application20ServiceReference.GetResourceResponse> GetResourceAsync(SDLKC2016WSSample.Application20ServiceReference.GetResourceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetVersion", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetVersionR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.Application20ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetVersionI" +
            "nfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API20/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        string GetVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetVersion", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/Application/GetVersionR" +
            "esponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        System.Threading.Tasks.Task<string> GetVersionAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetReleasedStates", WrapperNamespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", IsWrapped=true)]
    public partial class GetReleasedStatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=0)]
        public string[] releasedStates;
        
        public GetReleasedStatesRequest() {
        }
        
        public GetReleasedStatesRequest(string[] releasedStates) {
            this.releasedStates = releasedStates;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetReleasedStatesResponse", WrapperNamespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", IsWrapped=true)]
    public partial class GetReleasedStatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=0)]
        public string returnValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=1)]
        public string[] releasedStates;
        
        public GetReleasedStatesResponse() {
        }
        
        public GetReleasedStatesResponse(string returnValue, string[] releasedStates) {
            this.returnValue = returnValue;
            this.releasedStates = releasedStates;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetResource", WrapperNamespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", IsWrapped=true)]
    public partial class GetResourceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=0)]
        public string baseName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=1)]
        public string locale;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=2)]
        public string resourceContext;
        
        public GetResourceRequest() {
        }
        
        public GetResourceRequest(string baseName, string locale, string resourceContext) {
            this.baseName = baseName;
            this.locale = locale;
            this.resourceContext = resourceContext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetResourceResponse", WrapperNamespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", IsWrapped=true)]
    public partial class GetResourceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=0)]
        public string returnValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API20/", Order=1)]
        public string resourceContext;
        
        public GetResourceResponse() {
        }
        
        public GetResourceResponse(string returnValue, string resourceContext) {
            this.returnValue = returnValue;
            this.resourceContext = resourceContext;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ApplicationChannel : SDLKC2016WSSample.Application20ServiceReference.Application, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationClient : System.ServiceModel.ClientBase<SDLKC2016WSSample.Application20ServiceReference.Application>, SDLKC2016WSSample.Application20ServiceReference.Application {
        
        public ApplicationClient() {
        }
        
        public ApplicationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesResponse SDLKC2016WSSample.Application20ServiceReference.Application.GetReleasedStates(SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesRequest request) {
            return base.Channel.GetReleasedStates(request);
        }
        
        public string GetReleasedStates(ref string[] releasedStates) {
            SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesRequest inValue = new SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesRequest();
            inValue.releasedStates = releasedStates;
            SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesResponse retVal = ((SDLKC2016WSSample.Application20ServiceReference.Application)(this)).GetReleasedStates(inValue);
            releasedStates = retVal.releasedStates;
            return retVal.returnValue;
        }
        
        public System.Threading.Tasks.Task<SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesResponse> GetReleasedStatesAsync(SDLKC2016WSSample.Application20ServiceReference.GetReleasedStatesRequest request) {
            return base.Channel.GetReleasedStatesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SDLKC2016WSSample.Application20ServiceReference.GetResourceResponse SDLKC2016WSSample.Application20ServiceReference.Application.GetResource(SDLKC2016WSSample.Application20ServiceReference.GetResourceRequest request) {
            return base.Channel.GetResource(request);
        }
        
        public string GetResource(string baseName, string locale, ref string resourceContext) {
            SDLKC2016WSSample.Application20ServiceReference.GetResourceRequest inValue = new SDLKC2016WSSample.Application20ServiceReference.GetResourceRequest();
            inValue.baseName = baseName;
            inValue.locale = locale;
            inValue.resourceContext = resourceContext;
            SDLKC2016WSSample.Application20ServiceReference.GetResourceResponse retVal = ((SDLKC2016WSSample.Application20ServiceReference.Application)(this)).GetResource(inValue);
            resourceContext = retVal.resourceContext;
            return retVal.returnValue;
        }
        
        public System.Threading.Tasks.Task<SDLKC2016WSSample.Application20ServiceReference.GetResourceResponse> GetResourceAsync(SDLKC2016WSSample.Application20ServiceReference.GetResourceRequest request) {
            return base.Channel.GetResourceAsync(request);
        }
        
        public string GetVersion() {
            return base.Channel.GetVersion();
        }
        
        public System.Threading.Tasks.Task<string> GetVersionAsync() {
            return base.Channel.GetVersionAsync();
        }
    }
}
