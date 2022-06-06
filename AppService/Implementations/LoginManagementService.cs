using AppService.DTOs;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Implementations
{
    public class LoginManagementService
    {
        public List<LoginDTO> GetByUsernamePassword(string username,string password)
        {
            List<LoginDTO> loginDTOs = new List<LoginDTO>();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.UserRepository.Get(filter: item => item.Username == username &&  item.Password == password))
                {
                    loginDTOs.Add(new LoginDTO
                    {
                       
                        Username = item.Username,
                        Password = item.Password,
                        RememberMe=item.RememberMe
                        
                    });
                }

            }
            return loginDTOs;
        }
    }
}
