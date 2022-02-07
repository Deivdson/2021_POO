using System;


class Program{
  public static void Main(string[]args){
    Colecoes<Colecoes<Aplicativo>> x = new Colecoes<Colecoes<Aplicativo>>();
  }
}
class Aplicativo{
  public string Nome{get;set;}
}


class Colecoes<T>{
  private T[] apps = new T[50];
  private int k;
  public void Inserir(T app){
    if (k<50) apps[k++] = app;
  }
  public T[] Listar(){
    T[] r = new T[k];
    Array.Copy(apps,r,k);
    return r;
  }
}