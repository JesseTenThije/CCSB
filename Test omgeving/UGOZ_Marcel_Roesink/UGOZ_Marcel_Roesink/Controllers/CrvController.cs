using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UGOZ_Marcel_Roesink.Controllers
{
    public class CrvController : Controller
    {
        private readonly I
        public IActionResult Index()

        {
            return View();
        }
        public IActionResult CrvRegister(RegisterCrvViewModel model)
        {
            if (ModelState.IsValid)
            {
                Vehicle crv = new Vehicle()
                {
                    CrvName = model.CrvName,
                    CrvType = model.CrvType,
                    CrvLength = model.CrvLength,
                    CrvElectricity = model.CrvElectricity,
                    CrvPlate = model.CrvPlate
                };
            }
            return View();
        }
    }
}
