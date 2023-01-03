using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class FabricaProtoss : IFabricaBase
    {
        public FabricaProtoss()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso!");

            RevestimentoBaseProtoss rv = new RevestimentoBaseProtoss();
            rv.Composicao();

            EnergiaBaseProtoss en = new EnergiaBaseProtoss();
            en.Composição();
        }
    }
}
