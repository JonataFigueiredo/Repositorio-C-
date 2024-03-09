using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("Série Fibonacci");
    Console.WriteLine("Limite de até 46 números, digite a quantidade para gerar o teste: ");
    int a = int.Parse(Console.ReadLine());
    while(a > 46 || a <0)
    {
      Console.WriteLine("Número inválido, digite número inteiro menor que 46: ");
      a = int.Parse(Console.ReadLine());
      Console.WriteLine(" ");
    }
    int num1=0;
    int num2=1;
    int i;
    int num3=0;
    while(num3<1)
    {
      Console.Write(num3 + " " );
      num3= num3 +1;
      }
    for(i=0; i <= a -1; i++)
    {
      Console.Write(num3 + " " );
      num3 = num1 +num2;
      num1 = num2;
      num2= num3;
      }
    Console.WriteLine(" ");
    Console.WriteLine("Teste finalizado, obrigado");
    }
}
