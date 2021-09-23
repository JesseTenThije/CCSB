using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CCSB.Data;
using CCSB.Models;

namespace CCSB.Controllers
{
    public class ItemController : Controller
    {
        private ApplicationDbContext _db { get; set; }

        // Constructor
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);

        }
    }
}
