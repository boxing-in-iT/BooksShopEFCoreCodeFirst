using BooksShop.BLL.Interfaces;
using BooksShop.BLL.Services;
using BooksShop.BLL.ServiceWrapper;
using BooksShop.DAL;
using BooksShop.DAL.Entities;
using BooksShop.DAL.Repositories;
using BooksShop.DAL.Repositories.Abstract;
using BooksShop.DAL.Repositories.Entity_Framework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BooksShop.WebAPI
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
            //services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<AppDbContext>(options =>
            {
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            });

            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireUppercase = true;
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = false;
            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddControllers();
            //Enable CORS
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BooksShop.WebAPI", Version = "v1" });
            });

            #region Repo
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Services
            services.AddTransient<IServiceWrapper, ServiceWrapper>();
            #endregion

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDistributedMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BooksShop.WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "Photos")),
                RequestPath = "/Photos"
            });

        }
    }
}
