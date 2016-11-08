using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Mark.RestfulCaller
{
    public class RestNoContentResult
    {
        public HttpStatusCode Status { get; set; }
        public HttpResponseHeaders Headers { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
    }

}
