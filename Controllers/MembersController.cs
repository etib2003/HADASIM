using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Corona_System.Models;
using Corona_System.Data;

namespace Corona_System.Controllers
{
    public class MembersController : Controller
    {
        private readonly Corona_SystemContext _context;

        public MembersController(Corona_SystemContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
              return _context.Member != null ? 
                          View(await _context.Member.ToListAsync()) :
                          Problem("Entity set 'Corona_SystemContext.Member'  is null.");
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,IdNumber,City,Street,Number,BirthDate,Phone,MobilePhone,Vaccine1Date,Vaccine1Manufacturer,Vaccine2Date,Vaccine2Manufacturer,Vaccine3Date,Vaccine3Manufacturer,Vaccine4Date,Vaccine4Manufacturer,PositiveResultDate,RecoveryDate")] Member member)
        {
            if (ModelState.IsValid)
            {
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }


        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,IdNumber,City,Street,Number,BirthDate,Phone,MobilePhone,Vaccine1Date,Vaccine1Manufacturer,Vaccine2Date,Vaccine2Manufacturer,Vaccine3Date,Vaccine3Manufacturer,Vaccine4Date,Vaccine4Manufacturer,PositiveResultDate,RecoveryDate")] Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
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
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Member == null)
            {
                return NotFound();
            }

            var member = await _context.Member
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Member == null)
            {
                return Problem("Entity set 'Corona_SystemContext.Member'  is null.");
            }
            var member = await _context.Member.FindAsync(id);
            if (member != null)
            {
                _context.Member.Remove(member);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        // GET: Members/Chart
        public IActionResult Chart()
        {
            var today = DateTime.Today;
            var lastMonthStart = new DateTime(today.Year, today.Month, 1);
            var lastMonthEnd = lastMonthStart.AddDays(29);

            var activeCasesByDay = _context.Member
                .Where(m => m.PositiveResultDate != null /*&& m.RecoveryDate == null*/ && m.PositiveResultDate >= lastMonthStart && m.PositiveResultDate <= lastMonthEnd)
                .GroupBy(m => m.PositiveResultDate.Value.Date)
                .Select(g => new { Date = g.Key, Count = g.Count() })
                .OrderBy(g => g.Date)
                .ToList();

            return View(activeCasesByDay);
        }

        // GET: Members/VaccinationChart
        public IActionResult VaccinationChart()
        {
            var unvaccinatedCount = _context.Member.Count(m => m.Vaccine1Date == null && m.Vaccine2Date == null && m.Vaccine3Date == null && m.Vaccine4Date == null);
            var oneDoseCount = _context.Member.Count(m => m.Vaccine1Date != null && m.Vaccine2Date == null);
            var twoDosesCount = _context.Member.Count(m => m.Vaccine2Date != null && m.Vaccine3Date == null);
            var threeDosesCount = _context.Member.Count(m => m.Vaccine3Date != null && m.Vaccine4Date == null);
            var fourDosesCount = _context.Member.Count(m => m.Vaccine4Date != null);


            var chartData = new
            {
                Unvaccinated = unvaccinatedCount,
                Vaccinated1= oneDoseCount,
                Vaccinated2= twoDosesCount,
                Vaccinated3= threeDosesCount,
                Vaccinated4= fourDosesCount
            };

            return View(chartData);
        }


        private bool MemberExists(int id)
        {
          return (_context.Member?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
