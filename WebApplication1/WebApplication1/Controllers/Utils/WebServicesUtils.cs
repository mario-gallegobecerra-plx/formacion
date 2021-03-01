using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Utils
{
    public class WebServicesUtils
    {

        public static string GetHeader(HttpRequestMessage Request, string Header)
        {
            IEnumerable<string> headers;
            Request.Headers.TryGetValues(Header, out headers);

            return headers.First().ToString();
        }

        public static string[] AuthBase64Decode(string Encoded)
        {
            if (Encoded.ToLower().StartsWith("basic"))
                Encoded = Encoded.Substring(5);

            return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(Encoded)).Split(':');
        }

    }
}