using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_31._07_vendedores
{
    internal class Venda
    {
        public int qtde = 0;
        public double valor = 0;

        public Venda(int qtde, double valor) 
        {
            this.qtde = qtde;
            this.valor = valor;
        }

        public Venda()
        {

        }

        public double valorMedio()
        {
            return this.valor/this.qtde;
        }
    }
}
