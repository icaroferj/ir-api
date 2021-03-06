﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.0.
// 
#pragma warning disable 1591

namespace IRLib.wsCEP {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BuscaCEPSoap", Namespace="http://www.ingressorapido.com.br/BuscaCEP")]
    public partial class BuscaCEP : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback BuscarEnderecoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEnderecoOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetEnderecoEstruturadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BuscaCEP() {
            this.Url = global::IRLib.Properties.Settings.Default.IRLib_wsCEP_BuscaCEP;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event BuscarEnderecoCompletedEventHandler BuscarEnderecoCompleted;
        
        /// <remarks/>
        public event GetEnderecoCompletedEventHandler GetEnderecoCompleted;
        
        /// <remarks/>
        public event GetEnderecoEstruturadoCompletedEventHandler GetEnderecoEstruturadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ingressorapido.com.br/BuscaCEP/BuscarEndereco", RequestNamespace="http://www.ingressorapido.com.br/BuscaCEP", ResponseNamespace="http://www.ingressorapido.com.br/BuscaCEP", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet BuscarEndereco(string cep) {
            object[] results = this.Invoke("BuscarEndereco", new object[] {
                        cep});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarEnderecoAsync(string cep) {
            this.BuscarEnderecoAsync(cep, null);
        }
        
        /// <remarks/>
        public void BuscarEnderecoAsync(string cep, object userState) {
            if ((this.BuscarEnderecoOperationCompleted == null)) {
                this.BuscarEnderecoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarEnderecoOperationCompleted);
            }
            this.InvokeAsync("BuscarEndereco", new object[] {
                        cep}, this.BuscarEnderecoOperationCompleted, userState);
        }
        
        private void OnBuscarEnderecoOperationCompleted(object arg) {
            if ((this.BuscarEnderecoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarEnderecoCompleted(this, new BuscarEnderecoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ingressorapido.com.br/BuscaCEP/GetEndereco", RequestNamespace="http://www.ingressorapido.com.br/BuscaCEP", ResponseNamespace="http://www.ingressorapido.com.br/BuscaCEP", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetEndereco(string usuario, string senha, string cep) {
            object[] results = this.Invoke("GetEndereco", new object[] {
                        usuario,
                        senha,
                        cep});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetEnderecoAsync(string usuario, string senha, string cep) {
            this.GetEnderecoAsync(usuario, senha, cep, null);
        }
        
        /// <remarks/>
        public void GetEnderecoAsync(string usuario, string senha, string cep, object userState) {
            if ((this.GetEnderecoOperationCompleted == null)) {
                this.GetEnderecoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEnderecoOperationCompleted);
            }
            this.InvokeAsync("GetEndereco", new object[] {
                        usuario,
                        senha,
                        cep}, this.GetEnderecoOperationCompleted, userState);
        }
        
        private void OnGetEnderecoOperationCompleted(object arg) {
            if ((this.GetEnderecoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEnderecoCompleted(this, new GetEnderecoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.ingressorapido.com.br/BuscaCEP/GetEnderecoEstruturado", RequestNamespace="http://www.ingressorapido.com.br/BuscaCEP", ResponseNamespace="http://www.ingressorapido.com.br/BuscaCEP", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public EstruturaCEP GetEnderecoEstruturado(string usuario, string senha, string cep) {
            object[] results = this.Invoke("GetEnderecoEstruturado", new object[] {
                        usuario,
                        senha,
                        cep});
            return ((EstruturaCEP)(results[0]));
        }
        
        /// <remarks/>
        public void GetEnderecoEstruturadoAsync(string usuario, string senha, string cep) {
            this.GetEnderecoEstruturadoAsync(usuario, senha, cep, null);
        }
        
        /// <remarks/>
        public void GetEnderecoEstruturadoAsync(string usuario, string senha, string cep, object userState) {
            if ((this.GetEnderecoEstruturadoOperationCompleted == null)) {
                this.GetEnderecoEstruturadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetEnderecoEstruturadoOperationCompleted);
            }
            this.InvokeAsync("GetEnderecoEstruturado", new object[] {
                        usuario,
                        senha,
                        cep}, this.GetEnderecoEstruturadoOperationCompleted, userState);
        }
        
        private void OnGetEnderecoEstruturadoOperationCompleted(object arg) {
            if ((this.GetEnderecoEstruturadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetEnderecoEstruturadoCompleted(this, new GetEnderecoEstruturadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ingressorapido.com.br/BuscaCEP")]
    public partial class EstruturaCEP {
        
        private string ruaField;
        
        private string bairroField;
        
        private string cidadeField;
        
        private string estadoField;
        
        /// <remarks/>
        public string Rua {
            get {
                return this.ruaField;
            }
            set {
                this.ruaField = value;
            }
        }
        
        /// <remarks/>
        public string Bairro {
            get {
                return this.bairroField;
            }
            set {
                this.bairroField = value;
            }
        }
        
        /// <remarks/>
        public string Cidade {
            get {
                return this.cidadeField;
            }
            set {
                this.cidadeField = value;
            }
        }
        
        /// <remarks/>
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    public delegate void BuscarEnderecoCompletedEventHandler(object sender, BuscarEnderecoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarEnderecoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarEnderecoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    public delegate void GetEnderecoCompletedEventHandler(object sender, GetEnderecoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEnderecoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEnderecoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    public delegate void GetEnderecoEstruturadoCompletedEventHandler(object sender, GetEnderecoEstruturadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetEnderecoEstruturadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetEnderecoEstruturadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public EstruturaCEP Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((EstruturaCEP)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591