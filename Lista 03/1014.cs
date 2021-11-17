using System;

class Program {
  public static void Main(string[] args){
    int x;
    double y;
    x=int.Parse(Console.ReadLine());
    y=double.Parse(Console.ReadLine());
    Console.WriteLine($"{x/y:0.000} km/l");
  }  
}
