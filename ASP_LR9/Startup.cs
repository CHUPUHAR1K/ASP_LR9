using global::ASP_LR9.Components;
using ASP_LR9.Components;

namespace ASP_LR9
{
  

        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddMvc();
                services.AddHttpClient<WeatherViewComponent>();
            }

            public void Configure(IApplicationBuilder app)
            {
                app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        }
   
}
