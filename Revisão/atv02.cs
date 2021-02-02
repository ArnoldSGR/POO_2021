using System;

class MainClass {
  public static void Main(string[] args) {
    double gastoComCombustivel,valorPorLitro,DistanciaPercorrida,litrosDeGasolina,consumoMedio,gastoPorKm;

    Console.WriteLine("Digite o valor gasto com o combustível em reais:");

   gastoComCombustivel = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do litro do combustível em reais:");

   valorPorLitro = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a distância percorrida em quilômetros");

   DistanciaPercorrida = double.Parse(Console.ReadLine());

   gastoPorKm = (gastoComCombustivel / DistanciaPercorrida)/10;

   litrosDeGasolina = gastoComCombustivel / valorPorLitro;

   consumoMedio = (DistanciaPercorrida / litrosDeGasolina)/10;

    Console.WriteLine($"{consumoMedio}");
    Console.WriteLine($"O gasto por Km percorrido é R${gastoPorKm}");
  }
}