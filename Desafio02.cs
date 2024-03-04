using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Olá, seja bem vindo");
    
    Console.WriteLine (" ");

    Console.WriteLine ("Abaixo temos o menu");
    
    Console.WriteLine (" ");
    
    Console.WriteLine ("|   Código  |    Descrição      |  Preço   |");
    Console.WriteLine ("|      1    |  Cachorro Quente  |  R$4,00  |");
    Console.WriteLine ("|      2    |  X-salada         |  R$4,50  |");
    Console.WriteLine ("|      3    |  X-bacon          |  R$5,00  |");
    Console.WriteLine ("|      4    |  Torrada simples  |  R$2,00  |");
    Console.WriteLine ("|      5    |  Refrigerante     |  R$1,50  |");

    Console.WriteLine (" ");
    
    Console.WriteLine ("Para fazer o pedido, insira o código do produto: ");
    float a = float.Parse(Console.ReadLine());

    
    while(a < 1 || a > 5)
    {
      Console.WriteLine("Código invalido");
      Console.WriteLine(" ");
      Console.WriteLine ("Insira o código do produto entre 1 a 5: ");
    a = float.Parse(Console.ReadLine());
      
    }
    
    Console.WriteLine (" ");
    
    if
    (a < 6 && a >= 1)
      {
        Console.WriteLine ("Digite a quantidade: ");
        float b = float.Parse(Console.ReadLine());
        
        while(b < 1)
        {
          Console.WriteLine("Quantidade inválida");
          Console.WriteLine(" ");
          Console.WriteLine ("Por favor, insira o número maior que 0: ");
        b = float.Parse(Console.ReadLine());

        }

        Console.WriteLine (" ");
        
        if
        (a == 1)
        {
          double custo = (b *4);
          double numeroaredondado = Math.Round(custo, 2);
          Console.WriteLine (" ");
          Console.WriteLine ("Total: R$" + numeroaredondado);
          
          }
        
        else if
        (a == 2)
        {
          double custo = (b *4.5);
          Console.WriteLine (" ");
          Console.WriteLine ("Total: R$" + custo);
          }
        
        else if
        (a == 3)
        {
          double custo = (b *5);
          Console.WriteLine (" ");
          Console.WriteLine ("Total: R$" + custo);
        }
        
        else if
        (a == 4)
        {
          double custo = (b *2);
          Console.WriteLine (" ");
          Console.WriteLine ("Total: R$" + custo);
          }
      
        else if
        (a == 5)
        {
          double custo = (b *1.5);
          Console.WriteLine (" ");
          Console.WriteLine ("Total: R$" + custo);
        }
    
        
        else
        Console.WriteLine ("Erro");
      }

    else
    Console.WriteLine ("Número não registrado");
    Console.WriteLine ("Obrigado pela preferência");
    
  }
}
