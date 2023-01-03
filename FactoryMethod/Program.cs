using FactoryMethod.Classes;
using FactoryMethod.Interfaces;

Console.WriteLine("Factory Method");

Factory fm = new Factory();

Console.WriteLine("Liu Kang | SubZero| Scorpion");
Console.WriteLine();

Console.WriteLine("Escolha seu Personagem");
string escolha = Console.ReadLine();

IPersonagem personagem = fm.EscolherPersonagem(escolha);

Console.WriteLine();
Console.Write("Seu personagem é: ");
personagem.Escolhido();

Console.ReadKey();



