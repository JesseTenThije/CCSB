using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CCSB.Utility
{
    public static class Helper
    {
        public static readonly string Admin = "Beheerder";
        public static readonly string Patient = "Patiënt";
        public static readonly string Doctor = "Dokter";

        public static readonly string DropDownYes = "Ja";
        public static readonly string DropDownNo = "Nee";

        public static readonly string DropDownYesValue = "0";
        public static readonly string DropDownNoValue = "1";



        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            var items = new List<SelectListItem>
            {
                new SelectListItem{ Value=Helper.Admin , Text = Helper.Admin},
                new SelectListItem{ Value=Helper.Patient , Text = Helper.Patient},
                new SelectListItem{ Value=Helper.Doctor , Text = Helper.Doctor}
            };
            return items.OrderBy(s => s.Text).ToList();
        }

        public static List<SelectListItem> GetYesNoForDropDown()
        {
            var items = new List<SelectListItem>
            {
                new SelectListItem{ Value=Helper.DropDownYesValue , Text = Helper.DropDownYes},
                new SelectListItem{ Value=Helper.DropDownNoValue , Text = Helper.DropDownNo},
            };
            return items.OrderBy(s => s.Text).ToList();
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            List<SelectListItem> duration = new List<SelectListItem>();
            for (int i = 10; i <= 90; i += 10)
            {
                duration.Add(new SelectListItem { Value = i.ToString(), Text = i + " Minuten" });
            }
            return duration;
        }
    }
}

