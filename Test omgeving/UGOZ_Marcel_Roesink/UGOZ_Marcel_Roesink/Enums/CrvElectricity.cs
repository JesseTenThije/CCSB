using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UGOZ_Marcel_Roesink.Enums
{
    public class CrvElectricityClass
    {
        public enum CrvElectricity
        {
            [Display(Name = "Ja")]
            Yes,

            [Display(Name = "Nee")]
            No
        }
    }
}
