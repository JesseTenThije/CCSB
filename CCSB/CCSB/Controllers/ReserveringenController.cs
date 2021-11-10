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
        //Connect to datatbase
        public ReserveringenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Reserveringen
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reserveringen.Include(r => r.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());

        }

        // GET: Reserveringen/Details of a specific id
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveringen = await _context.Reserveringen
                .Include(r => r.ApplicationUser)
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
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["CrvPlate"] = new SelectList(_context.Crv, "Id", "CrvPlate");
            return View();
        }

        // POST: Reserveringen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        //Combines user reservation data
        public async Task<IActionResult> Create([Bind("Id,StartDatum,ApplicationUserId,Vehicle")] Reserveringen reserveringen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reserveringen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Email", reserveringen.ApplicationUserId);
            return View(reserveringen);
        }

        // GET: Reserveringen/Edit
        
        public async Task<IActionResult> Edit(int? id)
            //if id is not found, return
        {
            if (id == null)
            {
                return NotFound();
            }
            //if id is found search for reservations, if not found, return if found get reserveringen from user id
            var reserveringen = await _context.Reserveringen.FindAsync(id);
            if (reserveringen == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Email", reserveringen.ApplicationUserId);
            return View(reserveringen);
        }

        // POST: Reserveringen/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,StartDatum,ApplicationUserId,Vehicle")] Reserveringen reserveringen)
        //updates database 
        {
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
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Email", reserveringen.ApplicationUserId);
            return View(reserveringen);
        }

        // GET: Reserveringen/Delete reservation
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserveringen = await _context.Reserveringen
                .Include(r => r.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reserveringen == null)
            {
                return NotFound();
            }

            return View(reserveringen);
        }

        // POST: Reserveringen/Deletes out of the database
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