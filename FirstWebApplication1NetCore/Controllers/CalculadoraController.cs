using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApplication1NetCore.Models;
using FirstWebApplication1NetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FirstWebApplication1NetCore.Controllers
{
  [Route("api/calculajuros")]
  public class CalculadoraController : Controller
  {
    private CalculadoraServices Service;
    private IConfiguration Config;

    public CalculadoraController(IConfiguration config)
    {
      Service = new CalculadoraServices();
      Config = config;
    }

    [HttpGet]
    public IActionResult Get([FromQuery]CalculadoraModel parameters)
    {
      var result = Service.Calcula(parameters.valorinicial, parameters.meses);
      return Ok(result);
    }
  }
}
