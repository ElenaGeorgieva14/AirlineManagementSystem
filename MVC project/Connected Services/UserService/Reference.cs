﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_project.UserService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUser")]
    public interface IUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUsers", ReplyAction="http://tempuri.org/IUser/GetUsersResponse")]
        AppService.DTOs.UserDTO[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUsers", ReplyAction="http://tempuri.org/IUser/GetUsersResponse")]
        System.Threading.Tasks.Task<AppService.DTOs.UserDTO[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUsersByJob", ReplyAction="http://tempuri.org/IUser/GetUsersByJobResponse")]
        AppService.DTOs.UserDTO[] GetUsersByJob(string job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUsersByJob", ReplyAction="http://tempuri.org/IUser/GetUsersByJobResponse")]
        System.Threading.Tasks.Task<AppService.DTOs.UserDTO[]> GetUsersByJobAsync(string job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserById", ReplyAction="http://tempuri.org/IUser/GetUserByIdResponse")]
        AppService.DTOs.UserDTO GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserById", ReplyAction="http://tempuri.org/IUser/GetUserByIdResponse")]
        System.Threading.Tasks.Task<AppService.DTOs.UserDTO> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/PostUser", ReplyAction="http://tempuri.org/IUser/PostUserResponse")]
        string PostUser(AppService.DTOs.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/PostUser", ReplyAction="http://tempuri.org/IUser/PostUserResponse")]
        System.Threading.Tasks.Task<string> PostUserAsync(AppService.DTOs.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/DeleteUser", ReplyAction="http://tempuri.org/IUser/DeleteUserResponse")]
        string DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/DeleteUser", ReplyAction="http://tempuri.org/IUser/DeleteUserResponse")]
        System.Threading.Tasks.Task<string> DeleteUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/UpdateUser", ReplyAction="http://tempuri.org/IUser/UpdateUserResponse")]
        string UpdateUser(AppService.DTOs.UserDTO userDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/UpdateUser", ReplyAction="http://tempuri.org/IUser/UpdateUserResponse")]
        System.Threading.Tasks.Task<string> UpdateUserAsync(AppService.DTOs.UserDTO userDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserChannel : MVC_project.UserService.IUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<MVC_project.UserService.IUser>, MVC_project.UserService.IUser {
        
        public UserClient() {
        }
        
        public UserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppService.DTOs.UserDTO[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<AppService.DTOs.UserDTO[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public AppService.DTOs.UserDTO[] GetUsersByJob(string job) {
            return base.Channel.GetUsersByJob(job);
        }
        
        public System.Threading.Tasks.Task<AppService.DTOs.UserDTO[]> GetUsersByJobAsync(string job) {
            return base.Channel.GetUsersByJobAsync(job);
        }
        
        public AppService.DTOs.UserDTO GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<AppService.DTOs.UserDTO> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public string PostUser(AppService.DTOs.UserDTO userDTO) {
            return base.Channel.PostUser(userDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostUserAsync(AppService.DTOs.UserDTO userDTO) {
            return base.Channel.PostUserAsync(userDTO);
        }
        
        public string DeleteUser(int id) {
            return base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
        
        public string UpdateUser(AppService.DTOs.UserDTO userDTO) {
            return base.Channel.UpdateUser(userDTO);
        }
        
        public System.Threading.Tasks.Task<string> UpdateUserAsync(AppService.DTOs.UserDTO userDTO) {
            return base.Channel.UpdateUserAsync(userDTO);
        }
    }
}
