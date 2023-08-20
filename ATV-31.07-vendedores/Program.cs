using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV_31._07_vendedores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedores Carrefour = new Vendedores();

            Console.WriteLine("Bem-vindo ao Carrefour");

            bool key = false;
            while(key == false)
            {
                Console.WriteLine("\nMENU DO CARREFOUR");
                Console.WriteLine("\n-----\n");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar vendedor");
                Console.WriteLine("2. Consultar vendedor");
                Console.WriteLine("3. Excluir vendedor");
                Console.WriteLine("4. Registrar venda");
                Console.WriteLine("5. Listar vendedores");

                Console.WriteLine("Selecione uma opção");
                int opt = Int32.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 0:
                        key = true;
                        break;
                    case 1:
                        Console.Write("Por favor insira o nome do vendedor: ");
                        string vendedorNome = Console.ReadLine();

                        Console.Write("Insira a percentagem de comissão: ");
                        double perComissao = double.Parse(Console.ReadLine());

                        Vendedor v = new Vendedor(vendedorNome, perComissao);
                        bool add = Carrefour.addVendedor(v);
                        if (add) { Console.WriteLine("Adicionado com sucesso!"); } else { Console.WriteLine("Lista de vendedores cheia"); }
                        break;
                    case 2:
                        Console.Write("Insira o nome do vendedor que deseja ser consultado: ");
                        string nomeConsultar = Console.ReadLine();

                        Vendedor vendedorConsultar = new Vendedor(nomeConsultar);

                        Vendedor vendedorConsultado = new Vendedor();
                        vendedorConsultado = Carrefour.searchVendedor(vendedorConsultar);

                        Console.WriteLine("Informações sobre vendedor:\n");
                        Console.WriteLine("id: " + vendedorConsultado.getId());
                        Console.WriteLine("Nome: " + vendedorConsultado.getNome());
                        Console.WriteLine("Valor de Comissão: " + vendedorConsultado.valorComissao());
                        Console.WriteLine("Média Diária: " + vendedorConsultado.valorVendas());
                        break;
                    case 3:
                        Console.Write("Escreva o nome do Vendedor que deseja excluir: ");
                        string nomeExcluir = Console.ReadLine();

                        Vendedor vendedorAExcluir = new Vendedor(nomeExcluir);
                        vendedorAExcluir = Carrefour.searchVendedor(vendedorAExcluir);

                        int totalVendas = 0;
                        for(int i = 0; i < vendedorAExcluir.asVendas.Length; i++)
                        {
                            totalVendas += vendedorAExcluir.asVendas[i].qtde;
                        }

                        if (totalVendas == 0)
                        {
                            Carrefour.delVendedor(vendedorAExcluir);
                            Console.WriteLine("Vendedor Excluído com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Impossível excluir vendedor que já tenha realizado vendas.");
                            Console.WriteLine("Vá reclamar no Comercial");
                        }
                        break;
                    case 4:

                        Console.Write("Insira a quantidade de produtos comprados: ");
                        int qtd = Int32.Parse(Console.ReadLine());
                        Console.Write("Insira o valor total da venda: ");
                        double value = double.Parse(Console.ReadLine());
                        Console.Write("Insira o dia da venda: ");
                        int dia = Int32.Parse(Console.ReadLine());

                        Console.Write("Insira o nome do Vendedor: ");
                        Vendedor vendedor = new Vendedor(Console.ReadLine());
                        vendedor = Carrefour.searchVendedor(vendedor);
                        if (vendedor.getNome() != "Não encontrado")
                        {
                            Venda venda = new Venda(qtd, value);
                            vendedor.registrarVenda(dia, venda);
                            Carrefour.addVendedor(vendedor);
                            Console.WriteLine("Venda atualizada com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Vendedor não achado");
                        }
                        break;
                    case 5:
                        for(int i = 0; i < 10; i++)
                        {
                            Carrefour.
                        }
                        break;
                    default:
                        Console.WriteLine("Valor inválido!");
                        break;
                }

                
            }

            Console.WriteLine("Agradecemos por usar o nosso sistema fuleiro");
        }
    }
}
