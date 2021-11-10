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
    public class Reserveringen
    {
        [Key]
        public int? Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime? StartDatum { get; set; }


        [DisplayName("Kies de gebruiker")]
        public string ApplicationUserId { get; set; }
        [DisplayName("Gebruiker")]
        public ApplicationUser ApplicationUser { get; set; }

        public string Vehicle { get; set; }

        [DisplayName("Voertuig")]
        public Crv Crv { get; set; }


    }
}
