﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using embarkfin.api.Models.Database;
using Microsoft.EntityFrameworkCore;
using embarkfin.api.Repositories;
using embarkfin.api.Application;

namespace embarkfin.api
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
            services.AddCors(o => o.AddPolicy("CorsPolicy", cp => cp.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().AllowCredentials()));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=Embarkfin; Integrated Security=True;"));
            services.AddScoped<DatabaseContext>();
            services.AddScoped<AssetRepository>();
            services.AddScoped<EmbarkfinService>();
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
                app.UseHsts();
            }

            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
