using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes
{
    public class Factory
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "Sub Zero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
