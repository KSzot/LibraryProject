﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserInterface.Api {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Klienci", Namespace="http://schemas.datacontract.org/2004/07/LibraryApi")]
    [System.SerializableAttribute()]
    public partial class Klienci : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDKlientaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwiskoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlecField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> WiekField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDKlienta {
            get {
                return this.IDKlientaField;
            }
            set {
                if ((this.IDKlientaField.Equals(value) != true)) {
                    this.IDKlientaField = value;
                    this.RaisePropertyChanged("IDKlienta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imie {
            get {
                return this.ImieField;
            }
            set {
                if ((object.ReferenceEquals(this.ImieField, value) != true)) {
                    this.ImieField = value;
                    this.RaisePropertyChanged("Imie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwisko {
            get {
                return this.NazwiskoField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwiskoField, value) != true)) {
                    this.NazwiskoField = value;
                    this.RaisePropertyChanged("Nazwisko");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Plec {
            get {
                return this.PlecField;
            }
            set {
                if ((object.ReferenceEquals(this.PlecField, value) != true)) {
                    this.PlecField = value;
                    this.RaisePropertyChanged("Plec");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefon {
            get {
                return this.TelefonField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonField, value) != true)) {
                    this.TelefonField = value;
                    this.RaisePropertyChanged("Telefon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Wiek {
            get {
                return this.WiekField;
            }
            set {
                if ((this.WiekField.Equals(value) != true)) {
                    this.WiekField = value;
                    this.RaisePropertyChanged("Wiek");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ksiazka", Namespace="http://schemas.datacontract.org/2004/07/LibraryApi")]
    [System.SerializableAttribute()]
    public partial class Ksiazka : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDKsiazkiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UserInterface.Api.KsiazkaAutor KsiazkaAutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TytulField;
        
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
        public int IDKsiazki {
            get {
                return this.IDKsiazkiField;
            }
            set {
                if ((this.IDKsiazkiField.Equals(value) != true)) {
                    this.IDKsiazkiField = value;
                    this.RaisePropertyChanged("IDKsiazki");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserInterface.Api.KsiazkaAutor KsiazkaAutor {
            get {
                return this.KsiazkaAutorField;
            }
            set {
                if ((object.ReferenceEquals(this.KsiazkaAutorField, value) != true)) {
                    this.KsiazkaAutorField = value;
                    this.RaisePropertyChanged("KsiazkaAutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tytul {
            get {
                return this.TytulField;
            }
            set {
                if ((object.ReferenceEquals(this.TytulField, value) != true)) {
                    this.TytulField = value;
                    this.RaisePropertyChanged("Tytul");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="KsiazkaAutor", Namespace="http://schemas.datacontract.org/2004/07/LibraryApi")]
    [System.SerializableAttribute()]
    public partial class KsiazkaAutor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UserInterface.Api.Autor AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDAutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDKsiazkaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UserInterface.Api.Ksiazka KsiazkaField;
        
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
        public UserInterface.Api.Autor Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDAutor {
            get {
                return this.IDAutorField;
            }
            set {
                if ((this.IDAutorField.Equals(value) != true)) {
                    this.IDAutorField = value;
                    this.RaisePropertyChanged("IDAutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDKsiazka {
            get {
                return this.IDKsiazkaField;
            }
            set {
                if ((this.IDKsiazkaField.Equals(value) != true)) {
                    this.IDKsiazkaField = value;
                    this.RaisePropertyChanged("IDKsiazka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserInterface.Api.Ksiazka Ksiazka {
            get {
                return this.KsiazkaField;
            }
            set {
                if ((object.ReferenceEquals(this.KsiazkaField, value) != true)) {
                    this.KsiazkaField = value;
                    this.RaisePropertyChanged("Ksiazka");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Autor", Namespace="http://schemas.datacontract.org/2004/07/LibraryApi")]
    [System.SerializableAttribute()]
    public partial class Autor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDAutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private UserInterface.Api.KsiazkaAutor[] KsiazkaAutorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwiskoField;
        
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
        public int IDAutor {
            get {
                return this.IDAutorField;
            }
            set {
                if ((this.IDAutorField.Equals(value) != true)) {
                    this.IDAutorField = value;
                    this.RaisePropertyChanged("IDAutor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imie {
            get {
                return this.ImieField;
            }
            set {
                if ((object.ReferenceEquals(this.ImieField, value) != true)) {
                    this.ImieField = value;
                    this.RaisePropertyChanged("Imie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserInterface.Api.KsiazkaAutor[] KsiazkaAutors {
            get {
                return this.KsiazkaAutorsField;
            }
            set {
                if ((object.ReferenceEquals(this.KsiazkaAutorsField, value) != true)) {
                    this.KsiazkaAutorsField = value;
                    this.RaisePropertyChanged("KsiazkaAutors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwisko {
            get {
                return this.NazwiskoField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwiskoField, value) != true)) {
                    this.NazwiskoField = value;
                    this.RaisePropertyChanged("Nazwisko");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Api.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddClientToDatabase", ReplyAction="http://tempuri.org/ILibraryService/AddClientToDatabaseResponse")]
        string AddClientToDatabase(UserInterface.Api.Klienci client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddClientToDatabase", ReplyAction="http://tempuri.org/ILibraryService/AddClientToDatabaseResponse")]
        System.Threading.Tasks.Task<string> AddClientToDatabaseAsync(UserInterface.Api.Klienci client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetLastClient", ReplyAction="http://tempuri.org/ILibraryService/GetLastClientResponse")]
        UserInterface.Api.Klienci GetLastClient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetLastClient", ReplyAction="http://tempuri.org/ILibraryService/GetLastClientResponse")]
        System.Threading.Tasks.Task<UserInterface.Api.Klienci> GetLastClientAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/FetchClientAfterID", ReplyAction="http://tempuri.org/ILibraryService/FetchClientAfterIDResponse")]
        UserInterface.Api.Klienci FetchClientAfterID(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/FetchClientAfterID", ReplyAction="http://tempuri.org/ILibraryService/FetchClientAfterIDResponse")]
        System.Threading.Tasks.Task<UserInterface.Api.Klienci> FetchClientAfterIDAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/ModifyClient", ReplyAction="http://tempuri.org/ILibraryService/ModifyClientResponse")]
        void ModifyClient(UserInterface.Api.Klienci client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/ModifyClient", ReplyAction="http://tempuri.org/ILibraryService/ModifyClientResponse")]
        System.Threading.Tasks.Task ModifyClientAsync(UserInterface.Api.Klienci client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteClientAfterID", ReplyAction="http://tempuri.org/ILibraryService/DeleteClientAfterIDResponse")]
        void DeleteClientAfterID(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/DeleteClientAfterID", ReplyAction="http://tempuri.org/ILibraryService/DeleteClientAfterIDResponse")]
        System.Threading.Tasks.Task DeleteClientAfterIDAsync(int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAllClient", ReplyAction="http://tempuri.org/ILibraryService/GetAllClientResponse")]
        UserInterface.Api.Klienci[] GetAllClient();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAllClient", ReplyAction="http://tempuri.org/ILibraryService/GetAllClientResponse")]
        System.Threading.Tasks.Task<UserInterface.Api.Klienci[]> GetAllClientAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAllBooks", ReplyAction="http://tempuri.org/ILibraryService/GetAllBooksResponse")]
        UserInterface.Api.Ksiazka[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetAllBooks", ReplyAction="http://tempuri.org/ILibraryService/GetAllBooksResponse")]
        System.Threading.Tasks.Task<UserInterface.Api.Ksiazka[]> GetAllBooksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : UserInterface.Api.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<UserInterface.Api.ILibraryService>, UserInterface.Api.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddClientToDatabase(UserInterface.Api.Klienci client) {
            return base.Channel.AddClientToDatabase(client);
        }
        
        public System.Threading.Tasks.Task<string> AddClientToDatabaseAsync(UserInterface.Api.Klienci client) {
            return base.Channel.AddClientToDatabaseAsync(client);
        }
        
        public UserInterface.Api.Klienci GetLastClient() {
            return base.Channel.GetLastClient();
        }
        
        public System.Threading.Tasks.Task<UserInterface.Api.Klienci> GetLastClientAsync() {
            return base.Channel.GetLastClientAsync();
        }
        
        public UserInterface.Api.Klienci FetchClientAfterID(int index) {
            return base.Channel.FetchClientAfterID(index);
        }
        
        public System.Threading.Tasks.Task<UserInterface.Api.Klienci> FetchClientAfterIDAsync(int index) {
            return base.Channel.FetchClientAfterIDAsync(index);
        }
        
        public void ModifyClient(UserInterface.Api.Klienci client) {
            base.Channel.ModifyClient(client);
        }
        
        public System.Threading.Tasks.Task ModifyClientAsync(UserInterface.Api.Klienci client) {
            return base.Channel.ModifyClientAsync(client);
        }
        
        public void DeleteClientAfterID(int index) {
            base.Channel.DeleteClientAfterID(index);
        }
        
        public System.Threading.Tasks.Task DeleteClientAfterIDAsync(int index) {
            return base.Channel.DeleteClientAfterIDAsync(index);
        }
        
        public UserInterface.Api.Klienci[] GetAllClient() {
            return base.Channel.GetAllClient();
        }
        
        public System.Threading.Tasks.Task<UserInterface.Api.Klienci[]> GetAllClientAsync() {
            return base.Channel.GetAllClientAsync();
        }
        
        public UserInterface.Api.Ksiazka[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<UserInterface.Api.Ksiazka[]> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
    }
}
