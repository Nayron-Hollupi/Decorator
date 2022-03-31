using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator
{
    public class CarroDecorator : ICarro
    {
        //readonly impede que o campo seja substituído por uma instância diferente
        private readonly ICarro _carro;

        public CarroDecorator(ICarro carro) 
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
