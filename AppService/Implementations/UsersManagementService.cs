using AppService.DTOs;
using Data.Entities;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Implementations
{
    public class UsersManagementService
    {

        public List<UserDTO> Get()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.UserRepository.Get())
                {
                    usersDTO.Add(new UserDTO
                    {
                        Id = item.Id,
                        Username = item.Username,
                        Password = item.Password,
                        Name = item.Name,
                        Age = item.Age,
                        Job = item.Job,
                        BirthDate = item.BirthDate,
                        Salary = item.Salary,
                        Phone = item.Phone,
                        Email = item.Email
                    });
                }

            }
            return usersDTO;
        }

        public List<UserDTO> GetByJob(string job)
        {
            List<UserDTO> usersDTO = new List<UserDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.UserRepository.Get(filter: item => item.Job == job))
                {
                    usersDTO.Add(new UserDTO
                    {
                        Id = item.Id,
                        Username = item.Username,
                        Password = item.Password,
                        Name = item.Name,
                        Age = item.Age,
                        Job = item.Job,
                        BirthDate = item.BirthDate,
                        Salary = item.Salary,
                        Phone = item.Phone,
                        Email = item.Email
                    });
                }

            }
            return usersDTO;
        }

        public UserDTO GetByID(int id)
        {
            UserDTO userDTO = new UserDTO();
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Users item = unitOfWork.UserRepository.GetByID(id);
                {
                    if (item != null)
                    {
                        userDTO = new UserDTO
                        {
                            Id = item.Id,
                            Username = item.Username,
                            Password = item.Password,
                            Name = item.Name,
                            Age = item.Age,
                            Job = item.Job,
                            BirthDate = item.BirthDate,
                            Salary = item.Salary,
                            Phone = item.Phone,
                            Email = item.Email
                        };
                    }
                }
            }
            return userDTO;
        }
        public bool Save(UserDTO userDTO)
        {
            Users item = new Users
            {
                Username = userDTO.Username,
                Password = userDTO.Password,
                Name = userDTO.Name,
                Age = userDTO.Age,
                Job = userDTO.Job,
                BirthDate = userDTO.BirthDate,
                Salary = userDTO.Salary,
                Phone = userDTO.Phone,
                Email = userDTO.Email
            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.UserRepository.Insert(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(UserDTO userDTO)
        {
            Users item = new Users
            {
                Id = userDTO.Id,
                Username = userDTO.Username,
                Password = userDTO.Password,
                Name = userDTO.Name,
                Age = userDTO.Age,
                Job = userDTO.Job,
                BirthDate = userDTO.BirthDate,
                Salary = userDTO.Salary,
                Phone = userDTO.Phone,
                Email = userDTO.Email
            };
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.UserRepository.Update(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Users item = unitOfWork.UserRepository.GetByID(id);
                    unitOfWork.UserRepository.Delete(item);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
