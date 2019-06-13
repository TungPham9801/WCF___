﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiCaPhe.BanSDNhieuService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BanSDNhieuService.IBanSDNhieuService")]
    public interface IBanSDNhieuService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/DoWork", ReplyAction="http://tempuri.org/IBanSDNhieuService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/DoWork", ReplyAction="http://tempuri.org/IBanSDNhieuService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/kiemTraTonTai", ReplyAction="http://tempuri.org/IBanSDNhieuService/kiemTraTonTaiResponse")]
        bool kiemTraTonTai(string maban);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/kiemTraTonTai", ReplyAction="http://tempuri.org/IBanSDNhieuService/kiemTraTonTaiResponse")]
        System.Threading.Tasks.Task<bool> kiemTraTonTaiAsync(string maban);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/laySoBan", ReplyAction="http://tempuri.org/IBanSDNhieuService/laySoBanResponse")]
        string laySoBan(string maBan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/laySoBan", ReplyAction="http://tempuri.org/IBanSDNhieuService/laySoBanResponse")]
        System.Threading.Tasks.Task<string> laySoBanAsync(string maBan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/layLuotSD", ReplyAction="http://tempuri.org/IBanSDNhieuService/layLuotSDResponse")]
        string layLuotSD(string maBan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/layLuotSD", ReplyAction="http://tempuri.org/IBanSDNhieuService/layLuotSDResponse")]
        System.Threading.Tasks.Task<string> layLuotSDAsync(string maBan);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/ThemBanSDNhieu", ReplyAction="http://tempuri.org/IBanSDNhieuService/ThemBanSDNhieuResponse")]
        bool ThemBanSDNhieu(DTO_QLCP.BanSDNhieu ban);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/ThemBanSDNhieu", ReplyAction="http://tempuri.org/IBanSDNhieuService/ThemBanSDNhieuResponse")]
        System.Threading.Tasks.Task<bool> ThemBanSDNhieuAsync(DTO_QLCP.BanSDNhieu ban);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/SuaLuotSD", ReplyAction="http://tempuri.org/IBanSDNhieuService/SuaLuotSDResponse")]
        bool SuaLuotSD(DTO_QLCP.BanSDNhieu ban);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBanSDNhieuService/SuaLuotSD", ReplyAction="http://tempuri.org/IBanSDNhieuService/SuaLuotSDResponse")]
        System.Threading.Tasks.Task<bool> SuaLuotSDAsync(DTO_QLCP.BanSDNhieu ban);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBanSDNhieuServiceChannel : QuanLiCaPhe.BanSDNhieuService.IBanSDNhieuService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BanSDNhieuServiceClient : System.ServiceModel.ClientBase<QuanLiCaPhe.BanSDNhieuService.IBanSDNhieuService>, QuanLiCaPhe.BanSDNhieuService.IBanSDNhieuService {
        
        public BanSDNhieuServiceClient() {
        }
        
        public BanSDNhieuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BanSDNhieuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanSDNhieuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BanSDNhieuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public bool kiemTraTonTai(string maban) {
            return base.Channel.kiemTraTonTai(maban);
        }
        
        public System.Threading.Tasks.Task<bool> kiemTraTonTaiAsync(string maban) {
            return base.Channel.kiemTraTonTaiAsync(maban);
        }
        
        public string laySoBan(string maBan) {
            return base.Channel.laySoBan(maBan);
        }
        
        public System.Threading.Tasks.Task<string> laySoBanAsync(string maBan) {
            return base.Channel.laySoBanAsync(maBan);
        }
        
        public string layLuotSD(string maBan) {
            return base.Channel.layLuotSD(maBan);
        }
        
        public System.Threading.Tasks.Task<string> layLuotSDAsync(string maBan) {
            return base.Channel.layLuotSDAsync(maBan);
        }
        
        public bool ThemBanSDNhieu(DTO_QLCP.BanSDNhieu ban) {
            return base.Channel.ThemBanSDNhieu(ban);
        }
        
        public System.Threading.Tasks.Task<bool> ThemBanSDNhieuAsync(DTO_QLCP.BanSDNhieu ban) {
            return base.Channel.ThemBanSDNhieuAsync(ban);
        }
        
        public bool SuaLuotSD(DTO_QLCP.BanSDNhieu ban) {
            return base.Channel.SuaLuotSD(ban);
        }
        
        public System.Threading.Tasks.Task<bool> SuaLuotSDAsync(DTO_QLCP.BanSDNhieu ban) {
            return base.Channel.SuaLuotSDAsync(ban);
        }
    }
}
