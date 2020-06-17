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
    public class PropriedadeController : Controller
    {
        private ModelAgrotoxicos db = new ModelAgrotoxicos();

        // GET: Exemplo
        public ActionResult Listar()
        {
            return View(db.propriedade.ToList());
        }

        // GET: Exemplo/Detalhe/5
        public ActionResult Detalhe(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            propriedade propriedade = db.propriedade.Find(id);
            if (propriedade == null)
            {
                return HttpNotFound();
            }
            return View(propriedade);
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
        public ActionResult Cadastrar([Bind(Include = "id,nome, nome_proprietario, endereco")] propriedade propriedade)
        {
            if (ModelState.IsValid)
            {
                db.propriedade.Add(propriedade);
                db.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(propriedade);
        }

        // GET: Exemplo/Editar/5
        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            propriedade propriedade = db.propriedade.Find(id);
            if (propriedade == null)
            {
                return HttpNotFound();
            }
            return View(propriedade);
        }

        // POST: Exemplo/Editar/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar([Bind(Include = "id,nome, nome_proprietario, endereco")] propriedade propriedade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propriedade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Listar");
            }
            return View(propriedade);
        }

        // GET: Exemplo/Deletar/5
        public ActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            propriedade propriedade = db.propriedade.Find(id);
            if (propriedade == null)
            {
                return HttpNotFound();
            }
            return View(propriedade);
        }

        // POST: Exemplo/Deletar/5
        [HttpPost, ActionName("Deletar")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            propriedade propriedade = db.propriedade.Find(id);
            db.propriedade.Remove(propriedade);
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
