using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    public class Scorpion : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Scorpion");
        }
    }
}
