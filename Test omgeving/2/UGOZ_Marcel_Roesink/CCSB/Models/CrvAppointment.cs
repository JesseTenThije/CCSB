using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CCSB.Models
{
    public class CrvAppointment
    {
        [Key]
        public int? Id { get; set; }
        public DateTime StartDate { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string VehicleId { get; set; }
        public bool IsAdminApproved { get; set; }
        public string AdminId { get; set; }


    }
}
