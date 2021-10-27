using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCSB.Models
{
    public class Crv
    {
        public enum Electricity
        {
            Yes,
            No
        }
        public string CrvName { get; set; }
        public string CrvType { get; set; }
        public int CrvLength { get; set; }
        public Electricity CrvElectricity { get; set; }
        public string CrvPlate { get; set; }


    }
}
