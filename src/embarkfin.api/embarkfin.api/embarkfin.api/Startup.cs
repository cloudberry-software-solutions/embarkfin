using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            //Amend connectionString according to your local machine
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Server=localhost; Database=Embarkfin; User Id = sa; Password= P@ssword1"));
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
