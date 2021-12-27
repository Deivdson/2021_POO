using System;
class Program{
  public static void Main(string[]args){
    Retangulo r = new Retangulo();
    r.Base=2;
    r.Altura=2;
    Console.WriteLine(r.Diagonal);
  }
}

class Retangulo{
  private double b,h;
  public Retangulo(){}
  public Retangulo(double b, double h){
    if(b>0)this.b=b;
    if(h>0)this.h=h;
  }

  public double Base{
    get {return b;}
    set {if(value>0)b=value;}
  }
  public double Altura{
    get {return h;}
    set {if(value>0)h=value;}
  }
  public double Area{
    get {return b*h;}
  }
  public double Diagonal{
    get {return (Math.Sqrt(b*b+h*h));}
  }
}