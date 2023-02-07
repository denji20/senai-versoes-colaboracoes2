using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica (f) ou Juridica (j) ?");
            string var_tipo = Console.ReadLine();
            if(var_tipo =="f")
            {
                // --- Pessoa Física ---
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.CPF = Console.ReadLine();
                Console.WriteLine("Informar RG");
                pf.RG = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("------ Pessoa Física -------");

                Console.WriteLine("Nome..........: " + pf.nome);
                Console.WriteLine("Endereco .....: " + pf.endereco);
                Console.WriteLine("CPF...........: " + pf.CPF);
                Console.WriteLine("RG............: " + pf.RG);
                Console.WriteLine("Valor de Compra:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto.......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar.: " + pf.total.ToString("C"));
            }
            if(var_tipo =="j")
            {
                // Pessoa Juridica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine("Informar IE");
                pj.IE = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("------ Pessoa Jurídica -------");
                Console.WriteLine("Nome..........: " + pj.nome);
                Console.WriteLine("Endereco .....: " + pj.endereco);
                Console.WriteLine("CNPJ...........: " + pj.CNPJ);                
                Console.WriteLine("IE............: " + pj.IE);
                Console.WriteLine("Valor de Compra:" + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar.: " + pj.total.ToString("C"));

            }
        }
    }
}
