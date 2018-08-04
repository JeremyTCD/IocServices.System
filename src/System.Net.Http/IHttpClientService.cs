using System.Threading.Tasks;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Net.Http.Headers;

namespace Jering.IocServices.System.Net.Http
{
    public interface IHttpClientService
    {
        HttpRequestHeaders DefaultRequestHeaders { get; }
        Uri BaseAddress { get; set; }
        TimeSpan Timeout { get; set; }
        Int64 MaxResponseContentBufferSize { get; set; }

        Task<String> GetStringAsync(String requestUri);
        Task<String> GetStringAsync(Uri requestUri);
        Task<Byte[]> GetByteArrayAsync(String requestUri);
        Task<Byte[]> GetByteArrayAsync(Uri requestUri);
        Task<Stream> GetStreamAsync(String requestUri);
        Task<Stream> GetStreamAsync(Uri requestUri);
        Task<HttpResponseMessage> GetAsync(String requestUri);
        Task<HttpResponseMessage> GetAsync(Uri requestUri);
        Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption);
        Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption);
        Task<HttpResponseMessage> GetAsync(String requestUri, CancellationToken cancellationToken);
        Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);
        Task<HttpResponseMessage> GetAsync(String requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content);
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content);
        Task<HttpResponseMessage> PostAsync(String requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content);
        Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content);
        Task<HttpResponseMessage> PutAsync(String requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteAsync(String requestUri);
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri);
        Task<HttpResponseMessage> DeleteAsync(String requestUri, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption);
        Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken);
        void CancelPendingRequests();
    }
}