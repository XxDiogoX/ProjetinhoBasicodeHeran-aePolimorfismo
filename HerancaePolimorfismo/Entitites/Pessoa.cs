using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaePolimorfismo.Entitites
{
    class Pessoa
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string name, double rendaanual)
        {
            Name = name;
            RendaAnual = rendaanual;
        }

        public virtual double CalculateTax()
        {
            return 2.0;
        }
    }
}
