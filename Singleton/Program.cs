// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Singleton");

SingletonClass jogador_1 = SingletonClass.GetInstancia;
jogador_1.Mensagem("Jogador_1 está com a bola");

SingletonClass jogador_2 = SingletonClass.GetInstancia;
jogador_2.Mensagem("Jogador_2 recebeu a bola.");

SingletonClass jogador_3 = SingletonClass.GetInstancia;
jogador_3.Mensagem("Jogador_3 recebeu o cruzamento.");

Console.ReadKey();


