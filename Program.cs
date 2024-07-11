using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float varValorCompra;
            Console.WriteLine("Informar Nome");
            string varNome = Console.ReadLine();

            Console.WriteLine("Informar endereco");
            string varEndereco = Console.ReadLine();

            Console.WriteLine("pessoa fisica (F) || pessoa juridica (J)");
            string varTipoPessoa = Console.ReadLine();

            if( varTipoPessoa == "f")
            {
                //Pessoa fisica
                PessoaFisica pf = new PessoaFisica();

                pf.nome = varNome;
                pf.endereco = varEndereco;

                Console.WriteLine("Informar CPF");
                string varCPF = Console.ReadLine();

                Console.WriteLine("Informar RG");
                string varRG = Console.ReadLine();
                
                Console.WriteLine("Informar Valor de Compra");
                varValorCompra = float.Parse(Console.ReadLine());

                pf.PagarImposto(varValorCompra);

                Console.WriteLine("---Pessoa Fisica---");
                Console.WriteLine($"Nome ................:{pf.nome}");
                Console.WriteLine($"Endeco ..............:{pf.endereco}");
                Console.WriteLine($"CPF .................:{pf.cpf}");
                Console.WriteLine($"RG ..................:{pf.rg}");
                Console.WriteLine($"Valor de Compra .....:{pf.valor.ToString("C")}");
                Console.WriteLine($"Imposto .............:{pf.valor_imposto.ToString("C")}");
                Console.WriteLine($"Total a Pagar........:{pf.total.ToString("C")}");

            }
            if( varTipoPessoa == "j")
            {
                //Pessoa fisica
                PessoaJurica pj = new PessoaJurica();

                pj.nome = varNome;
                pj.endereco = varEndereco;

                Console.WriteLine("Informar CNPJ");
                string varCNPJ = Console.ReadLine();

                Console.WriteLine("Informar IE");
                string varRG = Console.ReadLine();
                
                Console.WriteLine("Informar Valor de Compra");
                varValorCompra = float.Parse(Console.ReadLine());

                pj.PagarImposto(varValorCompra);

                Console.WriteLine("---Pessoa Juridica---");
                Console.WriteLine($"Nome ................:{pj.nome}");
                Console.WriteLine($"Endeco ..............:{pj.endereco}");
                Console.WriteLine($"CPF .................:{pj.cnpj}");
                Console.WriteLine($"RG ..................:{pj.ie}");
                Console.WriteLine($"Valor de Compra .....:{pj.valor.ToString("C")}");
                Console.WriteLine($"Imposto .............:{pj.valor_imposto.ToString("C")}");
                Console.WriteLine($"Total a Pagar........:{pj.total.ToString("C")}");

            }


        }
    }
}