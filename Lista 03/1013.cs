using System;

class Program{
  public static void Main (string[] args){
    int a,b,c;
    string x = Console.ReadLine();
    String[] subs = x.Split(null, 3);

    a=int.Parse(subs[0]);
    b=int.Parse(subs[1]);
    c=int.Parse(subs[2]);

    int maior = (a+b+Math.Abs(a-b))/2;
    Console.WriteLine($"{(maior+c+Math.Abs(maior-c))/2} eh o maior");
  }
}