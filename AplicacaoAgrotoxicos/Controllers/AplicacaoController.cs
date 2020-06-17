using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AplicacaoAgrotoxicos.Models;

namespace AplicacaoAgrotoxicos.Controllers
{
    public class AplicacaoController : Controller
    {
        private ModelAgrotoxicos db = new ModelAgrotoxicos();

        // GET: Aplicacao
        public ActionResult Index()
        {
            //var aplicacao = db.aplicacao.Include(a => a.produto);
            return View(db.aplicacao.ToList());
        }

        // GET: Aplicacao/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aplicacao aplicacao = db.aplicacao.Find(id);
            if (aplicacao == null)
            {
                return HttpNotFound();
            }
            return View(aplicacao);
        }

        // GET: Aplicacao/Create
        public ActionResult Create()
        {
            ViewBag.id = new SelectList(db.produto, "id", "nome");
            return View();
        }

        // POST: Aplicacao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,hecitares,fk_produto,dataLimite")] aplicacao aplicacao)
        {
            if (ModelState.IsValid)
            {
                db.aplicacao.Add(aplicacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id = new SelectList(db.produto, "id", "nome", aplicacao.id);
            return View(aplicacao);
        }

        // GET: Aplicacao/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aplicacao aplicacao = db.aplicacao.Find(id);
            if (aplicacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = new SelectList(db.produto, "id", "nome", aplicacao.id);
            return View(aplicacao);
        }

        // POST: Aplicacao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,hecitares,fk_produto,dataLimite")] aplicacao aplicacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aplicacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id = new SelectList(db.produto, "id", "nome", aplicacao.id);
            return View(aplicacao);
        }

        // GET: Aplicacao/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aplicacao aplicacao = db.aplicacao.Find(id);
            if (aplicacao == null)
            {
                return HttpNotFound();
            }
            return View(aplicacao);
        }

        // POST: Aplicacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            aplicacao aplicacao = db.aplicacao.Find(id);
            db.aplicacao.Remove(aplicacao);
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
