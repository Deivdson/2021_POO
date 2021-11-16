using System;

class Program {
  public static void Main (string[] args) {
    double salario,vendas;
    String nome = Console.ReadLine();
    salario = double.Parse(Console.ReadLine());
    vendas = double.Parse(Console.ReadLine());
    Console.WriteLine($"TOTAL = R$ {vendas*0.15+salario:0.00}");
  }
}