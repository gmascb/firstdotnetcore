using FirstWebApplication1NetCore.Services;
using System;
using Xunit;

namespace FirstWebApplicationUnitTests
{
  public class CalculadoraServiceTest
  {
    private CalculadoraServices service = new CalculadoraServices();
    private decimal valorinicial;
    private double meses;

    [Fact]
    public void CalculadoraServiceTest_Calcula_100V_5M_Retorna1051()
    {
      //arrange
      valorinicial = 100;
      meses = 5;
      //act
      var result = service.Calcula(valorinicial, meses);
      //assert
      Assert.True(result == 105.1M);
    }

    [Fact]
    public void CalculadoraServiceTest_Calcula_120V_3M_Retorna12363()
    {
      //arrange
      valorinicial = 120;
      meses = 3;
      //act
      var result = service.Calcula(valorinicial, meses);
      //assert
      Assert.True(result == 123.63M);
    }

    [Fact]
    public void CalculadoraServiceTest_Calcula_0V_3M_Retorna0()
    {
      //arrange
      valorinicial = 0;
      meses = 3;
      //act
      var result = service.Calcula(valorinicial, meses);
      //assert
      Assert.True(result == 0);
    }

    [Fact]
    public void CalculadoraServiceTest_Calcula_100V_0M_Retorna100()
    {
      //arrange
      valorinicial = 100;
      meses = 0;
      //act
      var result = service.Calcula(valorinicial, meses);
      //assert
      Assert.True(result == 100);
    }
  }
}
