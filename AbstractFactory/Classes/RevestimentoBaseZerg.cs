using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha.");
        }
    }
}
