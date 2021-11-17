using System;

class Program {
  public static void Main (string[] args){
    int l,d,k,p;
    
    string ld = Console.ReadLine();
    string kp = Console.ReadLine();

    String[] l1 = ld.Split(null,2);
    String[] l2 = kp.Split(null,2);

    l = int.Parse(l1[0]);
    d = int.Parse(l1[1]);
    k = int.Parse(l2[0]);
    p = int.Parse(l2[1]);

    Console.WriteLine(l/d*p+k*l);
  }
}