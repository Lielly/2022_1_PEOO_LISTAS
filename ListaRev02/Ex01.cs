using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite dois valores inteiros");
     string s = Console.ReadLine(); 
     int a = int.Parse(s);
     int b = int.Parse(Console.ReadLine());
    if (a > b) Console.WriteLine($"Maior = {a}");
    if (b > a) Console.WriteLine($"Maior = {b}");
    if (a == b) Console.WriteLine("Números iguais");
  }
}