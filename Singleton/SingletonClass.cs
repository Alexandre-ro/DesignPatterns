namespace Singleton
{
    public sealed class SingletonClass
    {
        private static SingletonClass instancia = null;

        public static SingletonClass GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new SingletonClass();
                    Console.WriteLine("Bola em jogo");
                }
                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
