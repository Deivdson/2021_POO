using System;

class Program{
  public static void Main(string[]args){

  }
}

class Premio{
  private string cliente;
  private DateTime data;
  private object premio;

  public Premio(string c, DateTime d){
    cliente = c;
    data = d;
  }
  public void setPremio(object p){
    premio = p;
  }
  public object getPremio(){
    return premio;
  }
  public override string ToString(){
    return $"Cliente: {cliente}\nPremio: {premio}\nData: {data}";
  }
}

class ValeCompras{
  private DateTime dataValidade;
  private decimal valor;

  public ValeCompras(DateTime d, decimal v){
    dataValidade = d;
    valor = v;
  }
  public override string ToString(){
    return $"Data de validade: {d}\nValor: {v}";
  }
}

class Produto{
  private string descricao;
  private decimal valor;

  public Produto(string d, decimal v){
    descricao = d;
    valor = v;
  }
  public override string ToString(){
    return $"Descrição: {descricao}\nValor: {valor}";
  }
}