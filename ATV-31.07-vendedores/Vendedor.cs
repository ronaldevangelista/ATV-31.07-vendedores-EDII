using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_31._07_vendedores
{
    internal class Vendedor
    {
        private int id;
        private string nome ="";
        private double percComissao;
        public Venda[] asVendas = new Venda[31];

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        
        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setPercComissao(double percComissao)
        {
            this.percComissao = percComissao;
        }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao/100;

            for(int i = 0; i < 31; i++)
            {
                asVendas[i] = new Venda();
            }
        }

        public Vendedor( string nome, double percComissao)
        {
            this.nome = nome;
            this.percComissao = percComissao;

            for (int i = 0; i < 31; i++)
            {
                asVendas[i] = new Venda();
            }
        }

        public Vendedor(string nome)
        {
            this.nome = nome;

            for (int i = 0; i < 31; i++)
            {
                asVendas[i] = new Venda();
            }
        }

        public Vendedor()
        {
            for (int i = 0; i < 31; i++)
            {
                asVendas[i] = new Venda();
            }
        }

        public void registrarVenda(int dia, Venda venda)
        {
            this.asVendas[dia] = venda;
        }

        public double valorVendas()
        {
            double valorVendas = 0;

            int i = 0;
            while(i < 31)
            {
                valorVendas += this.asVendas[i].valor;
                i++;
            }

            return valorVendas;
        }

        public double valorComissao()
        {
            return percComissao * valorVendas();
        }
    }
}
