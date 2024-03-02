using System;

class Program 
{


    static void Main()
    {

      Console.WriteLine("Olá, seja bem vindo");

      Console.WriteLine("Digite o tempo de viagem:");

      float tempo = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite a velocidade média de trajeto:");

      float velocidade = float.Parse(Console.ReadLine());
      
  

      double consumo = (tempo * velocidade ) / 12;


      Console.WriteLine("O consumo de combustível é de: " + consumo.ToString("F") + "litros");
     }

}
