using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class FabricaBaseZerg : IFabricaBase
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso!");

            RevestimentoBaseZerg rv = new RevestimentoBaseZerg();
            rv.Composicao();

            EnergiaBaseZerg en = new EnergiaBaseZerg();
            en.Composição();
        }
    }
}
