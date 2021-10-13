using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace UGOZ_Marcel_Roesink.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MiddleName))
                {
                    return FirstName + " " + LastName;
                }else
                {
                    return FirstName + " " + MiddleName + " " + LastName;
                }
            }
        }

    }
}
