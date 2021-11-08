using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSB.Models
{
    public class Crv
    {
        [Key]
        public int? Id { get; set; }

        public enum Electricity
        {
            [Description("Yes")]
            Yes = 0,

            [Description("No")]
            No = 1
        }
        [DisplayName("Merk")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvName { get; set; }
        [DisplayName("Type")]
        public string CrvType { get; set; }
        [DisplayName("Lengte (in cm)")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvLength { get; set; }
        [DisplayName("Electriciteit")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvElectricity { get; set; }

        [DisplayName("Kenteken")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvPlate { get; set; }
        [DisplayName("Kies de gebruiker")]
        public string ApplicationUserId { get; set; }
        [DisplayName("Gebruiker")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
