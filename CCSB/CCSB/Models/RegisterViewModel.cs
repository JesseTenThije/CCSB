using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSB.Models
{
    public class RegisterViewModel
    {
        [DisplayName("Voornaam")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string FirstName { get; set; }

        [DisplayName("Tussenvoegsels")]
        public string MiddleName { get; set; }

        [DisplayName("Achternaam")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string LastName { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string Adres { get; set; }

        [RegularExpression("[1-9][0-9]{3}[A-Z]{2}", ErrorMessage = "dit is geen geldig nederlandse postcode, Voorbeeld 1000XX")]
        [DisplayName("Postcode")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string Postcode { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string Email { get; set; }

        [DisplayName("Wachtwoord")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="Het {0} moet minstens {2} tekens bevatten.", MinimumLength = 6)]
        public string Password { get; set; }

        [DisplayName("Wachtwoord confirmatie")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Wachtwoorden komen niet overeen")]
        public string PasswordConfirm { get; set; }

        [DisplayName("Rol")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string RoleName { get; set; }
    }
}
