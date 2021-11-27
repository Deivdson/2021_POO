using System;

public class Program {
  public static void Main(string[] args){
    Console.WriteLine("Digite um número inteiro");
    int x = int.Parse(Console.ReadLine());

    if(x % 2 == 0 ) Console.WriteLine("Par");
    else Console.WriteLine("Ímpar");

    Console.WriteLine(x % 2 == 0 ? "Par" : "Ímpar");
}