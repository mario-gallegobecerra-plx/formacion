using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Utils.WebServicesUtils;
using static Utils.TokenGenerator;
using System.IdentityModel.Tokens;

namespace WebApplication1.Controllers
{
    public class LoginController : ApiController
    {
        PersonasEntities conn = new PersonasEntities();

        [Route("login")]
        public IHttpActionResult Login()
        {
            try
            {
                string auth = GetHeader(Request, "Authorization");
                string loginId = AuthBase64Decode(auth)[0];
                string pass = AuthBase64Decode(auth)[1];

                IQueryable<PERSONA> loged = from p in conn.PERSONAS where p.Nombre.Equals(loginId) && p.NIF.Equals(pass) select p;

                if (!loged.Any())
                    throw new Exception("credenciales no validas");

                return Ok(GenerateTokenJwt(loginId));
            }
            catch (Exception e)
            {
                System.Web.Http.Results.UnauthorizedResult resp = Unauthorized();
                resp.Request.Content = new StringContent("Login incorrecto\n\t" + e.Message);
                return resp;
            }
                
        }



    }
}
