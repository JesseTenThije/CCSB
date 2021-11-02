using System;
using System.Collections.Generic;
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
