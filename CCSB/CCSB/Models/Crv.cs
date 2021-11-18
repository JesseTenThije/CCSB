using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CCSB.Models
{
    public class Crv
    {
        private string _CrvPlate;

        [Key]
        public int? Id { get; set; }

        public enum Electricity
        {
            [Description("Yes")]
            Yes = 0,

            [Description("No")]
            No = 1
        }
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special character should not be entered")]
        [DisplayName("Merk")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvName { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special character should not be entered")]
        [DisplayName("Type")]
        public string CrvType { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special character should not be entered")]
        [DisplayName("Lengte (in cm)")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvLength { get; set; }
        [DisplayName("Electriciteit")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvElectricity { get; set; }

        [DisplayName("Kenteken")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
       

        public string CrvPlate
        {
            get
            {
                if (string.IsNullOrEmpty(_CrvPlate))
                {
                    return _CrvPlate;
                }
                return _CrvPlate.ToUpper();
            }
            set
            {
                _CrvPlate = value;
            }
        }
        [DisplayName("Kies de gebruiker")]
        public string ApplicationUserId { get; set; }
        [DisplayName("Gebruiker")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
