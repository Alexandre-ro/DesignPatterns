using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela.");
        }
    }
}
