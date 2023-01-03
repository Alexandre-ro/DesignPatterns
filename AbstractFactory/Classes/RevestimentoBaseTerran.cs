using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor verde.");
        }
    }
}
