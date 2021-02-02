using System;

class MainClass {
  public static void Main(string[] args) {
    string estado;
    long habitantes;
    float densidadeDemografica,area;

    Console.WriteLine("Digite o nome do estado: ");
    estado = Console.ReadLine();
    Console.WriteLine("Digite o número de habitantes: ");
    habitantes = long.Parse(Console.ReadLine());
    Console.WriteLine("Digite a area do estado em Km²");
    area = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    densidadeDemografica = habitantes / area;

    Console.WriteLine("A densidade demográfica do {0} é de {1} hab/Km²",estado,densidadeDemografica);
  }
}