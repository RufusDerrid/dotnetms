using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace console 
{
    public class Startup 
    {
        public Startup(IHostingEnvironment env) 
        {

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment environment, 
            ILoggerFactory loggerFactory) 
        {
            app.Run(async (context) => {
                await context.Response.WriteAsync("Test!!!");
            });
        }

    }
}