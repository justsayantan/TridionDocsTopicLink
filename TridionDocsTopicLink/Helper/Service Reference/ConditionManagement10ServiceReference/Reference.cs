﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDLKC2016WSSample.ConditionManagement10ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API/", ConfigurationName="ConditionManagement10ServiceReference.ConditionManagement")]
    public interface ConditionManagement {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Updat" +
            "eConditionCategories", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Updat" +
            "eConditionCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Updat" +
            "eConditionCategoriesInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short UpdateConditionCategories(ref string xmlChanges, ref string xmlConditionCategories);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Updat" +
            "eConditionMasterSet", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Updat" +
            "eConditionMasterSetResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Updat" +
            "eConditionMasterSetInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short UpdateConditionMasterSet(ref string xmlChanges, ref string xmlConditionCategories);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Compa" +
            "reConditionCategories", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Compa" +
            "reConditionCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Compa" +
            "reConditionCategoriesInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short CompareConditionCategories(string xmlOriginalConditionCategory, string xmlNewConditionCategory, ref string xmlChanges);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Compa" +
            "reConditionLists", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Compa" +
            "reConditionListsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Compa" +
            "reConditionListsInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short CompareConditionLists(string xmlOriginalConditionList, string xmlNewConditionList, ref string xmlChanges);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionCategories", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionCategoriesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionCategoriesInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short GetConditionCategories(ref string xmlConditionCategories);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionMasterSet", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionMasterSetResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionMasterSetInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short GetConditionMasterSet(ref string xmlConditionMasterSet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionSynchronisation", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionSynchronisationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/GetCo" +
            "nditionSynchronisationInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short GetConditionSynchronisation(ref string xmlConditionChanges);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Searc" +
            "hInDocuments", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Searc" +
            "hInDocumentsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SDLKC2016WSSample.ConditionManagement10ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API/ConditionManagement/Searc" +
            "hInDocumentsInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="returnValue")]
        short SearchInDocuments(string conditionName, string conditionValue, ref string xmlDocuments);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConditionManagementChannel : SDLKC2016WSSample.ConditionManagement10ServiceReference.ConditionManagement, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConditionManagementClient : System.ServiceModel.ClientBase<SDLKC2016WSSample.ConditionManagement10ServiceReference.ConditionManagement>, SDLKC2016WSSample.ConditionManagement10ServiceReference.ConditionManagement {
        
        public ConditionManagementClient() {
        }
        
        public ConditionManagementClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConditionManagementClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConditionManagementClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConditionManagementClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public short UpdateConditionCategories(ref string xmlChanges, ref string xmlConditionCategories) {
            return base.Channel.UpdateConditionCategories(ref xmlChanges, ref xmlConditionCategories);
        }
        
        public short UpdateConditionMasterSet(ref string xmlChanges, ref string xmlConditionCategories) {
            return base.Channel.UpdateConditionMasterSet(ref xmlChanges, ref xmlConditionCategories);
        }
        
        public short CompareConditionCategories(string xmlOriginalConditionCategory, string xmlNewConditionCategory, ref string xmlChanges) {
            return base.Channel.CompareConditionCategories(xmlOriginalConditionCategory, xmlNewConditionCategory, ref xmlChanges);
        }
        
        public short CompareConditionLists(string xmlOriginalConditionList, string xmlNewConditionList, ref string xmlChanges) {
            return base.Channel.CompareConditionLists(xmlOriginalConditionList, xmlNewConditionList, ref xmlChanges);
        }
        
        public short GetConditionCategories(ref string xmlConditionCategories) {
            return base.Channel.GetConditionCategories(ref xmlConditionCategories);
        }
        
        public short GetConditionMasterSet(ref string xmlConditionMasterSet) {
            return base.Channel.GetConditionMasterSet(ref xmlConditionMasterSet);
        }
        
        public short GetConditionSynchronisation(ref string xmlConditionChanges) {
            return base.Channel.GetConditionSynchronisation(ref xmlConditionChanges);
        }
        
        public short SearchInDocuments(string conditionName, string conditionValue, ref string xmlDocuments) {
            return base.Channel.SearchInDocuments(conditionName, conditionValue, ref xmlDocuments);
        }
    }
}
