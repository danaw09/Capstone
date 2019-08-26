using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapStone.Controllers
{
    public class AttendenceController : Controller
    {
        // GET: Attendence
        public ActionResult Index()
        {
            return View();
        }

        // GET: Attendence/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Attendence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attendence/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attendence/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attendence/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Attendence/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attendence/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
