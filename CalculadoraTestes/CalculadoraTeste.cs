using System;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private OperacoesBasicas _calc;

    public CalculadoraTestes()
    {
        _calc = new OperacoesBasicas();
    }

    [Fact]
    public void DeveSomar5com5ERetornar10()
    {
        //Arrange 

        int num1 = 5;
        int num2 = 5;

        //Act

        int resultado = _calc.Somar(num1, num2);

        //Assert

        Assert.Equal(10, resultado);
    }

    [Fact]
    public void DeveSubtrair10com5ERetornar5()
    {
        //Arrange

        int num1 = 10;
        int num2 = 5;

        //Act

        var resultado = _calc.Subtrair(num1. num2);

        //Aseert

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveMultiplicar5com5ERetornar25()
    {
        //Arrange

        int num1 = 5;
        int num2 = 5;

        //Act

        var resultado = _calc.Multiplicar(num1, num2);

        //Assert

        Assert.Equal(25, resultado);
    }

    [Fact]
    public void DeveDividir10por2ERetornar5()
    {
        //Arrange

        int num1 = 10;
        int num2 = 2;

        //Act

        var resultado = _calc.Dividir(num1, num2);

        //Assert

        Assert.Equal(5, resultado);
    }
}