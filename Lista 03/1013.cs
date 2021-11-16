using System;

class Program{
  public static void Main (string[] args){
    int a,b,c;
    String x = Console.ReadLine();
    String[] subs = x.Split(null, 3);

    a=int.Parse(Console.WriteLine(subs[0]));
    b=int.Parse(Console.WriteLine(subs[1]));
    c=int.Parse(Console.WriteLine(subs[2]));

    int maior = int.Parse((a+b+Math.Abs(a-b))/2);
    Console.WriteLine((maior+c+Math.Abs(maior-c))/2);
  }
}