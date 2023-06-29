namespace FirstResponsiveWebAppGarrels
{
    //Startup file to run Program
    public class Startup
    {
        // Use this method to add services to the project.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews(); // add MVC services
            // add other services here

        }
        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            // mark where routing decisions are made
            // configure middleware that runs after routing decisions have been made
            app.UseEndpoints(endpoints => {

                endpoints.MapControllers();

                // most specific route – 5 required segments
                endpoints.MapControllerRoute( 
                   name: "paging_and_sorting",
                   pattern: "{controller}/{action}/{id}/page{page}/sort-by-{sortby}");
                    
               // specific route – 4 required segments
                endpoints.MapControllerRoute( 
                  name: "paging",
                  pattern: "{controller}/{action}/{id}/page{page}");

                endpoints.MapAreaControllerRoute(
                    name: "admin", 
                    areaName: "Admin", 
                    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                // least specific route – 0 required segments
                endpoints.MapControllerRoute( 
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
        });
        }
    }
}