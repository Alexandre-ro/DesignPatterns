using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

Console.WriteLine("***************  Abstract Method  ***************  ");

IFabricaBase fabrica;
Console.WriteLine("Escolha um dos Personagens: 1-Protons | 2-Zergs | 3-Terranos");

switch (Console.ReadLine())
{
    case "1":
        fabrica = new FabricaProtoss();
        break;
    case "2":
        fabrica = new FabricaBaseZerg();
        break;
    case "3":
        fabrica = new FabricaBaseTerran();
        break;
}

Console.ReadLine();
