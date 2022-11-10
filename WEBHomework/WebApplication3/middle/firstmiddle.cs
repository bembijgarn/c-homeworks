using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication3.middle
{
    public class firstmiddle
    {
        private readonly RequestDelegate _next;
        public firstmiddle(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext htp  , IConfiguration iconf)
        {
            var controlerdescrip = htp.GetEndpoint().Metadata.GetMetadata<ControllerActionDescriptor>();
            var contrname = controlerdescrip.ControllerName;
            var actname = controlerdescrip.ActionName;

            Endpoint end = htp.Features.Get<IEndpointFeature>()?.Endpoint;
            if (end != null)
            {
                
                var info = iconf.GetSection("Information").GetChildren().FirstOrDefault(q => q.Key == "BookingNotAllowed");
                if (info != null && bool.Parse(info.Value))
                {
                    htp.SetEndpoint(new Endpoint((conext) =>
                    {
                        conext.Response.StatusCode = StatusCodes.Status404NotFound;
                        conext.Response.WriteAsync("\n The functionali is temporarily blocked");


                        return Task.CompletedTask;
                    },
                    EndpointMetadataCollection.Empty, "resource not found"));
                }
                await _next(htp);
            }
        }
       
    

    }
}
