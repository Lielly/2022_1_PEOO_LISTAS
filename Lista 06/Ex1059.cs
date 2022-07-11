using System; 

public class Program {

  public static void Main(string[] args) {
  int x = 1;
    while (x <= 100) {
      if (x % 2 == 0) {
       Console.WriteLine(x); 
      }
      x++;
    }
  }
}