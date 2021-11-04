using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCSB.Models;


namespace CCSB.Controllers
{
    public class CrvController : Controller
    {
        private ApplicationDbContext _db { get; set; }

        // Constructor
        public CrvController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult RegisterCrv()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterCrv(RegisterCrvViewModel model)
        {
            if (ModelState.IsValid)
            {
                Crv crv = new Crv()
                {
                    CrvName = model.CrvName,
                    CrvType = model.CrvType,
                    CrvLength = model.CrvLength,
                    CrvElectricity = (Crv.Electricity)model.CrvElectricity,
                    CrvPlate = model.CrvPlate

                };
                _db.Crv.Add(crv);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        public IActionResult Index()
        {
            IEnumerable<Crv> objList = _db.Crv;
            return View(objList);
        }

        public IActionResult AddCrv()
        {
            return View();
        }
    }
}
