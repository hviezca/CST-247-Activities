using BibleVerseApp.Models;
using BibleVerseApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Controllers
{
    public class EntryController : Controller
    {
        // GET: Entry
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Entry page!";
            return View("Create");
        }

        // GET: Entry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Entry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entry/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            EntrySecurityService service = new EntrySecurityService();

            try
            {
                var result = service.CreateEntry(collection);

                if (result)
                {
                    return RedirectToAction("Index");
                    //return Content("Entry Success!");
                }
                else
                {
                    return View();
                }                
            }
            catch
            {
                return View();
            }
        
        }

        // GET: Entry/Search/model
        public ActionResult Search()
        {
            return View();
        }

        // POST: Entry/Search/model
        [HttpPost]
        public ActionResult Search(FormCollection collection)
        {            
            return View("SearchResults", collection);
        }

        // GET: Entry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Entry/Edit/5
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

        // GET: Entry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Entry/Delete/5
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
