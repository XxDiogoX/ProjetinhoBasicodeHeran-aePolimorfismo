using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace HerancaePolimorfismo.Entitites
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica()
        {

        }

        public PessoaFisica(double gastossaude, string name, double rendaanual) : base(name, rendaanual)
        {
            GastosSaude = gastossaude;
        }

        public override double CalculateTax()
        {
            double valor = 0;
            if(RendaAnual < 20.000)
            {
                valor += (RendaAnual * 15 / 100) - (GastosSaude / 2);
            }
            else
            {
                valor += (RendaAnual * 25 / 100) - (GastosSaude / 2);
            }
            return valor;
        }

        public override string ToString()
        {
            return $"Name: {Name} $ {CalculateTax().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
        