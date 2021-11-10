using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSB.Models
{
    //Email login automatic value to lowercase
    public class LoginViewModel
    {
        private string _email;
        [Required(ErrorMessage = "{0} error")]
        [EmailAddress(ErrorMessage = "geen goede email")]
        [Display(Name = "E-mail")]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value.ToLower();
            }
        }
        //Password login, error when wrong password and remember me button
        [Required(ErrorMessage = "{0} error")]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string Password { get; set; }
        [Display(Name = "Onthoud mij")]
        public bool RememberMe { get; set; }
    }
}
