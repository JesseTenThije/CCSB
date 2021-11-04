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


        public static string AppointmentAdded = "Afspraak succesvol opgeslagen.";
        public static string AppointmentConfirmed = "Afspraak bevestigd.";
        public static string AppointmentUpdated = "Afspraak succesvol gewijzigd.";
        public static string AppointmentDeleted = "Afspraak succesvol verwijderd.";
        public static string AppointmentExists = "Afspraak bestaat al op gegeven datum en tijdstip.";
        public static string AppointmentNotExists = "Afspraak bestaat niet.";
        public static string AppointmentAddError = "Er ging iets mis. Afspraak niet toegevoegd.";
        public static string AppointmentConfirmError = "Er ging iets mis. Afspraak niet bevestigd.";
        public static string SomethingWentWrong = "Er ging iets mis. Probeer het opnieuw.";
        public static string AppointmentUpdatError = "Er ging iets mis. Afspraak niet gewijzigd.";
        public static int Succes_code = 1;
        public static int Failure_code = 0;

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

