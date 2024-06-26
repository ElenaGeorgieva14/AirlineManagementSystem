﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_project.TicketService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TicketService.ITicket")]
    public interface ITicket {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/GetTickets", ReplyAction="http://tempuri.org/ITicket/GetTicketsResponse")]
        AppService.DTOs.TicketsDTO[] GetTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/GetTickets", ReplyAction="http://tempuri.org/ITicket/GetTicketsResponse")]
        System.Threading.Tasks.Task<AppService.DTOs.TicketsDTO[]> GetTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/GetTicketsByDocumentNumber", ReplyAction="http://tempuri.org/ITicket/GetTicketsByDocumentNumberResponse")]
        AppService.DTOs.TicketsDTO[] GetTicketsByDocumentNumber(string documentNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/GetTicketsByDocumentNumber", ReplyAction="http://tempuri.org/ITicket/GetTicketsByDocumentNumberResponse")]
        System.Threading.Tasks.Task<AppService.DTOs.TicketsDTO[]> GetTicketsByDocumentNumberAsync(string documentNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/GetTicketById", ReplyAction="http://tempuri.org/ITicket/GetTicketByIdResponse")]
        AppService.DTOs.TicketsDTO GetTicketById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/GetTicketById", ReplyAction="http://tempuri.org/ITicket/GetTicketByIdResponse")]
        System.Threading.Tasks.Task<AppService.DTOs.TicketsDTO> GetTicketByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/PostTicket", ReplyAction="http://tempuri.org/ITicket/PostTicketResponse")]
        string PostTicket(AppService.DTOs.TicketsDTO ticketsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/PostTicket", ReplyAction="http://tempuri.org/ITicket/PostTicketResponse")]
        System.Threading.Tasks.Task<string> PostTicketAsync(AppService.DTOs.TicketsDTO ticketsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/DeleteTicket", ReplyAction="http://tempuri.org/ITicket/DeleteTicketResponse")]
        string DeleteTicket(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/DeleteTicket", ReplyAction="http://tempuri.org/ITicket/DeleteTicketResponse")]
        System.Threading.Tasks.Task<string> DeleteTicketAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/UpdateTicket", ReplyAction="http://tempuri.org/ITicket/UpdateTicketResponse")]
        string UpdateTicket(AppService.DTOs.TicketsDTO ticketsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITicket/UpdateTicket", ReplyAction="http://tempuri.org/ITicket/UpdateTicketResponse")]
        System.Threading.Tasks.Task<string> UpdateTicketAsync(AppService.DTOs.TicketsDTO ticketsDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITicketChannel : MVC_project.TicketService.ITicket, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TicketClient : System.ServiceModel.ClientBase<MVC_project.TicketService.ITicket>, MVC_project.TicketService.ITicket {
        
        public TicketClient() {
        }
        
        public TicketClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TicketClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TicketClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppService.DTOs.TicketsDTO[] GetTickets() {
            return base.Channel.GetTickets();
        }
        
        public System.Threading.Tasks.Task<AppService.DTOs.TicketsDTO[]> GetTicketsAsync() {
            return base.Channel.GetTicketsAsync();
        }
        
        public AppService.DTOs.TicketsDTO[] GetTicketsByDocumentNumber(string documentNumber) {
            return base.Channel.GetTicketsByDocumentNumber(documentNumber);
        }
        
        public System.Threading.Tasks.Task<AppService.DTOs.TicketsDTO[]> GetTicketsByDocumentNumberAsync(string documentNumber) {
            return base.Channel.GetTicketsByDocumentNumberAsync(documentNumber);
        }
        
        public AppService.DTOs.TicketsDTO GetTicketById(int id) {
            return base.Channel.GetTicketById(id);
        }
        
        public System.Threading.Tasks.Task<AppService.DTOs.TicketsDTO> GetTicketByIdAsync(int id) {
            return base.Channel.GetTicketByIdAsync(id);
        }
        
        public string PostTicket(AppService.DTOs.TicketsDTO ticketsDTO) {
            return base.Channel.PostTicket(ticketsDTO);
        }
        
        public System.Threading.Tasks.Task<string> PostTicketAsync(AppService.DTOs.TicketsDTO ticketsDTO) {
            return base.Channel.PostTicketAsync(ticketsDTO);
        }
        
        public string DeleteTicket(int id) {
            return base.Channel.DeleteTicket(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteTicketAsync(int id) {
            return base.Channel.DeleteTicketAsync(id);
        }
        
        public string UpdateTicket(AppService.DTOs.TicketsDTO ticketsDTO) {
            return base.Channel.UpdateTicket(ticketsDTO);
        }
        
        public System.Threading.Tasks.Task<string> UpdateTicketAsync(AppService.DTOs.TicketsDTO ticketsDTO) {
            return base.Channel.UpdateTicketAsync(ticketsDTO);
        }
    }
}
