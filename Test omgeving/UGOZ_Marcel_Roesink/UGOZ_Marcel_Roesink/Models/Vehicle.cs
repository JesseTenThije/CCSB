using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static UGOZ_Marcel_Roesink.Models.RegisterCrvViewModel;

namespace UGOZ_Marcel_Roesink.Models
{
    public class Vehicle
    {
        public int? Id { get; set; }
        public string CrvName { get; set; }
        public string CrvType { get; set; }
        public int CrvLength { get; set; }
        public Electricity CrvElectricity { get; set; }
        public string CrvPlate { get; set; }
    }
}
