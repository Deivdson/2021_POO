using System;
using System.Collections;

class Program{
  public static void Main(string[]args){
    Aluno a = new Aluno("Carlos", "2012392",DateTime.Parse("01/01/2005"));
    Aluno b = new Aluno("Angela", "1243421", DateTime.Parse("02/05/2003"));
    Aluno c = new Aluno("Fernanda", "1423412", DateTime.Parse("04/02/2004"));

    Aluno[] v = {a,b,c};
    Console.WriteLine("Sort por nome:");
    Array.Sort(v);
    foreach(Aluno i in v) Console.WriteLine(i);

    Console.WriteLine("Sort por matrícula:");
    Array.Sort(v, new AlunoMatriculaComp());
    foreach(Aluno i in v) Console.WriteLine(i);

    Console.WriteLine("Sort por nascimento:");
    Array.Sort(v, new AlunoNascimentoComp());
    foreach(Aluno i in v) Console.WriteLine(i);
  }
}

class Aluno : IComparable<Aluno>{
  public string Nome{get;set;}
  public string Matricula{get;set;}
  public DateTime Nascimento{get;set;}

  public Aluno(string n, string m, DateTime nasc){
    this.Nome = n;
    this.Matricula = m;
    this.Nascimento = nasc;
  }
  public int CompareTo(Aluno obj){
    return this.Nome.CompareTo(obj.Nome);
  }
  public override string ToString(){
    return $"Nome: {Nome}\nMatrícula: {Matricula}\nData de nascimento: {Nascimento}\n";
  }
}
class AlunoMatriculaComp : IComparer {
    public int Compare(object x, object y){
      Aluno a = (Aluno) x;
      Aluno b = (Aluno) y;
      return a.Matricula.CompareTo(b.Matricula);
    }
}

class AlunoNascimentoComp : IComparer {
    public int Compare(object x, object y){
      Aluno a = (Aluno) x;
      Aluno b = (Aluno) y;
      return a.Nascimento.CompareTo(b.Nascimento);
  }
}