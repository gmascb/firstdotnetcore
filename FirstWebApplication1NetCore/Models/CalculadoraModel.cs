using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApplication1NetCore.Models
{
  public class CalculadoraModel
  {
    [Required]
    public decimal valorinicial { get; set; }

    [Required]
    public double meses { get; set; }

    //[Required]
    [MaxLength(200)]
    public string descricao { get; set; }

  }
}
