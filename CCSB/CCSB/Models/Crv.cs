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

        public enum CrvKind
        {
            [Description("Integraal")]
            Integraal = 0,

            [Description("Alkoof")]
            Alkoof = 1,

            [Description("Halfintegraal")]
            Halfintegraal = 2
        }
        //No special characters can be added
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Geen speciale karakters toegestaan")]
        [DisplayName("Merk")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvName { get; set; }
        //No special characters can be added
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Geen speciale karakters toegestaan")]
        [DisplayName("Type")]
        public string CrvType { get; set; }

        [DisplayName("Bouw jaar")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvBuildYear { get; set; }

        [DisplayName("Aantal slaapplaatsen")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvSleepingPlace { get; set; }

        [DisplayName("Aantal PK's")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvPks { get; set; }

        [DisplayName("Kilometerstand")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvKms { get; set; }

        //No special characters can be added
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Geen speciale karakters toegestaan")]
        [DisplayName("Lengte (in cm)")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        //No special characters can be added
        public int CrvLength { get; set; }
        [DisplayName("Electriciteit")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvElectricity { get; set; }

        [DisplayName("Fietsendrager")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvBikes { get; set; }

        [DisplayName("Airco")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvArico { get; set; }

        [DisplayName("Trekhaak")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvPullingHook { get; set; }

        [DisplayName("Vuilwatertank")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        [EnumDataType(typeof(Electricity))]
        public Electricity CrvDirtWater { get; set; }

        [DisplayName("Kenteken")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        //No vowels or special characters in te license plate (except for -)
        [RegularExpression(@"^[b-df-hj-np-tv-z-B-DF-HJ-NP-TV-Z0-9[-]+$", ErrorMessage = "Geen klinkers of speciale karakters toegestaan")]
        //Sets string to uppercase
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

        public List<Reserveringen> Reserveringen { get; set; }
    }
}
