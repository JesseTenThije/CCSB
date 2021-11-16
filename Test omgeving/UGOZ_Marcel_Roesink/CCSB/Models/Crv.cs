using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//Vehicle migration to database
namespace CCSB.Models
{
    public class Crv
    {
        [Key]
        public int? Id { get; set; }
        public enum Electricity
        {
            Yes = 0,
            No = 1
        }
        public string CrvName { get; set; }
        public string CrvType { get; set; }
        public int CrvLength { get; set; }
        public Electricity CrvElectricity { get; set; }
        public string CrvPlate { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
