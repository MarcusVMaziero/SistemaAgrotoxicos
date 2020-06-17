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
    public class ExemploController : Controller
    {
        private ModelExemplo db = new ModelExemplo();

        // GET: Exemplo
        public ActionResult Listar()
        {
            return View(db.exemplo.ToList());
        }

        // GET: Exemplo/Detalhe/5
        public ActionResult Detalhe(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exemplo exemplo = db.exemplo.Find(id);
            if (exemplo == null)
            {
                return HttpNotFound();
            }
            return View(exemplo);
        }

        // GET: Exemplo/Cadastrar
        public ActionResult Cadastrar()
        {
            return View();
        }

        // POST: Exemplo/Cadastrar
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar([Bind(Include = "id,nome")] exemplo exemplo)
        {
            if (ModelState.IsValid)
            {
                db.exemplo.Add(exemplo);
                db.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(exemplo);
        }

        // GET: Exemplo/Editar/5
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exemplo exemplo = db.exemplo.Find(id);
            if (exemplo == null)
            {
                return HttpNotFound();
            }
            return View(exemplo);
        }

        // POST: Exemplo/Editar/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "id,nome")] exemplo exemplo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exemplo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Listar");
            }
            return View(exemplo);
        }

        // GET: Exemplo/Deletar/5
        public ActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            exemplo exemplo = db.exemplo.Find(id);
            if (exemplo == null)
            {
                return HttpNotFound();
            }
            return View(exemplo);
        }

        // POST: Exemplo/Deletar/5
        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            exemplo exemplo = db.exemplo.Find(id);
            db.exemplo.Remove(exemplo);
            db.SaveChanges();
            return RedirectToAction("Listar");
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
