using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dismantle.BusinessLogic.Extractors;
using Dismantle.Core.Interfaces.Extractors;
using Dismantle.Core.Interfaces.Repositories;
using Dismantle.Infrastructure.Data;
using Dismantle.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dismantel.Web
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<OldFilmContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("OldFilmConnection")));
            services.AddDbContext<NewFilmContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("NewFilmConnection")));
            services.AddDbContext<FilmPersonContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("FilmPersonConnection")));
            services.AddDbContext<MediumContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MediumConnection")));
            services.AddDbContext<PersonContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("PersonConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IRepositoryFactory, RepositoryFactory>();
            services.AddTransient<IExtractorFactory, ExtractorFactory>();

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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}
