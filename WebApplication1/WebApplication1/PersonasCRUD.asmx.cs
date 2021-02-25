using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de PersonasCRUD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class PersonasCRUD : System.Web.Services.WebService
    {

        PersonasEntities conn = new PersonasEntities();

        [WebMethod]
        public string Get()
        {
            string toReturn = "";
            foreach (var psI in conn.PERSONAS)
                toReturn = toReturn + "  ||  " + psI.ToString();

            return toReturn;
        }

        [WebMethod]
        public string Find(string Key)
        {
            Key = Key.ToLower();
            IQueryable<PERSONA> pers = conn.PERSONAS.Where(p =>
                                    p.ID_PERSONAS.ToString().ToLower().Contains(Key) ||
                                    p.Nombre.ToString().ToLower().Contains(Key) ||
                                    p.Apellidos.ToString().ToLower().Contains(Key) ||
                                    p.NIF.ToString().ToLower().Contains(Key) ||
                                    p.Dirección.ToString().ToLower().Contains(Key) ||
                                    p.Ciudad.ToString().ToLower().Contains(Key) ||
                                    p.Estado_Civil.ToString().ToLower().Contains(Key) ||
                                    p.Sexo.ToString().ToLower().Contains(Key) ||
                                    p.Código_Postal.ToString().ToLower().Contains(Key) ||
                                    p.Provincia.ToString().ToLower().Contains(Key) ||
                                    Key.Contains(p.ID_PERSONAS.ToString().ToLower()) ||
                                   Key.Contains(p.Nombre.ToString().ToLower()) ||
                                   Key.Contains(p.Apellidos.ToString().ToLower()) ||
                                    Key.Contains(p.NIF.ToString().ToLower()) ||
                                    Key.Contains(p.Dirección.ToString().ToLower()) ||
                                    Key.Contains(p.Ciudad.ToString().ToLower()) ||
                                    Key.Contains(p.Estado_Civil.ToString().ToLower()) ||
                                    Key.Contains(p.Sexo.ToString().ToLower()) ||
                                   Key.Contains(p.Código_Postal.ToString().ToLower()) ||
                                   Key.Contains(p.Provincia.ToString().ToLower())
                                );


            string toReturn = "";
            foreach (var psI in pers)
                toReturn = toReturn + "  ||  " + psI.ToString();

            return toReturn;
        }

        [WebMethod]
        public string Add(string Nombre, string Apellidos, string NIF, string Dirección, string Ciudad, string Estado_Civil, string Sexo, int Código_Postal, string Provincia)
        {
            PERSONA p = new PERSONA();
            p.Nombre = Nombre;
            p.Apellidos = Apellidos;
            p.NIF = NIF;
            p.Dirección = Dirección;
            p.Ciudad = Ciudad;
            p.Estado_Civil = Estado_Civil;
            p.Sexo = Sexo;
            p.Código_Postal = Código_Postal;
            p.Provincia = Provincia;

            conn.PERSONAS.Add(p);

            conn.SaveChanges();

            return p.ToString();
        }

        [WebMethod]
        public string Modify(int id, string Nombre, string Apellidos, string NIF, string Dirección, string Ciudad, string Estado_Civil, string Sexo, int Código_Postal, string Provincia)
        {
            PERSONA p = conn.PERSONAS.Where(pe => pe.ID_PERSONAS == id).First();
            p.Nombre = Nombre;
            p.Apellidos = Apellidos;
            p.NIF = NIF;
            p.Dirección = Dirección;
            p.Ciudad = Ciudad;
            p.Estado_Civil = Estado_Civil;
            p.Sexo = Sexo;
            p.Código_Postal = Código_Postal;
            p.Provincia = Provincia;

            conn.SaveChanges();

            return p.ToString();
        }

        [WebMethod]
        public string Remove(int id)
        {
            PERSONA p = conn.PERSONAS.Where(pe => pe.ID_PERSONAS == id).First();
            conn.PERSONAS.Remove(p);

            conn.SaveChanges();

            return p.ToString();
        }
    }
}
