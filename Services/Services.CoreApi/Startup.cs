namespace devdeer.IgSample.Services.CoreApi
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using Logic.Core;
    using Logic.DataAccess;
    using Logic.DataAccess.TestRepositories;
    using Logic.Shared.Interfaces;
    using Logic.Shared.Models;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

    public class Startup
    {
        #region constructors and destructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        #region methods

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "IG API V1");
                });
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(
                endpoints =>
                {
                    endpoints.MapControllers();
                });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(
                c =>
                {
                    c.SwaggerDoc(
                        "v1",
                        new OpenApiInfo
                        {
                            Title = "IG A  PI",
                            Version = "v1",
                            Description = "ASP.NET Core API Demo"
                        });
                    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                    c.IncludeXmlComments(xmlPath);
                });
            // configure DI
            if (bool.Parse(Configuration["App:UseTestData"]))
            {
                services.AddTransient<IRepository<ArticleEntity>, TestArticleRepository>();
            }
            else
            {
                services.AddTransient<IRepository<ArticleEntity>, ArticleRepository>();
                services.AddTransient<IRepository<EmployeeEntity>, EmployeeRepository>();
            }
            services.AddTransient<ILogic<ArticleEntity>, ArticleLogic>();
            services.AddTransient<ILogic<EmployeeEntity>, EmployeeLogic>();

            services.AddControllers();
        }

        #endregion

        #region properties

        public IConfiguration Configuration { get; }

        #endregion
    }
}