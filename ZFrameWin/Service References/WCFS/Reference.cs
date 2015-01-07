﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZFrameWin.WCFS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="WCFS.WCFServices")]
    public interface WCFServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFServices/GetCheckCodeImage", ReplyAction="urn:WCFServices/GetCheckCodeImageResponse")]
        System.IO.Stream GetCheckCodeImage(string VCode);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFServices/GetCheckCodeImage", ReplyAction="urn:WCFServices/GetCheckCodeImageResponse")]
        System.IAsyncResult BeginGetCheckCodeImage(string VCode, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetCheckCodeImage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFServices/GetListUsers", ReplyAction="urn:WCFServices/GetListUsersResponse")]
        System.IO.Stream GetListUsers(string LoginName, string LoginPWD);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFServices/GetListUsers", ReplyAction="urn:WCFServices/GetListUsersResponse")]
        System.IAsyncResult BeginGetListUsers(string LoginName, string LoginPWD, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetListUsers(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFServices/GetServerDateTime", ReplyAction="urn:WCFServices/GetServerDateTimeResponse")]
        System.IO.Stream GetServerDateTime();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFServices/GetServerDateTime", ReplyAction="urn:WCFServices/GetServerDateTimeResponse")]
        System.IAsyncResult BeginGetServerDateTime(System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndGetServerDateTime(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:WCFServices/Login_UserCheck", ReplyAction="urn:WCFServices/Login_UserCheckResponse")]
        System.IO.Stream Login_UserCheck(string CheckCode, string UserName, string PassWord, string ChooseDept);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:WCFServices/Login_UserCheck", ReplyAction="urn:WCFServices/Login_UserCheckResponse")]
        System.IAsyncResult BeginLogin_UserCheck(string CheckCode, string UserName, string PassWord, string ChooseDept, System.AsyncCallback callback, object asyncState);
        
        System.IO.Stream EndLogin_UserCheck(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFServicesChannel : ZFrameWin.WCFS.WCFServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCheckCodeImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCheckCodeImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetListUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetListUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetServerDateTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetServerDateTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Login_UserCheckCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public Login_UserCheckCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.IO.Stream Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.IO.Stream)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFServicesClient : System.ServiceModel.ClientBase<ZFrameWin.WCFS.WCFServices>, ZFrameWin.WCFS.WCFServices {
        
        private BeginOperationDelegate onBeginGetCheckCodeImageDelegate;
        
        private EndOperationDelegate onEndGetCheckCodeImageDelegate;
        
        private System.Threading.SendOrPostCallback onGetCheckCodeImageCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetListUsersDelegate;
        
        private EndOperationDelegate onEndGetListUsersDelegate;
        
        private System.Threading.SendOrPostCallback onGetListUsersCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetServerDateTimeDelegate;
        
        private EndOperationDelegate onEndGetServerDateTimeDelegate;
        
        private System.Threading.SendOrPostCallback onGetServerDateTimeCompletedDelegate;
        
        private BeginOperationDelegate onBeginLogin_UserCheckDelegate;
        
        private EndOperationDelegate onEndLogin_UserCheckDelegate;
        
        private System.Threading.SendOrPostCallback onLogin_UserCheckCompletedDelegate;
        
        public WCFServicesClient() {
        }
        
        public WCFServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetCheckCodeImageCompletedEventArgs> GetCheckCodeImageCompleted;
        
        public event System.EventHandler<GetListUsersCompletedEventArgs> GetListUsersCompleted;
        
        public event System.EventHandler<GetServerDateTimeCompletedEventArgs> GetServerDateTimeCompleted;
        
        public event System.EventHandler<Login_UserCheckCompletedEventArgs> Login_UserCheckCompleted;
        
        public System.IO.Stream GetCheckCodeImage(string VCode) {
            return base.Channel.GetCheckCodeImage(VCode);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetCheckCodeImage(string VCode, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCheckCodeImage(VCode, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetCheckCodeImage(System.IAsyncResult result) {
            return base.Channel.EndGetCheckCodeImage(result);
        }
        
        private System.IAsyncResult OnBeginGetCheckCodeImage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string VCode = ((string)(inValues[0]));
            return this.BeginGetCheckCodeImage(VCode, callback, asyncState);
        }
        
        private object[] OnEndGetCheckCodeImage(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetCheckCodeImage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCheckCodeImageCompleted(object state) {
            if ((this.GetCheckCodeImageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCheckCodeImageCompleted(this, new GetCheckCodeImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCheckCodeImageAsync(string VCode) {
            this.GetCheckCodeImageAsync(VCode, null);
        }
        
        public void GetCheckCodeImageAsync(string VCode, object userState) {
            if ((this.onBeginGetCheckCodeImageDelegate == null)) {
                this.onBeginGetCheckCodeImageDelegate = new BeginOperationDelegate(this.OnBeginGetCheckCodeImage);
            }
            if ((this.onEndGetCheckCodeImageDelegate == null)) {
                this.onEndGetCheckCodeImageDelegate = new EndOperationDelegate(this.OnEndGetCheckCodeImage);
            }
            if ((this.onGetCheckCodeImageCompletedDelegate == null)) {
                this.onGetCheckCodeImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCheckCodeImageCompleted);
            }
            base.InvokeAsync(this.onBeginGetCheckCodeImageDelegate, new object[] {
                        VCode}, this.onEndGetCheckCodeImageDelegate, this.onGetCheckCodeImageCompletedDelegate, userState);
        }
        
        public System.IO.Stream GetListUsers(string LoginName, string LoginPWD) {
            return base.Channel.GetListUsers(LoginName, LoginPWD);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetListUsers(string LoginName, string LoginPWD, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetListUsers(LoginName, LoginPWD, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetListUsers(System.IAsyncResult result) {
            return base.Channel.EndGetListUsers(result);
        }
        
        private System.IAsyncResult OnBeginGetListUsers(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string LoginName = ((string)(inValues[0]));
            string LoginPWD = ((string)(inValues[1]));
            return this.BeginGetListUsers(LoginName, LoginPWD, callback, asyncState);
        }
        
        private object[] OnEndGetListUsers(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetListUsers(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetListUsersCompleted(object state) {
            if ((this.GetListUsersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetListUsersCompleted(this, new GetListUsersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetListUsersAsync(string LoginName, string LoginPWD) {
            this.GetListUsersAsync(LoginName, LoginPWD, null);
        }
        
        public void GetListUsersAsync(string LoginName, string LoginPWD, object userState) {
            if ((this.onBeginGetListUsersDelegate == null)) {
                this.onBeginGetListUsersDelegate = new BeginOperationDelegate(this.OnBeginGetListUsers);
            }
            if ((this.onEndGetListUsersDelegate == null)) {
                this.onEndGetListUsersDelegate = new EndOperationDelegate(this.OnEndGetListUsers);
            }
            if ((this.onGetListUsersCompletedDelegate == null)) {
                this.onGetListUsersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetListUsersCompleted);
            }
            base.InvokeAsync(this.onBeginGetListUsersDelegate, new object[] {
                        LoginName,
                        LoginPWD}, this.onEndGetListUsersDelegate, this.onGetListUsersCompletedDelegate, userState);
        }
        
        public System.IO.Stream GetServerDateTime() {
            return base.Channel.GetServerDateTime();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetServerDateTime(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetServerDateTime(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndGetServerDateTime(System.IAsyncResult result) {
            return base.Channel.EndGetServerDateTime(result);
        }
        
        private System.IAsyncResult OnBeginGetServerDateTime(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetServerDateTime(callback, asyncState);
        }
        
        private object[] OnEndGetServerDateTime(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndGetServerDateTime(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetServerDateTimeCompleted(object state) {
            if ((this.GetServerDateTimeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetServerDateTimeCompleted(this, new GetServerDateTimeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetServerDateTimeAsync() {
            this.GetServerDateTimeAsync(null);
        }
        
        public void GetServerDateTimeAsync(object userState) {
            if ((this.onBeginGetServerDateTimeDelegate == null)) {
                this.onBeginGetServerDateTimeDelegate = new BeginOperationDelegate(this.OnBeginGetServerDateTime);
            }
            if ((this.onEndGetServerDateTimeDelegate == null)) {
                this.onEndGetServerDateTimeDelegate = new EndOperationDelegate(this.OnEndGetServerDateTime);
            }
            if ((this.onGetServerDateTimeCompletedDelegate == null)) {
                this.onGetServerDateTimeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetServerDateTimeCompleted);
            }
            base.InvokeAsync(this.onBeginGetServerDateTimeDelegate, null, this.onEndGetServerDateTimeDelegate, this.onGetServerDateTimeCompletedDelegate, userState);
        }
        
        public System.IO.Stream Login_UserCheck(string CheckCode, string UserName, string PassWord, string ChooseDept) {
            return base.Channel.Login_UserCheck(CheckCode, UserName, PassWord, ChooseDept);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginLogin_UserCheck(string CheckCode, string UserName, string PassWord, string ChooseDept, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginLogin_UserCheck(CheckCode, UserName, PassWord, ChooseDept, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IO.Stream EndLogin_UserCheck(System.IAsyncResult result) {
            return base.Channel.EndLogin_UserCheck(result);
        }
        
        private System.IAsyncResult OnBeginLogin_UserCheck(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string CheckCode = ((string)(inValues[0]));
            string UserName = ((string)(inValues[1]));
            string PassWord = ((string)(inValues[2]));
            string ChooseDept = ((string)(inValues[3]));
            return this.BeginLogin_UserCheck(CheckCode, UserName, PassWord, ChooseDept, callback, asyncState);
        }
        
        private object[] OnEndLogin_UserCheck(System.IAsyncResult result) {
            System.IO.Stream retVal = this.EndLogin_UserCheck(result);
            return new object[] {
                    retVal};
        }
        
        private void OnLogin_UserCheckCompleted(object state) {
            if ((this.Login_UserCheckCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Login_UserCheckCompleted(this, new Login_UserCheckCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Login_UserCheckAsync(string CheckCode, string UserName, string PassWord, string ChooseDept) {
            this.Login_UserCheckAsync(CheckCode, UserName, PassWord, ChooseDept, null);
        }
        
        public void Login_UserCheckAsync(string CheckCode, string UserName, string PassWord, string ChooseDept, object userState) {
            if ((this.onBeginLogin_UserCheckDelegate == null)) {
                this.onBeginLogin_UserCheckDelegate = new BeginOperationDelegate(this.OnBeginLogin_UserCheck);
            }
            if ((this.onEndLogin_UserCheckDelegate == null)) {
                this.onEndLogin_UserCheckDelegate = new EndOperationDelegate(this.OnEndLogin_UserCheck);
            }
            if ((this.onLogin_UserCheckCompletedDelegate == null)) {
                this.onLogin_UserCheckCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnLogin_UserCheckCompleted);
            }
            base.InvokeAsync(this.onBeginLogin_UserCheckDelegate, new object[] {
                        CheckCode,
                        UserName,
                        PassWord,
                        ChooseDept}, this.onEndLogin_UserCheckDelegate, this.onLogin_UserCheckCompletedDelegate, userState);
        }
    }
}
