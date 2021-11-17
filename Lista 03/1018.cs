using System;

class Program {
  public static void Main(string[] args){
    int n,cem,cinquenta,vinte,dez,cinco,dois,um;
    n = int.Parse(Console.ReadLine());
    Console.WriteLine(n);
    cem = n/100;
    n = n-cem*100;
    cinquenta = n/50;
    n = n-cinquenta*50;
    vinte = n/20;
    n = n-vinte*20;
    dez = n/10;
    n = n-dez*10;
    cinco = n/5;
    n = n-cinco*5;
    dois = n/2;
    n = n-dois*2;
    um = n/1;
    n=n-um*1;

    Console.WriteLine($"{cem} nota(s) de R$ 100,00");
    Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
    Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
    Console.WriteLine($"{dez} nota(s) de R$ 10,00");
    Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
    Console.WriteLine($"{dois} nota(s) de R$ 2,00");
    Console.WriteLine($"{um} nota(s) de R$ 1,00");
    }
}