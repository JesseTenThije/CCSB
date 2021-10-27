using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UGOZ_Marcel_Roesink.Models.ViewModels;
using UGOZ_Marcel_Roesink.Utility;
using UGOZ_Marcel_Roesink.Models;
using UGOZ_Marcel_Roesink.Controllers;
using Microsoft.AspNetCore.Identity;
using System.Globalization;
using UGOZ_Marcel_Roesink.Services;

namespace UGOZ_Marcel_Roesink.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;
        RoleManager<IdentityRole> _roleManager;

        public AppointmentService(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public List<DoctorViewModel> GetDoctorList()
        {
            var doctors = (from user in _db.Users
                           join userRole in _db.UserRoles on user.Id equals userRole.UserId
                           join role in _db.Roles.Where(x => x.Name == Helper.Doctor) on userRole.RoleId equals role.Id
                           select new DoctorViewModel
                           {
                               Id = user.Id,
                               Name = string.IsNullOrEmpty(user.MiddleName) ?
                               user.FirstName + " " + user.LastName :
                               user.FirstName + " " + user.MiddleName + " " + user.LastName
                           }
                           ).OrderBy(u => u.Name)
                           .ToList();
            return doctors;
        }

        public List<PatientViewModel> GetPatientList()
        {
            var patient = (from user in _db.Users
                           join userRole in _db.UserRoles on user.Id equals userRole.UserId
                           join role in _db.Roles.Where(x => x.Name == Helper.Patient) on userRole.RoleId equals role.Id

                           select new PatientViewModel
                           {
                               Id = user.Id,
                               Name = string.IsNullOrEmpty(user.MiddleName) ?
                               user.FirstName + " " + user.LastName :
                               user.FirstName + " " + user.MiddleName + " " + user.LastName
                           }
               ).OrderBy(u => u.Name).ToList();
            return patient;
        }

        public async Task<int> AddUpdate(AppointmentViewModel model)
        {
            var startDate = DateTime.Parse(model.StartDate, CultureInfo.CreateSpecificCulture("en-US"));
            var endDate = startDate.AddMinutes(Convert.ToDouble(model.Duration));
            if (model != null && model.Id > 0)
            {
                // TODO: add code for update appointment
                return 1;
            }
            else
            {
                Appointment appointment = new Appointment()
                {
                    Title = model.Title,
                    Description = model.Description,
                    StartDate = startDate,
                    EndDate = endDate,
                    Duration = model.Duration,
                    DoctorId = model.DoctorId,
                    PatientId = model.PatientId,
                    IsDoctorApproved = model.IsDoctorApproved,
                    AdminId = model.AdminId
                };
                _db.Appointments.Add(appointment);
                await _db.SaveChangesAsync();
                return 2;
            }
        }

    }
}