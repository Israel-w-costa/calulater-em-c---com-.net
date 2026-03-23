using System;
using System.Net.Mime;
class Program
{
  static void Main(String[] args)
  { 
    
 var operacoes = new Dictionary<char, IOperacao>
    {
      {'+', new Somar()},
      {'-', new Subtrair()},
      {'X', new Multiplicacao()},
      {'/', new Dividir()},
    };

   while(true) {
    Console.Clear();

    int num1, num2;

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
    
    
    char operacao = char.ToUpper( Console.ReadKey().KeyChar);    
    if (operacao == '0')
      {
        break;
      }
      

    if (operacoes.TryGetValue(operacao, out var op))
    Console.WriteLine(op.Executar(num1,num2));

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}
  }

}