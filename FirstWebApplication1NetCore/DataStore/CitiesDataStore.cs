using FirstWebApplication1NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication1NetCore.DataStore
{
  public class CitiesDataStore
  {
    public static CitiesDataStore Current { get; } = new CitiesDataStore();
    public List<CitiesDTO> Cities { get; set; }

    public CitiesDataStore()
    {
      Cities = new List<CitiesDTO>()
      {
        new CitiesDTO()
        {
          Id = 1, Name = "Antwerp", Description = "A", NumberOfPointsOfInterest = 0
        },
        new CitiesDTO()
        {
          Id = 2, Name = "Antwerp", Description = "B", NumberOfPointsOfInterest = 1
        },
        new CitiesDTO()
        {
          Id = 3, Name = "Antwerp", Description = "C", NumberOfPointsOfInterest = 2
        }
      };

    }
  }
}
