using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using static Utils.WebServicesUtils;
using System.Net;

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
            if (!request.RequestUri.AbsolutePath.ToString().Equals("/login"))
            {
                try
                {
                    IEnumerable<string> headers;
                    request.Headers.TryGetValues("Authorization", out headers);

                    DateTime date = new JwtSecurityTokenHandler()
                                .ReadToken(headers.First().Substring(7))
                                .ValidTo;

                    if (DateTime.Compare(date, DateTime.Now) < 0)
                        throw new Exception("error con la valided del token");

                }
                catch (Exception e)
                {
                    HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    resp.Content = new StringContent("Error con el token:   " + e.Message);
                    return Task<HttpResponseMessage>.Factory.StartNew( () => resp );
                }
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}