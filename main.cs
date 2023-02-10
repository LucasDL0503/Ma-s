using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    int macas ;
    Double compra;
    String entrada;
    Console.WriteLine("Digite o número de maçãs compradas:");
    entrada = Console.ReadLine();
    macas = Int16.Parse(entrada);
    if(macas <= 12)
    {
    compra = macas*1.30; 
    Console.WriteLine("O custo total é:" + compra);
      }
    else{
    { 
    if(macas >= 12)
      {
    compra = macas *1;
    Console.WriteLine("O custo total é:" + compra);
      } 
    }
    }
  }
  }

    
    
  
