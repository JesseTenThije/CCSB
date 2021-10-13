using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UGOZ_Marcel_Roesink.Models.ViewModels;
using UGOZ_Marcel_Roesink.Models;
using UGOZ_Marcel_Roesink.Services;

namespace UGOZ_Marcel_Roesink.Services
{
    public interface IAppointmentService
    {
        public List<DoctorViewModel> GetDoctorList();
        public List<PatientViewModel> GetPatientList();
        public Task<int> AddUpdate(AppointmentViewModel model);


    }
}
