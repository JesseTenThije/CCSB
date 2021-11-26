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
        [Required(ErrorMessage = "{0} is een verplicht veld.")]
        public DateTime? StartDatum { get; set; }


        public int CrvId { get; set; }


        [DisplayName("Voertuig")]
        public Crv Crv { get; set; }
    }
}
