using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    internal class Mp3Decorator : CarroDecorator
    {

        public Mp3Decorator(InterfaceCarro carro)
         : base(carro)
        {

        }


        public override string TipoCarro()
        {
            var carro = base.TipoCarro();
            carro += ", com Radio MP3 Player";
            return carro;
        }
    }
}

