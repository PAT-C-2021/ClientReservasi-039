﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientReservasi_20190140039.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi_039")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CekLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi_039")]
    [System.SerializableAttribute()]
    public partial class CekLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Deskripsi_SingkatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ID_LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nama_LokasiField;
        
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
        public string Deskripsi_Singkat {
            get {
                return this.Deskripsi_SingkatField;
            }
            set {
                if ((object.ReferenceEquals(this.Deskripsi_SingkatField, value) != true)) {
                    this.Deskripsi_SingkatField = value;
                    this.RaisePropertyChanged("Deskripsi_Singkat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID_Lokasi {
            get {
                return this.ID_LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.ID_LokasiField, value) != true)) {
                    this.ID_LokasiField = value;
                    this.RaisePropertyChanged("ID_Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nama_Lokasi {
            get {
                return this.Nama_LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.Nama_LokasiField, value) != true)) {
                    this.Nama_LokasiField = value;
                    this.RaisePropertyChanged("Nama_Lokasi");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailLokasi", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi_039")]
    [System.SerializableAttribute()]
    public partial class DetailLokasi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeskripsiFullField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ID_LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KoutaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nama_LokasiField;
        
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
        public string DeskripsiFull {
            get {
                return this.DeskripsiFullField;
            }
            set {
                if ((object.ReferenceEquals(this.DeskripsiFullField, value) != true)) {
                    this.DeskripsiFullField = value;
                    this.RaisePropertyChanged("DeskripsiFull");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID_Lokasi {
            get {
                return this.ID_LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.ID_LokasiField, value) != true)) {
                    this.ID_LokasiField = value;
                    this.RaisePropertyChanged("ID_Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kouta {
            get {
                return this.KoutaField;
            }
            set {
                if ((this.KoutaField.Equals(value) != true)) {
                    this.KoutaField = value;
                    this.RaisePropertyChanged("Kouta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nama_Lokasi {
            get {
                return this.Nama_LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.Nama_LokasiField, value) != true)) {
                    this.Nama_LokasiField = value;
                    this.RaisePropertyChanged("Nama_Lokasi");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanann", Namespace="http://schemas.datacontract.org/2004/07/ServiceReservasi_039")]
    [System.SerializableAttribute()]
    public partial class Pemesanann : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ID_LokasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ID_ReservasiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Jumlah_PemesananField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nama_CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string No_TelponField;
        
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
        public string ID_Lokasi {
            get {
                return this.ID_LokasiField;
            }
            set {
                if ((object.ReferenceEquals(this.ID_LokasiField, value) != true)) {
                    this.ID_LokasiField = value;
                    this.RaisePropertyChanged("ID_Lokasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID_Reservasi {
            get {
                return this.ID_ReservasiField;
            }
            set {
                if ((object.ReferenceEquals(this.ID_ReservasiField, value) != true)) {
                    this.ID_ReservasiField = value;
                    this.RaisePropertyChanged("ID_Reservasi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Jumlah_Pemesanan {
            get {
                return this.Jumlah_PemesananField;
            }
            set {
                if ((this.Jumlah_PemesananField.Equals(value) != true)) {
                    this.Jumlah_PemesananField = value;
                    this.RaisePropertyChanged("Jumlah_Pemesanan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nama_Customer {
            get {
                return this.Nama_CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.Nama_CustomerField, value) != true)) {
                    this.Nama_CustomerField = value;
                    this.RaisePropertyChanged("Nama_Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string No_Telpon {
            get {
                return this.No_TelponField;
            }
            set {
                if ((object.ReferenceEquals(this.No_TelponField, value) != true)) {
                    this.No_TelponField = value;
                    this.RaisePropertyChanged("No_Telpon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ClientReservasi_20190140039.ServiceReference1.CompositeType GetDataUsingDataContract(ClientReservasi_20190140039.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ClientReservasi_20190140039.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanann", ReplyAction="http://tempuri.org/IService1/PemesanannResponse")]
        string Pemesanann(string ID_Reservasi, string Nama_Customer, string No_Telpon, int Jumlah_Pemesanan, string ID_Lokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanann", ReplyAction="http://tempuri.org/IService1/PemesanannResponse")]
        System.Threading.Tasks.Task<string> PemesanannAsync(string ID_Reservasi, string Nama_Customer, string No_Telpon, int Jumlah_Pemesanan, string ID_Lokasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string ID_Reservasi, string Nama_Customer, string No_Telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string ID_Reservasi, string Nama_Customer, string No_Telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string ID_Reservasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string ID_Reservasi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        ClientReservasi_20190140039.ServiceReference1.CekLokasi[] ReviewLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ReviewLokasi", ReplyAction="http://tempuri.org/IService1/ReviewLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.CekLokasi[]> ReviewLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        ClientReservasi_20190140039.ServiceReference1.DetailLokasi[] DetailLokasi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DetailLokasi", ReplyAction="http://tempuri.org/IService1/DetailLokasiResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.DetailLokasi[]> DetailLokasiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientReservasi_20190140039.ServiceReference1.Pemesanann[] Pemesanan();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.Pemesanann[]> PemesananAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientReservasi_20190140039.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientReservasi_20190140039.ServiceReference1.IService1>, ClientReservasi_20190140039.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ClientReservasi_20190140039.ServiceReference1.CompositeType GetDataUsingDataContract(ClientReservasi_20190140039.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ClientReservasi_20190140039.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string Pemesanann(string ID_Reservasi, string Nama_Customer, string No_Telpon, int Jumlah_Pemesanan, string ID_Lokasi) {
            return base.Channel.Pemesanann(ID_Reservasi, Nama_Customer, No_Telpon, Jumlah_Pemesanan, ID_Lokasi);
        }
        
        public System.Threading.Tasks.Task<string> PemesanannAsync(string ID_Reservasi, string Nama_Customer, string No_Telpon, int Jumlah_Pemesanan, string ID_Lokasi) {
            return base.Channel.PemesanannAsync(ID_Reservasi, Nama_Customer, No_Telpon, Jumlah_Pemesanan, ID_Lokasi);
        }
        
        public string editPemesanan(string ID_Reservasi, string Nama_Customer, string No_Telpon) {
            return base.Channel.editPemesanan(ID_Reservasi, Nama_Customer, No_Telpon);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string ID_Reservasi, string Nama_Customer, string No_Telpon) {
            return base.Channel.editPemesananAsync(ID_Reservasi, Nama_Customer, No_Telpon);
        }
        
        public string deletePemesanan(string ID_Reservasi) {
            return base.Channel.deletePemesanan(ID_Reservasi);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string ID_Reservasi) {
            return base.Channel.deletePemesananAsync(ID_Reservasi);
        }
        
        public ClientReservasi_20190140039.ServiceReference1.CekLokasi[] ReviewLokasi() {
            return base.Channel.ReviewLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.CekLokasi[]> ReviewLokasiAsync() {
            return base.Channel.ReviewLokasiAsync();
        }
        
        public ClientReservasi_20190140039.ServiceReference1.DetailLokasi[] DetailLokasi() {
            return base.Channel.DetailLokasi();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.DetailLokasi[]> DetailLokasiAsync() {
            return base.Channel.DetailLokasiAsync();
        }
        
        public ClientReservasi_20190140039.ServiceReference1.Pemesanann[] Pemesanan() {
            return base.Channel.Pemesanan();
        }
        
        public System.Threading.Tasks.Task<ClientReservasi_20190140039.ServiceReference1.Pemesanann[]> PemesananAsync() {
            return base.Channel.PemesananAsync();
        }
    }
}
