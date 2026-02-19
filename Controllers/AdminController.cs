using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MultiStepFormApp.Data;
using MultiStepFormApp.Models;
using System.Text.Json;



namespace MultiStepFormApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormEntries.ToListAsync());
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formEntry = await _context.FormEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formEntry == null)
            {
                return NotFound();
            }

            return View(formEntry);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return RedirectToAction("PersonalDetails", "Form"); ;
        }

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,DOB,Age,Mobile,Aadhaar,Gender,MaritalStatus,FatherName,MotherName,Nationality,CorrAddress,CorrDistrict,CorrState,CorrCountry,CorrPincode,PermAddress,PermDistrict,PermState,PermCountry,PermPincode,EducationJson")] FormEntry formEntry)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(formEntry);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(formEntry);
        //}

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var entry = await _context.FormEntries.FindAsync(id);
            if (entry == null) return NotFound();

            // ================= PERSONAL =================
            var nameParts = (entry.Name ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var personal = new PersonalDetails
            {
                FirstName = nameParts.Length > 0 ? nameParts[0] : "",
                LastName = nameParts.Length > 1 ? nameParts[1] : "",

                DOB = entry.DOB ?? DateTime.Today,

                MobileNumber = entry.Mobile ?? "",
                AadhaarNumber = entry.Aadhaar ?? "",

                Gender = Enum.TryParse<Gender>(entry.Gender ?? "", out var g) ? g : Gender.Male,
                IsMarried = Enum.TryParse<IsMarried>(entry.MaritalStatus ?? "", out var m) ? m : IsMarried.Unmarried,

                FatherName = entry.FatherName ?? "",
                MotherName = entry.MotherName ?? "",
                FatherOccupation = entry.FatherOccupation ?? "",
                MotherOccupation = entry.MotherOccupation ?? "",
                Nationality = entry.Nationality ?? "",
                Hobbies = entry.Hobbies ?? ""
            };



            // ================= ADDRESS =================
            var address = new AddressDetails
            {
                CorrCountry = entry.CorrCountry ?? "",
                CorrState = entry.CorrState ?? "",
                CorrDistrict = entry.CorrDistrict ?? "",
                CorrAddressLine = entry.CorrAddress ?? "",
                CorrPincode = entry.CorrPincode ?? "",

                PermCountry = entry.PermCountry ?? "",
                PermState = entry.PermState ?? "",
                PermDistrict = entry.PermDistrict ?? "",
                PermAddressLine = entry.PermAddress ?? "",
                PermPincode = entry.PermPincode ?? ""
            };

            // Important: detect same address properly
            address.SameAsCorrespondence =
                !string.IsNullOrEmpty(address.CorrCountry) &&
                address.CorrCountry == address.PermCountry &&
                address.CorrState == address.PermState &&
                address.CorrDistrict == address.PermDistrict &&
                address.CorrAddressLine == address.PermAddressLine &&
                address.CorrPincode == address.PermPincode;


            // ================= EDUCATION =================
            List<EducationDetail> educationList = new List<EducationDetail>();

            if (!string.IsNullOrEmpty(entry.EducationJson))
            {
                try
                {
                    educationList = JsonSerializer.Deserialize<List<EducationDetail>>(entry.EducationJson)
                                    ?? new List<EducationDetail>();
                }
                catch
                {
                    educationList = new List<EducationDetail>();
                }
            }

            var qualification = new QualificationDetails
            {
                Educations = educationList
            };


            // ================= SESSION SAVE =================
            HttpContext.Session.SetString("EditId", entry.Id.ToString());
            HttpContext.Session.SetString("Personal", JsonSerializer.Serialize(personal));
            HttpContext.Session.SetString("Address", JsonSerializer.Serialize(address));
            HttpContext.Session.SetString("Qualification", JsonSerializer.Serialize(qualification));

            // open multi step form
            return RedirectToAction("PersonalDetails", "Form");

}


        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DOB,Age,Mobile,Aadhaar,Gender,MaritalStatus,FatherName,MotherName,Nationality,CorrAddress,CorrDistrict,CorrState,CorrCountry,CorrPincode,PermAddress,PermDistrict,PermState,PermCountry,PermPincode,EducationJson")] FormEntry formEntry)
        {
            if (id != formEntry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formEntry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormEntryExists(formEntry.Id))
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
            return View(formEntry);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formEntry = await _context.FormEntries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formEntry == null)
            {
                return NotFound();
            }

            return View(formEntry);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formEntry = await _context.FormEntries.FindAsync(id);
            if (formEntry != null)
            {
                _context.FormEntries.Remove(formEntry);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormEntryExists(int id)
        {
            return _context.FormEntries.Any(e => e.Id == id);
        }
    }
}
