using System.Threading.Tasks;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Net.Http.Headers;

namespace Jering.IocServices.System.Net.Http
{
    public class HttpClientService : IHttpClientService, IDisposable
    {
        private bool _disposed;
        private HttpClient _httpClient;

        public HttpClientService()
        {
            _httpClient = new HttpClient();
        }

        public HttpRequestHeaders DefaultRequestHeaders
        {
            get
            {
                return _httpClient.DefaultRequestHeaders;
            }
        }

        public Uri BaseAddress
        {
            get
            {
                return _httpClient.BaseAddress;
            }

            set
            {
                _httpClient.BaseAddress = value;
            }
        }

        public TimeSpan Timeout
        {
            get
            {
                return _httpClient.Timeout;
            }

            set
            {
                _httpClient.Timeout = value;
            }
        }

        public Int64 MaxResponseContentBufferSize
        {
            get
            {
                return _httpClient.MaxResponseContentBufferSize;
            }

            set
            {
                _httpClient.MaxResponseContentBufferSize = value;
            }
        }

        public Task<String> GetStringAsync(String requestUri)
        {
            return _httpClient.GetStringAsync(requestUri);
        }

        public Task<String> GetStringAsync(Uri requestUri)
        {
            return _httpClient.GetStringAsync(requestUri);
        }

        public Task<Byte[]> GetByteArrayAsync(String requestUri)
        {
            return _httpClient.GetByteArrayAsync(requestUri);
        }

        public Task<Byte[]> GetByteArrayAsync(Uri requestUri)
        {
            return _httpClient.GetByteArrayAsync(requestUri);
        }

        public Task<Stream> GetStreamAsync(String requestUri)
        {
            return _httpClient.GetStreamAsync(requestUri);
        }

        public Task<Stream> GetStreamAsync(Uri requestUri)
        {
            return _httpClient.GetStreamAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(String requestUri)
        {
            return _httpClient.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            return _httpClient.GetAsync(requestUri);
        }

        public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption)
        {
            return _httpClient.GetAsync(requestUri, completionOption);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return _httpClient.GetAsync(requestUri, completionOption);
        }

        public Task<HttpResponseMessage> GetAsync(String requestUri, CancellationToken cancellationToken)
        {
            return _httpClient.GetAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return _httpClient.GetAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content)
        {
            return _httpClient.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            return _httpClient.PostAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _httpClient.PostAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content)
        {
            return _httpClient.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            return _httpClient.PutAsync(requestUri, content);
        }

        public Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _httpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return _httpClient.PutAsync(requestUri, content, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(String requestUri)
        {
            return _httpClient.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            return _httpClient.DeleteAsync(requestUri);
        }

        public Task<HttpResponseMessage> DeleteAsync(String requestUri, CancellationToken cancellationToken)
        {
            return _httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return _httpClient.DeleteAsync(requestUri, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return _httpClient.SendAsync(request);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return _httpClient.SendAsync(request, cancellationToken);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            return _httpClient.SendAsync(request, completionOption);
        }

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return _httpClient.SendAsync(request, completionOption, cancellationToken);
        }

        public void CancelPendingRequests()
        {
            _httpClient.CancelPendingRequests();
        }

        /// <summary>
        /// Disposes the underlying <see cref="HttpClient"/>.
        /// </summary>
        public void Dispose()
        {
            if (!_disposed)
            {
                _httpClient.Dispose();
                _disposed = true;
            }
        }
    }
}