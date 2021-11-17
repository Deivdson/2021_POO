using System;

class Program {
  public static void Main(string[] args){
    double a,b,c;

    string x = Console.ReadLine();
    String[] subs = x.Split(null,4) ;

    a = double.Parse(subs[0]);
    b = double.Parse(subs[1]);
    c = double.Parse(subs[2]);

    Console.WriteLine($"TRIANGULO: {a*c/2:0.000}");
    Console.WriteLine($"CIRCULO: {3.14159*Math.Pow(c,2):0.000}");
    Console.WriteLine($"TRAPEZIO: {(a+b)*c/2:0.000}");
    Console.WriteLine($"QUADRADO: {b*b:0.000}");
    Console.WriteLine($"RETANGULO: {a*b:0.000}");
  }
}