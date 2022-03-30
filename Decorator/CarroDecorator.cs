using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    public class CarroDecorator : InterfaceCarro
    {
        private readonly InterfaceCarro _carro;

        public CarroDecorator(InterfaceCarro carro) 
        {
            _carro = carro;
        }
        public virtual string TipoCarro()
        {
            var carro = _carro.TipoCarro();
            return carro;
        }
    }
}
