using System;

class MinhaClass {
  public static void Main (string[] args){

    int a,b,c;

    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());

    if( a < b+c && Math.Abs(b-c) < a)
      Console.WriteLine("Os valores formam um triangulo");
    else
      Console.WriteLine("Os valores não formam um triangulo");
  }
}