using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace FirstWebApplication1NetCore
{
  public class Startup
  {
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().AddJsonOptions(options => {

        if(options!=null)
        {
          //opção de não fazer cast nos nomes de objetos da classe.
          //desta forma o Json Result será apresentado do jeito que foi nomeado na classe
          var castedResolver = options.SerializerSettings.ContractResolver 
          as DefaultContractResolver;

          castedResolver.NamingStrategy = null;
        }

      });

      //adiciona o retorno como XML ao invés do JSON
      services.AddMvc().AddMvcOptions(options => options.OutputFormatters.Add(
        new XmlDataContractSerializerOutputFormatter()));

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseStatusCodePages();

      app.UseMvc();

      //app.Run(async (context) =>
      //{
      //  await context.Response.WriteAsync("Hello World!");
      //});
    }
  }
}
