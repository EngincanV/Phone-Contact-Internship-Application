using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nuevo.Business.Abstract;
using Nuevo.Business.Concrete;
using Nuevo.DataAccess.Abstract;
using Nuevo.DataAccess.Concrete;
using Winton.AspNetCore.Seo;
using Winton.AspNetCore.Seo.Robots;
using Winton.AspNetCore.Seo.Sitemaps;

namespace Nuevo.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<PhoneContactContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PhoneContactContext")));

            //add authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            //my services
            services.AddScoped<IUserDal, UserDal>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IRoleDal, RoleDal>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IPersonalDal, PersonalDal>();
            services.AddScoped<IPersonalService, PersonalManager>();
            services.AddScoped<IDepartmantService, DepartmantManager>();
            services.AddScoped<IDepartmantDal, DepartmantDal>();
            services.AddScoped<IManagerDal, ManagerDal>();
            services.AddScoped<IManagerService, ManagerManager>();

            //SEO
            services.AddSeoWithDefaultRobots(
                options =>
                {
                    options.Urls = new List<SitemapUrlOptions>
                    {
                        new SitemapUrlOptions
                        {
                            Priority = 1.0m,
                            RelativeUrl = ""
                        },
                        new SitemapUrlOptions
                        {
                            Priority = 1.0m,
                            RelativeUrl = "/Manager/add-personal"
                        },
                        new SitemapUrlOptions
                        {
                            Priority = 1.0m,
                            RelativeUrl = "/Departmans"
                        },
                        new SitemapUrlOptions
                        {
                            Priority = 1.0m,
                            RelativeUrl = "/Account/Login"
                        },
                        new SitemapUrlOptions
                        {
                            Priority = 1.0m,
                            RelativeUrl = "/Account/Logout"
                        }
                    };
                });

            services.AddSeo(options =>
            {
                options.RobotsTxt.AddSitemapUrl = true;
                options.RobotsTxt.UserAgentRecords = new List<UserAgentRecord>
                {
                    new UserAgentRecord
                    {
                        UserAgent = "*"
                    }
                };
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //use authenticaiton
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}