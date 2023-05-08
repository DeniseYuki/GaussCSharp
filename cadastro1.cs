using pessoa.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// Empresa MaxAlteirTesla
//// cargos: Gerente [2], Atendente [4] , rh[3], suporte[2].
////média salarial por setor
////Registro de tempo por setor
//// cadastro e listagem por setor


namespace EmpresaMaxAlteirTesla
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação dos cadastros
            Cadastro Cadastro1 = new Cadastro();
            Cadastro1.id = 1;
            Cadastro1.nome = "Jose";
            Cadastro1.funcao = "Gerente";
            Cadastro1.educacao = "Ensino superior";
            Cadastro1.salario = 1290.90f;
            Cadastro1.tempoDeServico = 8f;

            Cadastro Cadastro2 = new Cadastro();
            Cadastro2.id = 2;
            Cadastro2.nome = "Maria";
            Cadastro2.funcao = "Suporte";
            Cadastro2.educacao = "Ensino superior";
            Cadastro2.salario = 32900.90f;
            Cadastro2.tempoDeServico = 4f;

            // Criação de uma lista para armazenar os cadastros
            List<Cadastro> Cadastros = new List<Cadastro>();
            Cadastros.Add(Cadastro1);
            Cadastros.Add(Cadastro2);

            int i = 3;
            while (i < 11)
            {
                Cadastro CadastroAdicional = new Cadastro();
                Console.WriteLine("ID: ");
                CadastroAdicional.id = (i);

                Console.WriteLine("NOME: ");
                CadastroAdicional.nome = Console.ReadLine();

                Console.WriteLine("FUNÇÃO: ");
                CadastroAdicional.funcao = Console.ReadLine();

                Console.WriteLine("ESCOLARIDADE: ");
                CadastroAdicional.educacao = Console.ReadLine();

                Console.WriteLine("SALARIO: ");
                CadastroAdicional.salario = float.Parse(Console.ReadLine());

                Console.WriteLine("HORAS TRABALHADAS NO DIA: ");
                CadastroAdicional.tempoDeServico = float.Parse(Console.ReadLine());

                Cadastros.Add(CadastroAdicional);
                i++;
                Console.Clear();
            }

            Console.WriteLine("\n ====== CADASTROS ====== \n");
            foreach (var Cadastro in Cadastros)
            {
                Console.WriteLine($"ID: {Cadastro.id}");
                Console.WriteLine($"NOME: {Cadastro.nome}");
                Console.WriteLine($"FUNÇÃO: {Cadastro.funcao}");
                Console.WriteLine($"ESCOLARIDADE: {Cadastro.educacao}");
                Console.WriteLine($"SALÁRIO: {Cadastro.salario}");
                Console.WriteLine($"HORAS TRABALHADAS NO DIA:");

                // media salario por setor:

                if (Cadastro.funcao == "Gerente")
                {
                    float mediaSalario = (Cadastro.salario++)/2;
                    Console.WriteLine("\n "+mediaSalario);

                }

                else if(Cadastro.funcao == "Atendente")
                {
                    float mediaSalario = (Cadastro.salario++)/4;
                    Console.WriteLine("\n "+mediaSalario);


                }

                else if (Cadastro.funcao =="RH") {
                    float mediaSalario = (Cadastro.salario++)/3;
                    Console.WriteLine("/n "+mediaSalario);

                }

                else
                {
                    float mediaSalario = (Cadastro.salario++)/2;
                    Console.WriteLine("/n " + mediaSalario);


                }





            }
        }
    }
}

