using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class cochesController : Controller
    {
        private CutreCocheEntities db = new CutreCocheEntities();

        // GET: coches1
        public ActionResult Index()
        {
            return View(db.coche.ToList());
        }

        // GET: coches1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            coche coche = db.coche.Find(id);
            if (coche == null)
            {
                return HttpNotFound();
            }
            return View(coche);
        }

        // GET: coches1/Create
        public ActionResult Create()
        {
            bool isNew = bool.Parse(Request.Params["is_new"]);
            coche cToDisplay = new coche();
            if (Request.Params["id_coche"] != null) {
                int idCoche = int.Parse(Request.Params["id_coche"]);
                coche cToCopy = db.coche.Where(c => c.id_coche == idCoche).First();
                if (isNew)
                {
                    cToDisplay.marca = cToCopy.marca;
                    cToDisplay.modelo = cToCopy.modelo;
                    cToDisplay.puertas = cToCopy.puertas;
                }
                cToDisplay = cToCopy;
            }

            return View(cToDisplay);
        }

        // POST: coches1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_coche,marca,modelo,puertas,color,kilometraje,tipo,garantia,stock,foto")] coche coche)
        {
            if (ModelState.IsValid)
            {
                coche present = db.coche.Find(coche);
                if ( present == null)
                {
                    db.coche.Add(coche);
                }
                else present = coche;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Craete", coche);
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
