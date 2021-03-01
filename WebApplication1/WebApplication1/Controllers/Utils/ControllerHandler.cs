using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using static Utils.WebServicesUtils;

namespace WebApplication1.Controllers.Utils
{
    public class ControllerHandler : DelegatingHandler
    {
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Add login exception in token handler
            if (request.RequestUri.AbsolutePath.ToString().Equals("/login"))
                return base.SendAsync(request, cancellationToken);

            try
            {
                IEnumerable<string> headers;
                    request.Headers.TryGetValues("Authorization", out headers);

                DateTime date = new JwtSecurityTokenHandler()
                            .ReadToken(headers.First().Substring(7))
                            .ValidTo;

                if (DateTime.Compare(date, DateTime.Now) < 0)
                    throw new Exception("error");

            }catch (Exception e)
            {
                throw new Exception("Error con el token\n\t" + e.Message);
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}