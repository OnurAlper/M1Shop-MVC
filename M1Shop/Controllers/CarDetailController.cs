using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using M1Shop.Data;
using M1Shop.Models;
using M1Shop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace M1Shop.Controllers
{
    public class CarDetailController : Controller
    {
        private readonly NorthwindContext _context;
        private readonly IHostingEnvironment _env;



        public CarDetailController(NorthwindContext context , IHostingEnvironment environment)
        {
            this._env = environment;
            _context = context;
        }
        // GET: CarDetail
        public ActionResult Index(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return View(_context.CarDetail.Take(45).ToList());

            }
            return View(_context.CarDetail.Where(i => i.IlanUser == email));
          
            
        }

        // GET: CarDetail/Details/5
        public async Task<ActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var details = await _context.CarDetail.FirstOrDefaultAsync(i => i.CarDetailId == id);
            if (details == null)
            {
                return NotFound();
            }
            return View(details);
        }


        // GET: CarDetail/Create

        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarDetail/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarDetailCreateModels detail)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (detail.Photo != null)
                {
                    string uploadsFolder = Path.Combine(_env.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + detail.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    detail.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Models.CarDetail car = new Models.CarDetail
                {
                    CarDateTime = detail.CarDateTime = DateTime.Now,
                    CarilanTitle = detail.CarilanTitle,
                    Marka = detail.Marka,
                    Seri = detail.Seri,
                    Model = detail.Model,
                    Year = detail.Year,
                    Yakit = detail.Yakit,
                    Vites = detail.Vites,
                    CarKm = detail.CarKm,
                    KasaType = detail.KasaType,
                    MotorGücü = detail.MotorGücü,
                    MotorHacmi = detail.MotorHacmi,
                    Cekis = detail.Cekis,
                    Renk = detail.Renk,
                    Garanti = (Models.Garanti)detail.Garanti,
                    Plaka = detail.Plaka,
                    Takas = (Models.Takas)detail.Takas,
                    Durum = (Models.Durum)detail.Durum,
                    PhotoPath = uniqueFileName,
                    IlanUser=User.Identity.Name
                  
                };
                _context.Add(car);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = car.CarDetailId });
                //return RedirectToAction("/Home/Index");

            }
            return View(detail);

        }

        // GET: CarDetail/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarDetail/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarDetail/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarDetail/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}