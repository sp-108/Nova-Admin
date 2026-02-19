using Microsoft.AspNetCore.Mvc;
using MultiStepFormApp.Data;
using MultiStepFormApp.Models;
using System.Text.Json;

namespace MultiStepFormApp.Controllers
{
    public class FormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ================= STEP 1 =================

        public IActionResult PersonalDetails()
        {
            var data = HttpContext.Session.GetString("Personal");

            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonSerializer.Deserialize<PersonalDetails>(data);
                return View(model);
            }

            return View(new PersonalDetails());
        }

        [HttpPost]
        public IActionResult PersonalDetails(PersonalDetails model)
        {
            if (!ModelState.IsValid)
                return View(model);

            HttpContext.Session.SetString("Personal", JsonSerializer.Serialize(model));
            return RedirectToAction(nameof(Qualification));
        }


        // ================= STEP 2 =================

        public IActionResult Qualification()
        {
            var data = HttpContext.Session.GetString("Qualification");

            QualificationDetails model;

            if (!string.IsNullOrEmpty(data))
                model = JsonSerializer.Deserialize<QualificationDetails>(data)!;
            else
                model = new QualificationDetails();

            // 🔥 MOST IMPORTANT (fix edit blank issue)
            if (model.Educations == null || model.Educations.Count == 0)
                model.Educations = new List<EducationDetail> { new EducationDetail() };

            return View(model);
        }

        [HttpPost]
        public IActionResult Qualification(QualificationDetails model)
        {
            if (model.Educations == null || model.Educations.Count == 0)
            {
                ModelState.AddModelError("", "Add at least one education");
                return View(model);
            }

            HttpContext.Session.SetString("Qualification", JsonSerializer.Serialize(model));
            return RedirectToAction(nameof(Address));
        }


        // ================= STEP 3 =================

        public IActionResult Address()
        {
            var data = HttpContext.Session.GetString("Address");

            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonSerializer.Deserialize<AddressDetails>(data);
                return View(model);
            }

            return View(new AddressDetails());
        }

        [HttpPost]
        public IActionResult Address(AddressDetails model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // copy if same
            if (model.SameAsCorrespondence)
            {
                model.PermCountry = model.CorrCountry;
                model.PermState = model.CorrState;
                model.PermDistrict = model.CorrDistrict;
                model.PermAddressLine = model.CorrAddressLine;
                model.PermPincode = model.CorrPincode;
            }

            HttpContext.Session.SetString("Address", JsonSerializer.Serialize(model));
            return RedirectToAction(nameof(Preview));
        }


        // ================= STEP 4 =================

        public IActionResult Preview()
        {
            var personal = HttpContext.Session.GetString("Personal");
            var qualification = HttpContext.Session.GetString("Qualification");
            var address = HttpContext.Session.GetString("Address");

            if (string.IsNullOrEmpty(personal) ||
                string.IsNullOrEmpty(qualification) ||
                string.IsNullOrEmpty(address))
                return RedirectToAction(nameof(PersonalDetails));

            var model = new CompleteFormViewModel
            {
                PersonalDetails = JsonSerializer.Deserialize<PersonalDetails>(personal)!,
                QualificationDetails = JsonSerializer.Deserialize<QualificationDetails>(qualification)!,
                AddressDetails = JsonSerializer.Deserialize<AddressDetails>(address)!
            };

            return View(model);
        }


        // ================= FINAL SUBMIT =================

        [HttpPost]
        public IActionResult SubmitForm()
        {
            var p = JsonSerializer.Deserialize<PersonalDetails>(HttpContext.Session.GetString("Personal")!)!;
            var q = JsonSerializer.Deserialize<QualificationDetails>(HttpContext.Session.GetString("Qualification")!)!;
            var a = JsonSerializer.Deserialize<AddressDetails>(HttpContext.Session.GetString("Address")!)!;

            var entry = new FormEntry
            {
                Name = $"{p.FirstName} {p.LastName}",
                DOB = p.DOB,
                Age = p.Age,
                Mobile = p.MobileNumber,
                Aadhaar = p.AadhaarNumber,
                Gender = p.Gender.ToString(),
                MaritalStatus = p.IsMarried.ToString(),

                FatherName = p.FatherName,
                MotherName = p.MotherName,
                FatherOccupation = p.FatherOccupation ?? "",
                MotherOccupation = p.MotherOccupation ?? "",
                Nationality = p.Nationality,
                Hobbies = p.Hobbies ?? "",

                CorrAddress = a.CorrAddressLine,
                CorrDistrict = a.CorrDistrict,
                CorrState = a.CorrState,
                CorrCountry = a.CorrCountry,
                CorrPincode = a.CorrPincode,

                PermAddress = a.PermAddressLine,
                PermDistrict = a.PermDistrict,
                PermState = a.PermState,
                PermCountry = a.PermCountry,
                PermPincode = a.PermPincode,

                EducationJson = JsonSerializer.Serialize(q.Educations)
            };

            var editId = HttpContext.Session.GetString("EditId");

            if (!string.IsNullOrEmpty(editId))
            {
                entry.Id = int.Parse(editId);
                _context.FormEntries.Update(entry);
            }
            else
            {
                _context.FormEntries.Add(entry);
            }

            _context.SaveChanges();
            HttpContext.Session.Remove("EditId");
            HttpContext.Session.Clear();

            return RedirectToAction(nameof(Success));
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
