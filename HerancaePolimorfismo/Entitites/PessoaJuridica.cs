using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace HerancaePolimorfismo.Entitites
{
    class PessoaJuridica : Pessoa
    {
        public int QuantityEmployee { get; set; }

        public PessoaJuridica()
        {

        }

        public PessoaJuridica(int quantityemployee, string name, double rendaanual): base(name, rendaanual)
        {
            QuantityEmployee = quantityemployee;
        }

        public override double CalculateTax()
        {
            double total;
            if(QuantityEmployee >= 10)
            {
                total = RendaAnual * 14 / 100;
            }
            else
            {
                total = RendaAnual * 16 / 100;
            }
            return total;
        }

        public override string ToString()
        {
            return $"Name: {Name} $ {CalculateTax().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
