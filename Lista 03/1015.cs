using System;

class Program {
  public static void Main(string[] args){
    double x1,x2,y1,y2,cal;
    string p1 = Console.ReadLine();
    string p2 = Console.ReadLine();

    String[] sub1 = p1.Split(null,2);
    String[] sub2 = p2.Split(null,2);

    x1 = double.Parse(sub1[0]);
    y1 = double.Parse(sub1[1]);
    x2 = double.Parse(sub2[0]);
    y2 = double.Parse(sub2[1]);

    cal = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    Console.WriteLine($"{cal:0.0000}");
  }
}