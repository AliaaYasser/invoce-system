using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using task.Models;

namespace task.Controllers
{
    public class invsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: invs
        public ActionResult Index()
        {
            return View(db.invs.ToList());
        }

        // GET: invs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inv inv = db.invs.Find(id);
            if (inv == null)
            {
                return HttpNotFound();
            }
            return View(inv);
        }

        // GET: invs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: invs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(inv inv)
        {
            if (ModelState.IsValid)
            {
               int x = 0;
                int i = 0;
                inv vv = new inv();
                NameValueCollection nvc = Request.Form;
                while (x == 0)
                {
                    string ii = i.ToString();
                    if (nvc["Item" + ii] != null)
                    {
                        inv v = new inv();
                        v.id = inv.id;
                        v.Invoice_No = inv.Invoice_No;
                        v.Invoice_Date = inv.Invoice_Date;
                        v.Store = inv.Store;
                        v.Item = nvc["Item" + ii];
                        v.Unit = nvc["Unit" + ii];
                        v.Price = nvc["Price" + ii];
                        v.Qty = nvc["Qty" + ii];
                        v.Discount = nvc["Discount" + ii];
                        v.Net = nvc["Net" + ii];
                        v.Taxes_All = inv.Taxes_All;
                        v.Total_All = inv.Total_All;
                        v.Net_All = inv.Net_All;
                        db.invs.Add(v);
                        db.SaveChanges();
                        i++;

                    }
                    if(nvc["Item" + ii] == null)
                    {
                        x = 6;
                    }
                   
                }

                return View();
            }

            return View(inv);
        }

        // GET: invs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inv inv = db.invs.Find(id);
            if (inv == null)
            {
                return HttpNotFound();
            }
            return View(inv);
        }

        // POST: invs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Invoice_No,Invoice_Date,Store,Item,Unit,Price,Qty,Total,Discount,Net,Total_All,Taxes_All,Net_All")] inv inv)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inv);
        }

        // GET: invs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inv inv = db.invs.Find(id);
            if (inv == null)
            {
                return HttpNotFound();
            }
            return View(inv);
        }

        // POST: invs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            inv inv = db.invs.Find(id);
            db.invs.Remove(inv);
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
