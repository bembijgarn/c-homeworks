using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication3.Models;

namespace WebApplication3.middle
{
    public class jsonmiddle
    {
        private readonly RequestDelegate _request;

        public jsonmiddle(RequestDelegate request)
        {
            _request = request;
        }
        
        public async Task Invoke(HttpContext context,IConfiguration cufugu)
        {
            
            if (context.Request.Path.Value.Contains("/Home/Final"))
            {
                
                var info = cufugu.GetSection("Person");
                var report = info.GetChildren().Select(x => $"{x.Key.ToString()} : {x.Value.ToString()}");
                var log = string.Join("\n",report);
                await context.Response.WriteAsync(log);
                
            }
            else
            {
                await _request(context);
            }
        }
    }
}
