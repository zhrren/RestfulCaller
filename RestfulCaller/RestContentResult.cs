using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Mark.RestfulCaller
{
    public class RestCallContentResult<TContent> where TContent : class
    {
        public HttpStatusCode Status { get; set; }
        public HttpResponseHeaders Headers { get; set; }
        public TContent Content { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
    }

    public class RestContentResult
    {
        public HttpStatusCode Status { get; set; }
        public HttpResponseHeaders Headers { get; set; }
        public object Content { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
    }
}

