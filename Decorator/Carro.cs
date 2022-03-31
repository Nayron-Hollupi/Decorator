using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    public class Carro : ICarro
    {

        public string Nome { get; set; }

        public Carro()
        {
            Nome = "Fusca";
    
        }

        public string TipoCarro()
        {
            var carro = "\n\t-------------------- Acaba de comprar --------------------\n" +
                                           "\n\t\t Carro :" + Nome ;
            return carro;
        }

    
    }
}
