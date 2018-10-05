using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Areas.admin.Controllers
{
    public class QuizesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: admin/Quizes
        public async Task<ActionResult> Index()
        {
            return View(await db.Quizes.ToListAsync());
        }

        // GET: admin/Quizes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quizes quizes = await db.Quizes.FindAsync(id);
            if (quizes == null)
            {
                return HttpNotFound();
            }
            return View(quizes);
        }

        // GET: admin/Quizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Quizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Quiz_Group_Id,Quiz_Name,Description")] Quizes quizes)
        {
            if (ModelState.IsValid)
            {
                db.Quizes.Add(quizes);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(quizes);
        }

        // GET: admin/Quizes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quizes quizes = await db.Quizes.FindAsync(id);
            if (quizes == null)
            {
                return HttpNotFound();
            }
            return View(quizes);
        }

        // POST: admin/Quizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Quiz_Group_Id,Quiz_Name,Description")] Quizes quizes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quizes).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(quizes);
        }

        // GET: admin/Quizes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quizes quizes = await db.Quizes.FindAsync(id);
            if (quizes == null)
            {
                return HttpNotFound();
            }
            return View(quizes);
        }

        // POST: admin/Quizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Quizes quizes = await db.Quizes.FindAsync(id);
            db.Quizes.Remove(quizes);
            await db.SaveChangesAsync();
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
