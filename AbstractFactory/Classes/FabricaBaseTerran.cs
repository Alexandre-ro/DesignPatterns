using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class FabricaBaseTerran : IFabricaBase
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Terran criada com sucesso!");

            RevestimentoBaseTerran rv = new RevestimentoBaseTerran();
            rv.Composicao();

            EnergiaBaseTerran en = new EnergiaBaseTerran();
            en.Composição();
        }
    }
}
