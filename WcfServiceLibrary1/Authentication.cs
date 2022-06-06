using AppService.DTOs;
using AppService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Authentication" in both code and config file together.
    public class Authentication : IAuthentication
    {

        private LoginManagementService loginService = new LoginManagementService();
        public string Authenticate(LoginDTO loginDTO)
        {
            List<LoginDTO> loginDTOs = loginService.GetByUsernamePassword(loginDTO.Username, loginDTO.Password);
            if (loginDTOs.Count() > 0)
            {
                 return "User is valid";
            }
            else
            {
                 return "User is unvalid";
            }
        }
    }
}
