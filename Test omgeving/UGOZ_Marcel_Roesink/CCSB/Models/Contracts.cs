using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Contracts migration for database
namespace CCSB.Models
{
    public class Contracts
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
