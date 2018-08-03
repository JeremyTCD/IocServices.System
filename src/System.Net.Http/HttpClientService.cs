using System.Threading.Tasks;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Net.Http.Headers;

namespace Jering.IocServices.System.Net.Http
{
    public class HttpClientService : IHttpClientService
    {
        private HttpClient _httpClient;

        public HttpRequestHeaders DefaultRequestHeaders { get => _httpClient.DefaultRequestHeaders; }
        public Uri BaseAddress { get => _httpClient.BaseAddress; set => _httpClient.BaseAddress = value; }
        public TimeSpan Timeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long MaxResponseContentBufferSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HttpClientService()
        {
            _httpClient = (new HttpClient());
        }

        public void CancelPendingRequests()
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return _httpClient.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetByteArrayAsync(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetStreamAsync(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetStreamAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetStringAsync(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetStringAsync(Uri requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}