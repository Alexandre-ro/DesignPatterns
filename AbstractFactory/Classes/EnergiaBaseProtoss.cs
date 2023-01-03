using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composição()
        {
            Console.WriteLine("Energia de sustentação da base de cristais.");
        }
    }
}
