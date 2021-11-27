using System;

class Program{
  public static void Main(string[] args){
    int a,b,c,d;
    string x = Console.ReadLine();
    String[] list = x.Split(null, 4);

    a=int.Parse(list[0]);
    b=int.Parse(list[1]);
    c=int.Parse(list[2]);
    d=int.Parse(list[3]);

    if( b>c && d>a && c+d>a+b && c>0 && d>0 && a%2==0) Console.WriteLine("Valores aceitos");
    else Console.WriteLine("Valores nao aceitos");
  }
}