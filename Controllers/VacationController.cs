using FacadeGUIExample2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FacadeGUIExample2.Controllers
{
    public class VacationController : Controller
    {
        private readonly VacationPlanner vacationPlanner;

        public VacationController()
        {
            vacationPlanner = new VacationPlanner();
        }
        // GET: VacationController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VacationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VacationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VacationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Plan(string destination, string accommodationLocation, int duration)
        {
            BookingDetails bookingDetails = vacationPlanner.PlanVacation(destination, accommodationLocation, duration);
            return View("BookingConfirmation", bookingDetails);
        }

        // GET: VacationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VacationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VacationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VacationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
