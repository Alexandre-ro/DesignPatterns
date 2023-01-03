﻿using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composição()
        {
            Console.WriteLine("Energia de sustentação da base pela terra.");
        }
    }
}
