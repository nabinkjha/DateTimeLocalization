using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;

namespace GetSearchDemo
{
    public class Startup
    {
        public CultureInfo EnGbCulture = new CultureInfo("en-GB");
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture(EnGbCulture);
                options.SupportedCultures = new List<CultureInfo> { EnGbCulture };
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(EnGbCulture),
                // Formatting numbers, dates, etc.
                SupportedCultures = new List<CultureInfo> { EnGbCulture },
                // UI strings that we have localized.
                SupportedUICultures = new List<CultureInfo> { EnGbCulture },
                RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider { },
                    new CookieRequestCultureProvider { },
                },
            });
            app.UseMvcWithDefaultRoute();
        }
    }
}
