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
    public class operacionesController : Controller
    {
        private CutreCocheEntities db = new CutreCocheEntities();

        // GET: operaciones
        public ActionResult Index()
        {
            var operaciones = db.operaciones.Include(o => o.coche).Include(o => o.personas).Include(o => o.tipo_operacion).Include(o => o.personas1);
            return View(operaciones.ToList());
        }

        
        // POST: operaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("operaciones/add")]
        public ActionResult Create()
        {
            operaciones operacion = new operaciones();

            operacion.id_coche = int.Parse( Request.Form["id_coche"]);
            operacion.id_tipooperacion = int.Parse( Request.Form["id_tipooperacion"]);
            operacion.vendedor = int.Parse( Request.Form["id_vendedor"]);
            operacion.cliente = int.Parse( Request.Form["id_cliente"]);
            operacion.precio = double.Parse( Request.Form["precio"]);
            operacion.fecha = DateTime.Now;

            coche cocheOpe = db.coche.Where(c => c.id_coche == operacion.id_coche ).First();
            if (cocheOpe.stock <= 0 && operacion.id_tipooperacion == 2)
            {
                ViewData["msg"] = "stock del coche insufciente";
                return View("ErrorVentaView");
            }
            else if (operacion.id_tipooperacion == 2)
                cocheOpe.stock = -1;
            else if (operacion.id_tipooperacion == 1)
                cocheOpe.stock = +1;

            db.operaciones.Add(operacion);
            db.SaveChanges();

           return View("Index", db.operaciones.ToList());
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
