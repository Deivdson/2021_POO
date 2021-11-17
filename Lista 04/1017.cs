using System;

class Program {
  public static void Main(string[] args) {
    double t,Vm;

    t = double.Parse(Console.ReadLine());
    Vm = double.Parse(Console.ReadLine());

    Console.WriteLine($"{Vm/12*t:0.000}");
  }
}