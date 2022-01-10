using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_bansach.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using web_bansach.Areas.Admin.Data;
using Microsoft.AspNetCore.Session;
using AspNetCoreHero.ToastNotification;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using web_bansach.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Rotativa.AspNetCore;

namespace web_bansach
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();

            //.AddRazorRuntimeCompilation();
            //var connection = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(connection));

            services.Add(new ServiceDescriptor(typeof(Storectx),
            new Storectx(Configuration.GetConnectionString("QLBS"))));

            //services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //services.AddDbContext<BookStoreContext>(option => option.UseSqlServer(Configuration.GetConnectionString("QLBS")));

            //var stringdb = Configuration.GetConnectionString("QLBS");
            //services.AddDbContext<BookStoreContext>(option => option.UseSqlServer(stringdb));

            var stringdb = Configuration.GetConnectionString("QLBS");
            services.AddDbContext<BookStoreContext>(option => option.UseSqlServer(stringdb));

            services.AddSingleton<HtmlEncoder>(HtmlEncoder.Create(allowedRanges: new[] { UnicodeRanges.All }));

            services.AddSession();

            services.AddNotyf(config => { 
                config.DurationInSeconds = 10; 
                config.IsDismissable = true; 
                config.Position = NotyfPosition.TopRight; });


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(
                        options =>
                        {
                            options.LoginPath = "/login";
                            options.AccessDeniedPath = "/";
                            
                        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            // app.UseMvc();
           // app.UseRouting();
            app.UseCookiePolicy();
            //Rotativa.AspNetCore.RotativaConfiguration.Setup(env, "..\\Rotativa\\Windows\\");
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});

            //trang home
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            //});

            //trang admin //trang home

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
               );
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
               );

                // endpoints.MapControllerRoute(
                //     name: "areaRoute",
                //     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                //);
            });
                RotativaConfiguration.Setup((Microsoft.AspNetCore.Hosting.IHostingEnvironment)env);
        }
    }
}
