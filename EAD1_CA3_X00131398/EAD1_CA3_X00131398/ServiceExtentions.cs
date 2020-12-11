using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;

namespace EAD1_CA3_X00131398
{
    public static class ServiceExtensions
    {
        public static async Task<T> GetJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Bearer-Token", "d8KcVpyqLxtuA57QLKLA_88oSUFTqaOIdIUqWgnF4S3ialJu2sSQPqZfGRtpmMT5MvNXDUtp0jP-awY8cN4DZaP6y0qzD0I21fwtT4gZRItMFHYDJHZCpdeYDyLOX3Yx");


            var response = await httpClient.SendAsync(request);
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            response.Headers.Add("Bearer-Token", "d8KcVpyqLxtuA57QLKLA_88oSUFTqaOIdIUqWgnF4S3ialJu2sSQPqZfGRtpmMT5MvNXDUtp0jP-awY8cN4DZaP6y0qzD0I21fwtT4gZRItMFHYDJHZCpdeYDyLOX3Yx");
            response.EnsureSuccessStatusCode();

            var responseBytes = await response.Content.ReadAsByteArrayAsync();


            return JsonSerializer.Deserialize<T>(responseBytes, new JsonSerializerOptions { });
        }
    }
}
