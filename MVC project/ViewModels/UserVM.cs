using AppService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_project.ViewModels
{
    public class UserVM
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Username ")]
        [Required]
        public string Username { get; set; }

        [DisplayName("Password ")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Name ")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Age")]
        [Required]
        public int Age { get; set; }

        [DisplayName("Job")]
        [Required]
        public string Job { get; set; }

        [DisplayName("Birth date ")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Salary ")]
        [Required]
        public double Salary { get; set; }

        [DisplayName("Phone ")]
        [Required]
        public string Phone { get; set; }

        [DisplayName("E-mail ")]
        [Required]
        public string Email { get; set; }

       
        public UserVM() { }
        public UserVM(UserDTO userDTO)
        {
            Id = userDTO.Id;
            Username = userDTO.Username;
            Password = userDTO.Password;
            Name = userDTO.Name;
            Age = userDTO.Age;
            Job = userDTO.Job;
            BirthDate = userDTO.BirthDate;
            Salary = userDTO.Salary;
            Phone = userDTO.Phone;
            Email = userDTO.Email;
        }

    }
}