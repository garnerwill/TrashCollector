using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers
        public ActionResult Index()
        {
            var currentUserId = User.Identity.GetUserId();

            var currentcustomer= db.Customers.Include(s=>s.ApplicationUser).Where(c => c.ApplicationId == currentUserId).ToList();
            return View(currentcustomer);
        }

        //GET: Current Customer Bill Details
        public ActionResult BillDetails()
        {
            var currentUserId = User.Identity.GetUserId();

            var currentcustomer = db.Customers.Include(s => s.ApplicationId).Where(c => c.ApplicationId == currentUserId);
            return View(currentcustomer);
        }
        //GET: Current Customer Details
        public ActionResult CustomerDetails()
        {
            var currentUserId = User.Identity.GetUserId();

            var currentcustomer = db.Customers.Include(s => s.ApplicationUser).Where(c => c.ApplicationId == currentUserId);
            return View(currentcustomer);
        }
        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                var currentUserId = User.Identity.GetUserId();
                var currentcustomer = db.Customers.Where(s => s.ApplicationId == currentUserId).Single();
                return View(currentcustomer);
                    
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationId = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,StreetAddress,City,State,Zipcode,TrashDay,ExtraPickUp,")] Customer customer)
        {
            var userId = User.Identity.GetUserId();
            customer.ApplicationId = userId;
            customer.UserRoles = "Customer";
            
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            

            ViewBag.ApplicationId = new SelectList(db.Users, "Id", "Email", customer.ApplicationId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationId = new SelectList(db.Users, "Id", "Email", customer.ApplicationId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Balance,StreetAddress,City,State,Zipcode,TrashDay,ApplicationId,UserRoles,Email,UserName,RequestPickup,Password,ConfirmPassword,ExtraPickUp")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationId = new SelectList(db.Users, "Id", "Email", customer.ApplicationId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
