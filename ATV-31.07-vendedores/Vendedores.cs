using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_31._07_vendedores
{
    internal class Vendedores
    {
        private int max;
        private int qtde;
        private Vendedor[] osVendedores = new Vendedor[10];

        public Vendedores()
        {
            this.max = 9;
            this.qtde = 0;

            for(int i = 0; i < max; i++)
            {
                osVendedores[i] = new Vendedor();
            }
        }

        public Vendedor searchVendedor(Vendedor v)
        {
            int i = 0;
            Vendedor achado = new Vendedor();

            while (i < max && osVendedores[i].getNome() != v.getNome())
            {
                i++;
            }

            if (i == max && osVendedores[i - 1].getNome() != v.getNome())
            {
                achado.setNome("Não encontrado");
            }
            else
            {
                achado = osVendedores[i];
            }
            return achado;
        }

        public bool addVendedor(Vendedor v)
        {
            int i = 0;

            while ((i < max && osVendedores[i].getNome() != "") && osVendedores[i].getNome() != v.getNome())
            {
                i++;
            }

            if ((i == max && osVendedores[i].getNome() != "") && osVendedores[i].getNome() != v.getNome())
            {
                return false;
            }
            else
            {
                osVendedores[i] = v;
                osVendedores[i].setId(i + 1);
                return true;
            }
        }


        public bool delVendedor(Vendedor v)
        {
            int i = -1;

            do
            {
                i++;
            } while (i < max && osVendedores[i].getNome() != v.getNome());

            if (i == max && osVendedores[i].getNome() != v.getNome())
            {
                return false;
            }
            else
            {
                osVendedores[i].setNome("");
                osVendedores[i].setPercComissao(0);
                osVendedores[i].setId(0);
                return true;
            }
        }

        public double valorVendas()
        {
            double value = 0;

            for (int i = 0; i < max; i++)
            {
                value += osVendedores[i].valorVendas();
            }

            return value;
        }
        
        public double valorComissao()
        {
            double value = 0;

            for(int i = 0; i < max; i++)
            {
                value += osVendedores[i].valorComissao();
            }

            return value;
        }
    }
}
