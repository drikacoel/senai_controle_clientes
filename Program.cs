using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            
            Console.WriteLine("Informar nome");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar endereço");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)?");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                //Pessoa Física
                Pessoa_Fisica pessoaf = new Pessoa_Fisica();
                pessoaf.nome = var_nome;
                pessoaf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pessoaf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG");
                pessoaf.rg = Console.ReadLine();
                Console.WriteLine("Informar valor de compra");
                val_pag = float.Parse(Console.ReadLine());
                pessoaf.Pagar_Imposto(val_pag);
                
                Console.WriteLine("Pessoa Física");
                Console.WriteLine("Nome: " + pessoaf.nome);
                Console.WriteLine("Endereço: " + pessoaf.endereco);
                Console.WriteLine("CPF: " + pessoaf.cpf);
                Console.WriteLine("RG: " + pessoaf.rg);
                Console.WriteLine("Valor da compra: " + pessoaf.valor.ToString("C"));
                Console.WriteLine("Imposto: " + pessoaf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pessoaf.total.ToString("C"));

            if(var_tipo == "j")
            {
                Pessoa_Juridica pessoaj = new Pessoa_Juridica();
                pessoaj.nome = var_nome;
                pessoaj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pessoaj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE");
                pessoaj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor de compra");
                val_pag = float.Parse(Console.ReadLine());
                pessoaj.Pagar_Imposto(val_pag);

                Console.WriteLine("Pessoa Jurídica");
                Console.WriteLine("Nome: " + pessoaj.nome);
                Console.WriteLine("Endereço: " + pessoa.endereco);
                Console.WriteLine("CNPJ: " + pessoaj.cnpj);
                Console.WriteLine("IE: " + pessoaj.ie);
                Console.WriteLine("Valor da compra: " + pessoaj.valor.ToString("C"));
                Console.WriteLine("Imposto: " + pessoaj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar: " + pessoaj.total.ToString("C"));
            }
           

                
            }

        }

    }
}
