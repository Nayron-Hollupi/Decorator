using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    public class InsulfilmDecorator : CarroDecorator
    {

        public InsulfilmDecorator(InterfaceCarro carro)
           : base(carro)
        {

        }


        public override string TipoCarro()
        {
            var carro = base.TipoCarro();
            carro += " , com Insulfilm";
            return carro;
        }
    }
}
