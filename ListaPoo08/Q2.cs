using System;
using System.Collections;

class Program{
  public static void Main(string[]args){
    Pais a = new Pais( "Ucrânia", 3, 4, 5);
    Pais b = new Pais("Brasil", 3, 5, 4);
    Pais c = new Pais("Japão", 2, 8, 5);

    QuadroMedalhas x = new QuadroMedalhas();
    x.Inserir(a);
    x.Inserir(b);
    x.Inserir(c);
    Pais[] list = x.Listar();
    Array.Sort(list, new PaisesComp());
    foreach(Pais y in list)Console.WriteLine(y);
  }
}

class Pais : IComparable<Pais>{
  private string nome;
  private int ouro;
  private int prata;
  private int bronze;

  public string Nome{get=>nome;}
  public int Ouro{get=>ouro;}
  public int Prata{get=>prata;}
  public int Bronze{get=>bronze;}
  
  public Pais(string nome, int ouro, int prata, int bronze){
    this.nome = nome;
    this.ouro = ouro;
    this.prata = prata;
    this.bronze = bronze;
  }

  public int CompareTo(Pais obj){
    return nome.CompareTo(obj.Nome);
  }

  public override string ToString(){
    return $"Nome do País: {nome}\nMedalhas de Ouro: {ouro}\nMedalhas de Prata: {prata}\nMedalhas de Bronze: {bronze}";
  }
}
class QuadroMedalhas{
  private Pais[] paises = new Pais[10];
  private int k;

  public void Inserir(Pais p){
    if(k==paises.Length)Array.Resize(ref paises,paises.Length*2);
    paises[k]=p;
    k++;
  }
  public Pais[] Listar(){
    return paises;
  }
}

class PaisesComp : IComparer{
  public int Compare(object x, object y){
    Pais a = (Pais) x;
    Pais b = (Pais) y;
    if(a.Ouro>b.Ouro || b.Ouro>a.Ouro) return a.Ouro.CompareTo(b.Ouro);
    //if(a.Prata!=b.Prata) return a.Prata.CompareTo(b.Prata);
    //if(a.Bronze!=b.Bronze) return a.Bronze.CompareTo(b.Bronze);
    return a.CompareTo(b);
  }
}