using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    public class AirbagDecorator : CarroDecorator
    {


        public AirbagDecorator(ICarro carro)
         : base(carro)
        {
       
        }


        public override string TipoCarro()
        {
            var carro = base.TipoCarro();
            carro += "\n\t\t Opcional: Airbag" ;
            return carro;
        }

    }
}
