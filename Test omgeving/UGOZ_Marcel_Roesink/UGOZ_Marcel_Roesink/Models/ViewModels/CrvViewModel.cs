using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UGOZ_Marcel_Roesink.Models.ViewModels
{
    public class CrvViewModel
    {
        private int? id;

        public int? GetId()
        {
            return id;
        }

        public void SetId(int? value)
        {
            id = value;
        }

        public string CrvName { get; set; }
        public string CrvType { get; set; }
        public int CrvLength { get; set; }
        public CrvElectricity CrvElectricity { get; set; }
        public string CrvPlate { get; set; }
    }
}
