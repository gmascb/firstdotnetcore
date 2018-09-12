using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication1NetCore.Models
{
  public class CitiesDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public int NumberOfPointsOfInterest { get; set; }
  }
}
