using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UGOZ_Marcel_Roesink.Models
{
    public class RegisterCrvViewModel
    {
        public enum Electricity
        {
            [Description("Yes")]
            Yes,

            [Description("No")]
            No
        }
        [DisplayName("Merk")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvName { get; set; }

        [DisplayName("Type")]
        public string CrvType { get; set; }

        [DisplayName("Lengte")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvLength { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public Electricity CrvElectricity { get; set; }

        [DisplayName("Kenteken")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvPlate { get; set; }
    }
}