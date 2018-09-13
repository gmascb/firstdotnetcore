using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication1NetCore.Controllers
{
  [Route("api/showmethecode")]
  public class MostraOFonteController : Controller
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("https://github.com/gmascb/firstdotnetcore");
    }
  }
}
