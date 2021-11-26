//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using CCSB.Models;

//namespace CCSB.Controllers
//{
//    public class ReserveringenController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public ReserveringenController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: Reserveringen
//        public async Task<IActionResult> Index()
//        {
//            var applicationDbContext = _context.Reserveringen.Include(r => r.Crv);
//            return View(await applicationDbContext.ToListAsync());

//        }

//        // GET: Reserveringen/Details
//        public async Task<IActionResult> Details(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var reserveringen = await _context.Reserveringen
//                .Include(r => r.Crv)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (reserveringen == null)
//            {
//                return NotFound();
//            }

//            return View(reserveringen);
//        }

//        // GET: Reserveringen/Create
//        public IActionResult Create()
//        {
//            ViewData["CrvPlate"] = new SelectList(_context.Crv, "Id", "CrvPlate");
//            return View();
//        }

//        // POST: Reserveringen/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,StartDatum,CrvId")] Reserveringen reserveringen)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.Add(reserveringen);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(reserveringen);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]



//        // GET: Reserveringen/Edit/5
//        public async Task<IActionResult> Edit(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var reserveringen = await _context.Reserveringen.FindAsync(id);
//            if (reserveringen == null)
//            {
//                return NotFound();
//            }
//            return View(reserveringen);
//        }

//        // POST: Reserveringen/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]

//        public async Task<IActionResult> Edit(int? id, [Bind("Id,StartDatum,Crv")] Reserveringen reserveringen)

//        {
//            var startDate = reserveringen.StartDatum;
//            DateTime dt1 = new DateTime(2021, 01, 01);
//            DateTime dt2 = new DateTime(2021, 04, 02);
//            DateTime dt3 = new DateTime(2021, 04, 04);
//            DateTime dt4 = new DateTime(2021, 04, 05);
//            DateTime dt5 = new DateTime(2021, 04, 27);
//            DateTime dt6 = new DateTime(2021, 05, 05);
//            DateTime dt7 = new DateTime(2021, 05, 13);
//            DateTime dt8 = new DateTime(2021, 05, 23);
//            DateTime dt9 = new DateTime(2021, 05, 24);
//            DateTime dt10 = new DateTime(2021, 12, 25);
//            DateTime dt11 = new DateTime(2021, 12, 26);


//            if (startDate == dt1 || startDate == dt2 || startDate == dt3 || startDate == dt4 || startDate == dt5 || startDate == dt6 || startDate == dt7 || startDate == dt8 || startDate == dt9 || startDate == dt10 || startDate == dt11)
//            {

//                return NotFound();
//            }


//            if (id != reserveringen.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(reserveringen);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!ReserveringenExists(reserveringen.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["Crv"] = new SelectList(_context.Crv, "Id", "CrvPlate");
//            return View(reserveringen);
//        }

//        // GET: Reserveringen/Delete/5
//        public async Task<IActionResult> Delete(int? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var reserveringen = await _context.Reserveringen
//                .Include(r => r.Crv)
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (reserveringen == null)
//            {
//                return NotFound();
//            }

//            return View(reserveringen);
//        }

//        // POST: Reserveringen/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int? id)
//        {
//            var reserveringen = await _context.Reserveringen.FindAsync(id);
//            _context.Reserveringen.Remove(reserveringen);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool ReserveringenExists(int? id)
//        {
//            return _context.Reserveringen.Any(e => e.Id == id);
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CCSB.Models;

namespace CCSB.Controllers
{
    public class ReserveringenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReserveringenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reserveringen
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reserveringen.Include(r => r.Crv);
            return View(await applicationDbContext.ToListAsync());

        }

        // GET: Reserveringen/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveringen = await _context.Reserveringen
                .Include(r => r.Crv)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reserveringen == null)
            {
                return NotFound();
            }

            return View(reserveringen);
        }

        // GET: Reserveringen/Create
        public IActionResult Create()
        {
            ViewData["CrvPlate"] = new SelectList(_context.Crv, "Id", "CrvPlate");
            return View();
        }

        // POST: Reserveringen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDatum,CrvId")] Reserveringen reserveringen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserveringen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reserveringen);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]



        // GET: Reserveringen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveringen = await _context.Reserveringen.FindAsync(id);
            if (reserveringen == null)
            {
                return NotFound();
            }
            return View(reserveringen);
        }

        // POST: Reserveringen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int? id, [Bind("Id,StartDatum,Crv")] Reserveringen reserveringen)

        {
            var startDate = reserveringen.StartDatum;
            DateTime dt1 = new DateTime(2021, 01, 01);
            DateTime dt2 = new DateTime(2021, 04, 02);
            DateTime dt3 = new DateTime(2021, 04, 04);
            DateTime dt4 = new DateTime(2021, 04, 05);
            DateTime dt5 = new DateTime(2021, 04, 27);
            DateTime dt6 = new DateTime(2021, 05, 05);
            DateTime dt7 = new DateTime(2021, 05, 13);
            DateTime dt8 = new DateTime(2021, 05, 23);
            DateTime dt9 = new DateTime(2021, 05, 24);
            DateTime dt10 = new DateTime(2021, 12, 25);
            DateTime dt11 = new DateTime(2021, 12, 26);


            if (startDate == dt1 || startDate == dt2 || startDate == dt3 || startDate == dt4 || startDate == dt5 || startDate == dt6 || startDate == dt7 || startDate == dt8 || startDate == dt9 || startDate == dt10 || startDate == dt11)
            {

                return NotFound();
            }


            if (id != reserveringen.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reserveringen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReserveringenExists(reserveringen.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Crv"] = new SelectList(_context.Crv, "Id", "CrvPlate");
            return View(reserveringen);
        }

        // GET: Reserveringen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveringen = await _context.Reserveringen
                .Include(r => r.Crv)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reserveringen == null)
            {
                return NotFound();
            }

            return View(reserveringen);
        }

        // POST: Reserveringen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var reserveringen = await _context.Reserveringen.FindAsync(id);
            _context.Reserveringen.Remove(reserveringen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReserveringenExists(int? id)
        {
            return _context.Reserveringen.Any(e => e.Id == id);
        }
    }
}