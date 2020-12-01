﻿using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.Application.Catalog.Categories;
using WebMyPham.Application.Catalog.Products;
using WebMyPham.Application.Common;
using WebMyPham.Application.System.Roles;
using WebMyPham.Application.System.Users;
using WebMyPham.Data.EF;
using WebMyPham.Data.Entities;
using WebMyPham.Utilities.Constants;
using WebMyPham.ViewModels.System.Users;

namespace WebMyPham.BackendApi
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
            services.AddDbContext<WebMyPhamDbContext>(options => //sd trực tiêp connect với sql 
                options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));

            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<WebMyPhamDbContext>()
                .AddDefaultTokenProviders();
            //Declare DI : khai báo Ipublicproduct khởi tạo ra gì
            services.AddTransient<IStorageService, FileStorageService>();
            //services.AddTransient<IPublicProductService, PublicProductService>(); //khởi tạo ra public chỉ ra đối tượng để transien  
            services.AddTransient<IProductService, ProductService>();                                                        //services.AddTransient<IStorageService, FileStorageService>(); //transien mỗi lần requesst object thì sẽ tạo mới
            services.AddTransient<ICategoryService, CategoryService>();                                                        //services.AddTransient<IStorageService, FileStorageService>(); //transien mỗi lần requesst object thì sẽ tạo mới

            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();

            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IValidator<LoginRequest>, LoginRequestValidator>();
            services.AddTransient<IValidator<RegisterRequest>, RegisterRequestValidator>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>());


            services.AddControllersWithViews();
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
            app.UseAuthentication();
            app.UseRouting();

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
