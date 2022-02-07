using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program{
  public static void Main(string[]args){
    Pilha<int> l = new Pilha<int>();
    l.Push(18);
    l.Push(13);
    l.Push(14);
    Console.WriteLine(l.Count);
    for(int i=l.Count; i!=0;i--){
      Console.WriteLine(l.Pop());
    }

    
  }
}

class Pilha<T>{
  private T[] obj = new T[10];
  private int k;
  public int Count{get=>k;}

  public void Clear(){
   Array.Clear(obj,0,k-1);
  }
  public T Peek(){
    return obj[k-1];

  }
  public T Pop(){
    k--;
    return obj[k];
  }
  public void Push(T x){
    if(k==obj.Length)Array.Resize(ref obj, obj.Length*2 );
    obj[k]=x;
    k++;
  }

  
}