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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in both code and config file together.
    public class User : IUser
    {
        private UsersManagementService usersService = new UsersManagementService();

        public List<UserDTO> GetUsers()
        {
            return usersService.Get();
        }
        public List<UserDTO> GetUsersByJob(string job)
        {
            return usersService.GetByJob(job);
        }
        public UserDTO GetUserById(int id)
        {
            return usersService.GetByID(id);
        }
        public string PostUser(UserDTO userDTO)
        {
            if (!usersService.Save(userDTO))
            {
                return "User is not saved!";
            }
            else
            {
                return "User is saved";
            }
        }

        public string DeleteUser(int id)
        {
            if (!usersService.Delete(id))
            {
                return "User is not deleted!";
            }
            else
            {
                return "User is deleted";
            }
        }

        public string UpdateUser(UserDTO userDTO)
        {
            if (!usersService.Edit(userDTO))
            {
                return "User is not edit!";
            }
            else
            {
                return "User is edit";
            }
        }
    }
}
