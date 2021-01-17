using System;

class MainClass {
  public static void Main(string[] args) {
    double bAse;
    double altura;
    double area;
    Console.WriteLine("Insira a base do triângulo");
    bAse = double.Parse(Console.ReadLine());
    Console.WriteLine("Insira a altura do triângulo");
    altura = double.Parse(Console.ReadLine());
    
    area = (altura*bAse)/2;
    Console.WriteLine(area);
  }
}