using System;

class MainClass {
  public static void Main(string[] args) {
    string linha;
    string[] data;
    int op1,op2,soma;
    Console.WriteLine("Digite a operação no formato op1+op2");

    linha = Console.ReadLine();

    data = linha.Split('+');

    op1 = int.Parse(data[0]);

    op2 = int.Parse(data[1]);

    soma = op1 + op2;

    Console.WriteLine("");
    
    Console.WriteLine($"Soma = {soma}");
  }
}