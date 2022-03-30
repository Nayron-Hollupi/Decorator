using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    public class XenonDecorator : CarroDecorator
    {
        public XenonDecorator(InterfaceCarro carro)
            : base(carro)
        {

        }


        public override string TipoCarro()
        {
            var carro = base.TipoCarro();
            carro += ", com  farol de xenon";
            return carro;
        }


    }
}
