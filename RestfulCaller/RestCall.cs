using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mark.RestfulCaller
{
    public static class RestCall
    {
        private static Dictionary<string, string> _defaultHeaders = new Dictionary<string, string>();

        public static Dictionary<string, string> DefaultHeaders { get { return _defaultHeaders; } }

        public static Task<RestContentResult> CallGet(string uri, string username, string password)
        {
            return CallGet(CreateUri(uri), username, password);
        }

        public static Task<RestContentResult> CallGet(Uri uri, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCall(requestMessage);
        }

        public static Task<RestContentResult> CallGet(string uri)
        {
            return CallGet(CreateUri(uri));
        }

        public static Task<RestContentResult> CallGet(Uri uri)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            return MakeRestCall(requestMessage);
        }

        public static Task<RestCallContentResult<TContentOut>> CallGet<TContentOut>(string uri, string username, string password) where TContentOut : class
        {
            return CallGet<TContentOut>(CreateUri(uri), username, password);
        }

        public static Task<RestCallContentResult<TContentOut>> CallGet<TContentOut>(Uri uri, string username, string password) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCall<TContentOut>(requestMessage);
        }

        public static Task<RestCallContentResult<TContentOut>> CallGet<TContentOut>(string uri)
            where TContentOut : class
        {
            return CallGet<TContentOut>(CreateUri(uri));
        }

        public static Task<RestCallContentResult<TContentOut>> CallGet<TContentOut>(Uri uri) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            return MakeRestCall<TContentOut>(requestMessage);
        }

        public static async Task<RestContentResult> CallGetAsync(string uri, string username, string password)
        {
            return await CallGetAsync(CreateUri(uri), username, password);
        }

        public static async Task<RestContentResult> CallGetAsync(Uri uri, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallAsync(requestMessage);
        }

        public static async Task<RestContentResult> CallGetAsync(string uri)
        {
            return await CallGetAsync(CreateUri(uri));
        }

        public async static Task<RestContentResult> CallGetAsync(Uri uri)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            return await MakeRestCallAsync(requestMessage);
        }

        public static async Task<RestCallContentResult<TContentOut>> CallGetAsync<TContentOut>(string uri, string username, string password) where TContentOut : class
        {
            return await CallGetAsync<TContentOut>(CreateUri(uri), username, password);
        }

        public static async Task<RestCallContentResult<TContentOut>> CallGetAsync<TContentOut>(Uri uri, string username, string password) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallAsync<TContentOut>(requestMessage);
        }

        public static async Task<RestCallContentResult<TContentOut>> CallGetAsync<TContentOut>(string uri)
            where TContentOut : class
        {
            return await CallGetAsync<TContentOut>(CreateUri(uri));
        }

        public async static Task<RestCallContentResult<TContentOut>> CallGetAsync<TContentOut>(Uri uri) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Get, uri);
            return await MakeRestCallAsync<TContentOut>(requestMessage);
        }

        public static Task<RestContentResult> CallPost<TContentIn>(string uri, TContentIn content, string username, string password)
        {
            return CallPost(CreateUri(uri), content, username, password);
        }

        public static Task<RestContentResult> CallPost<TContentIn>(Uri uri, TContentIn content, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");

            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCall(requestMessage);
        }

        public static Task<RestContentResult> CallPost<TContentIn>(string uri, TContentIn content)
        {
            return CallPost(CreateUri(uri), content);
        }

        public static Task<RestContentResult> CallPost<TContentIn>(Uri uri, TContentIn content)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return MakeRestCall(requestMessage);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPost<TContentOut, TContentIn>(string uri, TContentIn content, string username, string password) where TContentOut : class
        {
            return CallPost<TContentOut, TContentIn>(CreateUri(uri), content, username, password);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPost<TContentOut, TContentIn>(Uri uri, TContentIn content, string username, string password) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCall<TContentOut>(requestMessage);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPost<TContentOut, TContentIn>(string uri, TContentIn content) where TContentOut : class
        {
            return CallPost<TContentOut, TContentIn>(CreateUri(uri), content);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPost<TContentOut, TContentIn>(Uri uri, TContentIn content) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return MakeRestCall<TContentOut>(requestMessage);
        }

        public static async Task<RestContentResult> CallPostAsync<TContentIn>(string uri, TContentIn content, string username, string password)
        {
            return await CallPostAsync(CreateUri(uri), content, username, password);
        }

        public async static Task<RestContentResult> CallPostAsync<TContentIn>(Uri uri, TContentIn content, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallAsync(requestMessage);
        }

        public async static Task<RestContentResult> CallPostAsync<TContentIn>(string uri, TContentIn content)
        {
            return await CallPostAsync(CreateUri(uri), content);
        }

        public async static Task<RestContentResult> CallPostAsync<TContentIn>(Uri uri, TContentIn content)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return await MakeRestCallAsync(requestMessage);
        }

        public static async Task<RestCallContentResult<TContentOut>> CallPostAsync<TContentOut, TContentIn>(string uri, TContentIn content, string username, string password) where TContentOut : class
        {
            return await CallPostAsync<TContentOut, TContentIn>(CreateUri(uri), content, username, password);
        }

        public async static Task<RestCallContentResult<TContentOut>> CallPostAsync<TContentOut, TContentIn>(Uri uri, TContentIn content, string username, string password) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallAsync<TContentOut>(requestMessage);
        }

        public async static Task<RestCallContentResult<TContentOut>> CallPostAsync<TContentOut, TContentIn>(string uri, TContentIn content) where TContentOut : class
        {
            return await CallPostAsync<TContentOut, TContentIn>(CreateUri(uri), content);
        }

        public async static Task<RestCallContentResult<TContentOut>> CallPostAsync<TContentOut, TContentIn>(Uri uri, TContentIn content) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Post, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return await MakeRestCallAsync<TContentOut>(requestMessage);
        }

        public static Task<RestContentResult> CallPut<TContentIn>(string uri, TContentIn content, string username, string password)
        {
            return CallPut(CreateUri(uri), content, username, password);
        }

        public static Task<RestContentResult> CallPut<TContentIn>(Uri uri, TContentIn content, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCall(requestMessage);
        }

        public static Task<RestContentResult> CallPut<TContentIn>(string uri, TContentIn content)
        {
            return CallPut(CreateUri(uri), content);
        }

        public static Task<RestContentResult> CallPut<TContentIn>(Uri uri, TContentIn content)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return MakeRestCall(requestMessage);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPut<TContentOut, TContentIn>(string uri, TContentIn content, string username, string password) where TContentOut : class
        {
            return CallPut<TContentOut, TContentIn>(CreateUri(uri), content, username, password);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPut<TContentOut, TContentIn>(Uri uri, TContentIn content, string username, string password) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCall<TContentOut>(requestMessage);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPut<TContentOut, TContentIn>(string uri, TContentIn content) where TContentOut : class
        {
            return CallPut<TContentOut, TContentIn>(CreateUri(uri), content);
        }

        public static Task<RestCallContentResult<TContentOut>> CallPut<TContentOut, TContentIn>(Uri uri, TContentIn content) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return MakeRestCall<TContentOut>(requestMessage);
        }

        public async static Task<RestContentResult> CallPutAsync<TContentIn>(string uri, TContentIn content, string username, string password)
        {
            return await CallPutAsync(CreateUri(uri), content, username, password);
        }

        public static async Task<RestContentResult> CallPutAsync<TContentIn>(Uri uri, TContentIn content, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallAsync(requestMessage);
        }

        public async static Task<RestContentResult> CallPutAsync<TContentIn>(string uri, TContentIn content)
        {
            return await CallPutAsync(CreateUri(uri), content);
        }

        public static async Task<RestContentResult> CallPutAsync<TContentIn>(Uri uri, TContentIn content)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return await MakeRestCallAsync(requestMessage);
        }

        public async static Task<RestCallContentResult<TContentOut>> CallPutAsync<TContentOut, TContentIn>(string uri, TContentIn content, string username, string password) where TContentOut : class
        {
            return await CallPutAsync<TContentOut, TContentIn>(CreateUri(uri), content, username, password);
        }

        public static async Task<RestCallContentResult<TContentOut>> CallPutAsync<TContentOut, TContentIn>(Uri uri, TContentIn content, string username, string password) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallAsync<TContentOut>(requestMessage);
        }

        public async static Task<RestCallContentResult<TContentOut>> CallPutAsync<TContentOut, TContentIn>(string uri, TContentIn content) where TContentOut : class
        {
            return await CallPutAsync<TContentOut, TContentIn>(CreateUri(uri), content);
        }

        public static async Task<RestCallContentResult<TContentOut>> CallPutAsync<TContentOut, TContentIn>(Uri uri, TContentIn content) where TContentOut : class
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Put, uri);
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return await MakeRestCallAsync<TContentOut>(requestMessage);
        }

        public static Task<RestNoContentResult> CallOptions(string uri, string username, string password)
        {
            return CallOptions(CreateUri(uri), username, password);
        }

        public static Task<RestNoContentResult> CallOptions(Uri uri, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Options, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCallWithoutContent(requestMessage);
        }

        public static Task<RestNoContentResult> CallOptions(string uri)
        {
            return CallOptions(CreateUri(uri));
        }

        public static Task<RestNoContentResult> CallOptions(Uri uri)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Options, uri);
            return MakeRestCallWithoutContent(requestMessage);
        }

        public async static Task<RestNoContentResult> CallOptionsAsync(string uri, string username, string password)
        {
            return await CallOptionsAsync(CreateUri(uri), username, password);
        }

        public async static Task<RestNoContentResult> CallOptionsAsync(Uri uri, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Options, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallWithoutContentAsync(requestMessage);
        }

        public async static Task<RestNoContentResult> CallOptionsAsync(string uri)
        {
            return await CallOptionsAsync(CreateUri(uri));
        }

        public async static Task<RestNoContentResult> CallOptionsAsync(Uri uri)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Options, uri);
            return await MakeRestCallWithoutContentAsync(requestMessage);
        }

        public static Task<RestNoContentResult> CallDelete(string uri, string username, string password)
        {
            return CallDelete(CreateUri(uri), username, password);
        }

        public static Task<RestNoContentResult> CallDelete(Uri uri, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Delete, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return MakeRestCallWithoutContent(requestMessage);
        }

        public static Task<RestNoContentResult> CallDelete(string uri)
        {
            return CallDelete(CreateUri(uri));
        }

        public static Task<RestNoContentResult> CallDelete(Uri uri)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Delete, uri);
            return MakeRestCallWithoutContent(requestMessage);
        }
        public async static Task<RestNoContentResult> CallDeleteAsync(string uri, string username, string password)
        {
            return await CallDeleteAsync(CreateUri(uri), username, password);
        }

        public async static Task<RestNoContentResult> CallDeleteAsync(Uri uri, string username, string password)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Delete, uri);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("basic", Encode(username, password));
            return await MakeRestCallWithoutContentAsync(requestMessage);
        }

        public async static Task<RestNoContentResult> CallDeleteAsync(string uri)
        {
            return await CallDeleteAsync(CreateUri(uri));
        }

        public async static Task<RestNoContentResult> CallDeleteAsync(Uri uri)
        {
            var requestMessage = CreateHttpRequestMessage(HttpMethod.Delete, uri);
            return await MakeRestCallWithoutContentAsync(requestMessage);
        }

        private async static Task<RestCallContentResult<TContent>> MakeRestCallAsync<TContent>(HttpRequestMessage request) where TContent : class
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var callResult = await client.SendAsync(request);
                    var result = new RestCallContentResult<TContent>
                    {
                        Headers = callResult.Headers,
                        Status = callResult.StatusCode,
                        Content = JsonConvert.DeserializeObject<TContent>(await callResult.Content.ReadAsStringAsync()),
                        HttpResponseMessage = callResult
                    };

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private async static Task<RestContentResult> MakeRestCallAsync(HttpRequestMessage request)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var callResult = await client.SendAsync(request);
                    var result = new RestContentResult
                    {
                        Headers = callResult.Headers,
                        Status = callResult.StatusCode,
                        Content = JsonConvert.DeserializeObject<object>(await callResult.Content.ReadAsStringAsync()), // TODO:Not sure if this will work
                        HttpResponseMessage = callResult
                    };

                    return result;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private static Task<RestCallContentResult<TContent>> MakeRestCall<TContent>(HttpRequestMessage request) where TContent : class
        {
            return MakeRestCallAsync<TContent>(request);
        }

        private static Task<RestContentResult> MakeRestCall(HttpRequestMessage request)
        {
            return MakeRestCallAsync(request);
        }

        private async static Task<RestNoContentResult> MakeRestCallWithoutContentAsync(HttpRequestMessage request)
        {
            using (var client = new HttpClient())
            {
                var callResult = await client.SendAsync(request);
                var result = new RestNoContentResult
                {
                    Headers = callResult.Headers,
                    Status = callResult.StatusCode,
                    HttpResponseMessage = callResult
                };

                return result;
            }
        }

        private static Task<RestNoContentResult> MakeRestCallWithoutContent(HttpRequestMessage request)
        {
            return MakeRestCallWithoutContentAsync(request);
        }

        private static Uri CreateUri(string uri)
        {
            return new Uri(uri);
        }

        private static string Encode(string username, string password)
        {
            var encodedString = Convert.ToBase64String(
                Encoding.UTF8.GetBytes(string.Format("{0}:{1}", username, password)));
            return encodedString;
        }

        private static HttpRequestMessage CreateHttpRequestMessage(HttpMethod httpMethod, Uri uri)
        {
            var request = new HttpRequestMessage(httpMethod, uri);
            foreach (KeyValuePair<string, string> item in _defaultHeaders)
            {
                request.Headers.Add(item.Key, item.Value);
            }
            return request;
        }
    }
}

