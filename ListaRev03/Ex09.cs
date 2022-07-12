using System;
class Program{
  public static void Main(){
    Console.WriteLine("Digite uma frase:");
    string palavra = Console.ReadLine();
    int q = 0;
    foreach (char p in palavra) {
      q = q + 1;
      Console.WriteLine($"{q} - {palavra}");
    }
    }
  }