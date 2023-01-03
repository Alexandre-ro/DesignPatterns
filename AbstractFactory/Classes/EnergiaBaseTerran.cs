using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composição()
        {
            Console.WriteLine("Energia de sustentação da base mecânica.");
        }
    }
}
