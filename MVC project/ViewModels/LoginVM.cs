using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;

namespace MVC_project.ViewModels
{
    public class LoginVM:UserNamePasswordValidator
    {
        [DisplayName("Username: ")]
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }

        [DisplayName("Password: ")]
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [DisplayName("Remember me: ")]
        public bool RememberMe { get; set; }

        public override void Validate(string userName, string password)
        {
            throw new SecurityTokenException("Invalid account");
        }
    }


}