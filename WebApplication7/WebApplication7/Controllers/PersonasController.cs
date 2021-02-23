using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class PersonasController : Controller
    {
        private const string PersonasListView = "PersonasListView";
        private const string PersonasCheckView = "PersonasCheckView";
        private const string PersonasDetailView = "PersonasDeatialView";


        [HttpGet]
        [Route("personas")]
        [Route("clientes")]
        [Route("empleados")]
        public ActionResult List()
        {
            string KeySearch = Request.QueryString.Get("q");

            if (Request.Path.ToLower().Contains("clientes"))
                KeySearch = "1";
            if (Request.Path.ToLower().Contains("empleados"))
                KeySearch = "2";

            if (KeySearch == null)
                KeySearch = "";

            List<personas> Params;

            switch (KeySearch.ToLower())
            {
                case "clientes":
                    Params = new CutreCocheEntities().personas.Where(p => p.id_tipopersona == 1).ToList();
                    break;
                case "1":
                    Params = new CutreCocheEntities().personas.Where(p => p.id_tipopersona == 1).ToList();
                    break;
                case "empleados":
                    Params = new CutreCocheEntities().personas.Where(p => p.id_tipopersona == 2).ToList();
                    break;
                case "2":
                    Params = new CutreCocheEntities().personas.Where(p => p.id_tipopersona == 2).ToList();
                    break;
                default:
                    Params = new CutreCocheEntities().personas.ToList();
                    break;
            }
            if (bool.Parse(Request.Params["toSelect"]))
            {
                return View(PersonasCheckView, Params);
            }

            return View(PersonasListView, Params);
        }


        [HttpGet]
        [Route("personas/create")]
        [Route("clientes/create")]
        [Route("empleados/create")]
        [Route("personas/edit")]
        [Route("clientes/edit")]
        [Route("empleados/edit")]
        public ActionResult Create()
        {
            List<KeyValuePair<string, Object>> Params = new List<KeyValuePair<string, Object>>();
            int? idPersona = null;
            if (Request.Params["id_persona"] != null)
                idPersona = int.Parse(Request.Params["id_persona"]);

            if (Request.Path.ToLower().StartsWith("clientes"))
                Params.Add(new KeyValuePair<string, Object>("tipo_usuario", 1));
            if (Request.Path.ToLower().StartsWith("empleados"))
                Params.Add(new KeyValuePair<string, Object>("tipo_usuario", 2));

            personas fromId = new personas();
            if (idPersona != null )
                fromId = new CutreCocheEntities().
                    personas.Where(p => p.id_persona == idPersona).First();

            personas toDisplay = fromId;

            if (!Request.Path.ToLower().EndsWith("edit"))
            {
                toDisplay = new personas();
                toDisplay.nombre = fromId.nombre;
                toDisplay.apellidos = fromId.apellidos;
                toDisplay.telefono = fromId.telefono;
                toDisplay.direccion = fromId.direccion;
                toDisplay.id_tipopersona = fromId.id_tipopersona;
            }

            Params.Add(new KeyValuePair<string, Object>("editable", true));

            foreach (KeyValuePair<string, Object> ParamsI in Params)
                ViewData.Add(ParamsI);

            return View("CreatePersonView", toDisplay);


        }
      

        [HttpPost]
        [Route("personas/create")]
        public ActionResult Add()
        {

            string nif = Request.Form.Get("nif");
            string nombre = Request.Form.Get("nombre");
            string apellidos = Request.Form.Get("apellidos");
            string telefono = Request.Form.Get("telefono");
            string direccion = Request.Form.Get("direccion");
            string email = Request.Form.Get("email");
            string id_tipopersona = Request.Form.Get("id_tipopersona");

            personas p = new personas();
            p.nif = nif;
            p.nombre = nombre;
            p.apellidos = apellidos;
            p.telefono = telefono;
            p.direccion = direccion;
            p.email = email;
            p.id_tipopersona = int.Parse(id_tipopersona);
            CutreCocheEntities dao = new CutreCocheEntities();
            dao.personas.Add(p);
            dao.SaveChanges();


            return List() ;

        }


        [Route("personas/delete")]
        public ActionResult Remove()
        {
            int? idPersona = int.Parse(Request.Params["id_persona"]);

            personas fromId = new personas();
            if (idPersona != null)
                fromId = new CutreCocheEntities().
                    personas.Where(p => p.id_persona == idPersona).First();
            CutreCocheEntities db = new CutreCocheEntities();
            db.personas.Remove(fromId);
            db.SaveChanges();


            return List();
        }
    }
}