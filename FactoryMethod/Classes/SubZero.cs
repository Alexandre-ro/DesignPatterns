using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Sub Zero");
        }
    }
}
