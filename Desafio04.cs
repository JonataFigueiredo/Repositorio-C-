using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine 
    ("Desafio substituição de valores do vetor");

    int[] vetor = new int[10];

    bool resposta = true;

    while(resposta)
    {

    Console.WriteLine ("Digite  valor do primeiro espaço do vetor: ");
      vetor[0] = int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do segundo espaço do vetor: ");
      vetor[1] = int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do terceiro espaço do vetor: ");
    vetor[2] = int.Parse(Console.ReadLine());

    Console.WriteLine("  ");
    
    Console.WriteLine ("Digite  valor do quarto espaço do vetor: ");
    vetor[3] = int.Parse(Console.ReadLine());
    
Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do quinto espaço do vetor: ");
    vetor[4]= int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do sexto espaço do vetor: ");
    vetor[5]= int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do sétimo espaço do vetor: ");
    vetor[6]= int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do oitavo espaço do vetor: ");
    vetor[7]= int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

Console.WriteLine ("Digite  valor do nono espaço do vetor: ");
    vetor[8]= int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    Console.WriteLine ("Digite  valor do décimo espaço do vetor: ");
    vetor[9]= int.Parse(Console.ReadLine());

    Console.WriteLine("  ");

    
    int i;
    for(i=0; i<10; i++)
    {

    if(vetor[i] <=0)
    {
      vetor[i] = 1;
      Console.WriteLine("vetor[" + i + "]" + " = " + vetor[i]);
      
    }
      else
      {
        vetor[i] = vetor[i];
      Console.WriteLine("vetor[" + i + "]" + " = " + vetor[i]);
      }
    }
Console.WriteLine("  ");
      Console.WriteLine(" Gostaria de realizar outra operação ? (1 = Sim / 2 = Não");
      int a = int.Parse(Console.ReadLine());
      if(a == 1)
      {
        resposta = true;
        Console.WriteLine("  ");
      }

      else if(a == 2)
      {
        resposta = false;
        Console.WriteLine("  ");
        Console.WriteLine(" Teste finalizado, Obrigado !");
        
      }

      else 
      {
        Console.WriteLine("  ");
        Console.WriteLine(" Oração inválida, teste finalizado");
      }

      
      
  }
  }
}
