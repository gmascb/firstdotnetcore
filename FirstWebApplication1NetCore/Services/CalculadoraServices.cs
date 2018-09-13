using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication1NetCore.Services
{
  public class CalculadoraServices
  {
    public decimal Calcula(decimal valorinicial, double meses)
    {
      double resultCalc = (double)valorinicial * Math.Pow(1.01, meses);

      return (decimal)Math.Truncate(100 * resultCalc) / 100;
    }
  }
}
