using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    internal class ArDecorator : CarroDecorator
    {

        public ArDecorator(InterfaceCarro carro)
           : base(carro)
        {

        }


        public override string TipoCarro()
        {
            var carro = base.TipoCarro();
            carro += ", com Ar Condicionado Automotivo ";
            return carro;
        }

    }
}
