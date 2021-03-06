﻿using MedicalSolution.Data;
using MedicalSolution.Data.Context;
using MedicalSolution.Infraestructure;
using MedicalSolution.Infraestructure.Data;
using MedicalSolution.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalSolution.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            AddDependencies(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            //For install database if not exist
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<MedicalSolutionContext>();
                context.Database.Migrate();
            }
        }

        /// <summary>
        /// This method added a dependencies using in the framework.
        /// </summary>
        /// <param name="services"></param>
        private void AddDependencies(IServiceCollection services)
        {
            //Add contextDb
            services.AddDbContext<MedicalSolutionContext>(item => item.UseSqlServer(Configuration.GetConnectionString("MedicalDb")));

            //Add repositories
            services.AddTransient<IGenericRepository<Doctor>, GenericRepository<Doctor>>();
            services.AddTransient<IGenericRepository<Paciente>, GenericRepository<Paciente>>();
            services.AddTransient<IGenericRepository<Especialidad>, GenericRepository<Especialidad>>();
            services.AddTransient<IGenericRepository<Hospital>, GenericRepository<Hospital>>();

            //Add utils
            services.AddScoped<IValidationDictionary, CustomValidationDictionary>();

            //Add services
            services.AddScoped<IDoctorService, DoctorService>();
            services.AddScoped<IPacienteService, PacienteService>();
        }
    }
}
