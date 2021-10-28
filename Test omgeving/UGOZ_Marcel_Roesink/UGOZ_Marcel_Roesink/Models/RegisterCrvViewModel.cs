using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UGOZ_Marcel_Roesink.Enums;
using static UGOZ_Marcel_Roesink.Enums.CrvElectricityClass;

namespace UGOZ_Marcel_Roesink.Models
{
    public class RegisterCrvViewModel
    {

        [DisplayName("Merk")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvName { get; set; }

        [DisplayName("Type")]
        public string CrvType { get; set; }

        [DisplayName("Lengte")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public int CrvLength { get; set; }

        [EnumDataType(typeof(CrvElectricity))]
        [DisplayName("Elektriciteit")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public CrvElectricity CrvElectricity { get; internal set; }

        [DisplayName("Kenteken")]
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public string CrvPlate { get; set; }
        
    }
}