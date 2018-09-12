using FirstWebApplication1NetCore.DataStore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication1NetCore.Controllers
{
  //[Route("api/[controller]")]
  [Route("api/cities")]
  public class CitiesController : Controller
  {

    // [HttpGet("api/cities")]
    public JsonResult GetCities()
    {
      return new JsonResult(CitiesDataStore.Current.Cities);
    }
    [HttpGet("{id}")]
    public JsonResult GetCity(int id)
    {
      return new JsonResult(
        CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id));
    }
  }
}