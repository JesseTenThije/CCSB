using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCSB.Models.ViewModels;
using CCSB.Models;
using CCSB.Services;

namespace CCSB.Services
{
    public interface IAppointmentService
    {
        public List<DoctorViewModel> GetDoctorList();
        public List<PatientViewModel> GetPatientList();
        public Task<int> AddUpdate(AppointmentViewModel model);


    }
}
