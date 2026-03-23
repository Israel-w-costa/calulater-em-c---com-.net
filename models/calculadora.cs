using System;
using System.Security.Cryptography.X509Certificates;


  public class Somar:IOperacao {
   public char Simbolo => '+';
    public double Executar(double a, double b) => a + b;

  }

  public class Subtrair : IOperacao
{
  public char Simbolo => '-';
  public double Executar(double a, double b) => a-b;
}

  public class Multiplicacao:IOperacao {
  public char Simbolo => 'x';
  public double Executar(double a, double b) => a * b;
}

public class Dividir:IOperacao
{
  public char Simbolo => '/';
  public double Executar(double a, double b)
  {
     if (b == 0) throw new DivideByZeroException("Não é possível dividir por zero.");
        return a / b;
  }
}
