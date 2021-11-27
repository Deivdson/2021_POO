using System;

class Program {
  public static void Main(string[] args){
    double x = AreaTriangulo( 10, 20);
    double y = AreaTriangulo( 5, 8);

    public static double AreaTriangulo( double b, double h){
      double area = b * h/2;
      return area;
    }
  }
}