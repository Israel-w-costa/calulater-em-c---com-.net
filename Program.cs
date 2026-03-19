using System;
class Calculadora
{
  static void Main(String[] args)
  { 
    
   while(true) {
    Console.Clear();

    int num1, num2, solucao;

    Console.Write("=======  Bem vindo a Calculadora  ======= \n ");
    Console.Write("\nDigite um numero para calculo\n");
    if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Entrada inválida!");
                continue;
            }
    
    Console.Write("\nDigite um outro numero\n");
    if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Entrada inválida!");
                continue;
            }

    Console.Write(" Escolha um operador para realizar uma operação");
    Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("(+) Adição");
            Console.WriteLine("(-) Subtração");
            Console.WriteLine("(X) Multiplicação");
            Console.WriteLine("(/) Divisão");
            Console.WriteLine("(0) Sair\n");
    
    
    char operacao = char.ToUpper( Console.ReadKey().KeyChar);    if (operacao == '0')
      {
        break;
      }
      

    switch (operacao)
    {
      case '+':
      solucao = Somar(num1,num2);
          Console.WriteLine("\n Adição é " + solucao + "\n");
          break;
      case'-':
      solucao = Subtrair(num1,num2);
          Console.WriteLine("\n Subtração é " + solucao + "\n");
          break;    
      case 'X':
      solucao = Multiplicacao(num1,num2);
          Console.WriteLine("\n Multiplicação é " + solucao + "\n");
          break;    
       case '/':
    if (num2 == 0)
    {
        Console.WriteLine("\nNão é possível dividir por zero\n");
    }
    else
    {
        Console.WriteLine("\n Divisão é " + Divisao(num1, num2) + "\n");
    }
    break;  
      default:
        Console.Write("opção inválida");    
        break;
    }
}
  }

  static int Somar(int num1, int num2)
  {
    return num1 + num2;
  }
  static int Subtrair (int num1, int num2)
  {
    return num1 - num2;
  }

  static int Multiplicacao(int num1 , int num2)
  {
    return num1 * num2;
  }

  static int Divisao (int num1, int num2)
  {
   
    return num1 / num2;
    }


}