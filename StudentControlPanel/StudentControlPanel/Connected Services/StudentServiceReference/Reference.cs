﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentControlPanel.StudentServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentServiceReference.StudentWebServiceSoap")]
    public interface StudentWebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hello", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Hello();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Hello", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NoteEntry", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void NoteEntry(string ogrNo, string vize, string final, string sonuc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NoteEntry", ReplyAction="*")]
        System.Threading.Tasks.Task NoteEntryAsync(string ogrNo, string vize, string final, string sonuc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NoteDelete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void NoteDelete(string ogrNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NoteDelete", ReplyAction="*")]
        System.Threading.Tasks.Task NoteDeleteAsync(string ogrNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NoteList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet NoteList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NoteList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> NoteListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteStudent", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteStudent(string ogrNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteStudent", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteStudentAsync(string ogrNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StudentList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet StudentList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StudentList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> StudentListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet FindName(string ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindName", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> FindNameAsync(string ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindNo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet FindNo(string ogrNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindNo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> FindNoAsync(string ogrNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindTc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet FindTc(string tcNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindTc", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> FindTcAsync(string tcNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OgrenciKayit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void OgrenciKayit(string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OgrenciKayit", ReplyAction="*")]
        System.Threading.Tasks.Task OgrenciKayitAsync(string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateList(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateList", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateListAsync(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateChoose", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateChoose(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateChoose", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateChooseAsync(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateButton", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateButton(string ad, string soyad, string ogrNo, string tcNo, string telNo, string mail, object students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateButton", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateButtonAsync(string ad, string soyad, string ogrNo, string tcNo, string telNo, string mail, object students);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginScreen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void LoginScreen(string loginId, string message, string loginPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginScreen", ReplyAction="*")]
        System.Threading.Tasks.Task LoginScreenAsync(string loginId, string message, string loginPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginConnect", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void LoginConnect(string message, string loginId, string loginPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LoginConnect", ReplyAction="*")]
        System.Threading.Tasks.Task LoginConnectAsync(string message, string loginId, string loginPassword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StudentWebServiceSoapChannel : StudentControlPanel.StudentServiceReference.StudentWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentWebServiceSoapClient : System.ServiceModel.ClientBase<StudentControlPanel.StudentServiceReference.StudentWebServiceSoap>, StudentControlPanel.StudentServiceReference.StudentWebServiceSoap {
        
        public StudentWebServiceSoapClient() {
        }
        
        public StudentWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Hello() {
            return base.Channel.Hello();
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync() {
            return base.Channel.HelloAsync();
        }
        
        public void NoteEntry(string ogrNo, string vize, string final, string sonuc) {
            base.Channel.NoteEntry(ogrNo, vize, final, sonuc);
        }
        
        public System.Threading.Tasks.Task NoteEntryAsync(string ogrNo, string vize, string final, string sonuc) {
            return base.Channel.NoteEntryAsync(ogrNo, vize, final, sonuc);
        }
        
        public void NoteDelete(string ogrNo) {
            base.Channel.NoteDelete(ogrNo);
        }
        
        public System.Threading.Tasks.Task NoteDeleteAsync(string ogrNo) {
            return base.Channel.NoteDeleteAsync(ogrNo);
        }
        
        public System.Data.DataSet NoteList() {
            return base.Channel.NoteList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> NoteListAsync() {
            return base.Channel.NoteListAsync();
        }
        
        public void DeleteStudent(string ogrNo) {
            base.Channel.DeleteStudent(ogrNo);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(string ogrNo) {
            return base.Channel.DeleteStudentAsync(ogrNo);
        }
        
        public System.Data.DataSet StudentList() {
            return base.Channel.StudentList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> StudentListAsync() {
            return base.Channel.StudentListAsync();
        }
        
        public System.Data.DataSet FindName(string ad) {
            return base.Channel.FindName(ad);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FindNameAsync(string ad) {
            return base.Channel.FindNameAsync(ad);
        }
        
        public System.Data.DataSet FindNo(string ogrNo) {
            return base.Channel.FindNo(ogrNo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FindNoAsync(string ogrNo) {
            return base.Channel.FindNoAsync(ogrNo);
        }
        
        public System.Data.DataSet FindTc(string tcNo) {
            return base.Channel.FindTc(tcNo);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> FindTcAsync(string tcNo) {
            return base.Channel.FindTcAsync(tcNo);
        }
        
        public void OgrenciKayit(string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail) {
            base.Channel.OgrenciKayit(ad, soyad, ogrNo, tcNo, telefon, mail);
        }
        
        public System.Threading.Tasks.Task OgrenciKayitAsync(string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail) {
            return base.Channel.OgrenciKayitAsync(ad, soyad, ogrNo, tcNo, telefon, mail);
        }
        
        public void UpdateList(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail) {
            base.Channel.UpdateList(ID, ad, soyad, ogrNo, tcNo, telefon, mail);
        }
        
        public System.Threading.Tasks.Task UpdateListAsync(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail) {
            return base.Channel.UpdateListAsync(ID, ad, soyad, ogrNo, tcNo, telefon, mail);
        }
        
        public void UpdateChoose(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail) {
            base.Channel.UpdateChoose(ID, ad, soyad, ogrNo, tcNo, telefon, mail);
        }
        
        public System.Threading.Tasks.Task UpdateChooseAsync(string ID, string ad, string soyad, string ogrNo, string tcNo, string telefon, string mail) {
            return base.Channel.UpdateChooseAsync(ID, ad, soyad, ogrNo, tcNo, telefon, mail);
        }
        
        public void UpdateButton(string ad, string soyad, string ogrNo, string tcNo, string telNo, string mail, object students) {
            base.Channel.UpdateButton(ad, soyad, ogrNo, tcNo, telNo, mail, students);
        }
        
        public System.Threading.Tasks.Task UpdateButtonAsync(string ad, string soyad, string ogrNo, string tcNo, string telNo, string mail, object students) {
            return base.Channel.UpdateButtonAsync(ad, soyad, ogrNo, tcNo, telNo, mail, students);
        }
        
        public void LoginScreen(string loginId, string message, string loginPassword) {
            base.Channel.LoginScreen(loginId, message, loginPassword);
        }
        
        public System.Threading.Tasks.Task LoginScreenAsync(string loginId, string message, string loginPassword) {
            return base.Channel.LoginScreenAsync(loginId, message, loginPassword);
        }
        
        public void LoginConnect(string message, string loginId, string loginPassword) {
            base.Channel.LoginConnect(message, loginId, loginPassword);
        }
        
        public System.Threading.Tasks.Task LoginConnectAsync(string message, string loginId, string loginPassword) {
            return base.Channel.LoginConnectAsync(message, loginId, loginPassword);
        }
    }
}