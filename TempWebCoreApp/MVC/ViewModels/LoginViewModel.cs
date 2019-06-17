using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MVC.Controllers.OAuthControllers;

namespace MVC.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Display(Name ="Remember?")]
        public bool RememberMe { get; set; }    

        public string ReturnUrl { get; set; }

        [Display(Name = "Login Via GitHub")]
        public async Task<Action> LoginViaGithub()
        {
            
        }
    }
}
