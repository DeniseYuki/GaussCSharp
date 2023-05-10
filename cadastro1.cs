using pessoa.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// Empresa MaxAlteirTesla
//// cargos: Gerente [2], Atendente [2] , rh[2], suporte[2].
////média salarial por setor
////Registro de tempo por setor
//// cadastro e listagem por setor
/// criar um código para cada cargo
/// gerente cod 1 , Atendente cod 2, RH cod 3 e suporte cod 4


namespace EmpresaMaxAlteirTesla
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação dos cadastros
            Cadastro Cadastro1 = new Cadastro();
            Cadastro1.Id = 1;
            Cadastro1.Nome = "Jose";
            Cadastro1.Educacao = "Ensino superior";
            Cadastro1.Salario = 1290.90f;
            Cadastro1.TempoDeServico = 12f;
            Cadastro1.CodidoFuncao = 1;

            Cadastro Cadastro2 = new Cadastro();
            Cadastro2.Id = 2;
            Cadastro2.Nome = "Carla";
            Cadastro2.Educacao = "Ensino Médio";
            Cadastro2.Salario = 32900.90f;
            Cadastro2.TempoDeServico = 10f;
            Cadastro2.CodidoFuncao = 2;

            Cadastro Cadastro3 = new Cadastro();
            Cadastro3.Id = 3;
            Cadastro3.Nome = "Maria";
            Cadastro3.Educacao = "Ensino Superior";
            Cadastro3.Salario = 3000.90f;
            Cadastro3.TempoDeServico = 8f;
            Cadastro3.CodidoFuncao = 3;

            Cadastro Cadastro4 = new Cadastro();
            Cadastro4.Id = 4;
            Cadastro4.Nome = "José";
            Cadastro4.Educacao = "Ensino superior";
            Cadastro4.Salario = 3590.90f;
            Cadastro4.TempoDeServico = 6f;
            Cadastro4.CodidoFuncao = 4;


            List<Cadastro> Cadastros = new List<Cadastro>();
            Cadastros.Add(Cadastro1);
            Cadastros.Add(Cadastro2);

            int i = 5;
            while (i < 9)
            {
                Cadastro CadastroAdicional = new Cadastro();
                CadastroAdicional.Id = (i);

                Console.WriteLine(" DIGITE O CÓDIGO DA FUNÇÃO: ");
                CadastroAdicional.CodidoFuncao = Int32.Parse(Console.ReadLine());

                Console.WriteLine("NOME: ");
                CadastroAdicional.Nome = Console.ReadLine();

                Console.WriteLine("ESCOLARIDADE: ");
                CadastroAdicional.Educacao = Console.ReadLine();

                Console.WriteLine("SALARIO: ");
                CadastroAdicional.Salario = float.Parse(Console.ReadLine());

                Console.WriteLine("HORAS TRABALHADAS NO DIA: ");
                CadastroAdicional.TempoDeServico = float.Parse(Console.ReadLine());

                Cadastros.Add(CadastroAdicional);
                i++;
                Console.Clear();
            }

            Console.WriteLine("\n ====== CADASTROS ====== \n");
            foreach (var Cadastro in Cadastros)
            {

                Console.WriteLine($"\n ID: {Cadastro.Id}");
                Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.CodidoFuncao}");
                Console.WriteLine($"NOME: {Cadastro.Nome}");
                Console.WriteLine($"ESCOLARIDADE: {Cadastro.Educacao}");
                Console.WriteLine($"SALÁRIO: {Cadastro.Salario}");
                Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.TempoDeServico} \n");

                if (Cadastro.CodidoFuncao == 1)
                {
                    //somar somente os valores do cadastro 1
                    Console.WriteLine("\n ========= Gerente ========= \n");
                    float soma = Cadastro1.Salario + Cadastro.Salario;
                    float tempo = Cadastro1.TempoDeServico + Cadastro.TempoDeServico;
                    Console.WriteLine($"\n A média salarial da Gerencia é:  {soma / 2}");
                    Console.WriteLine($"\n Registro de tempo no setor da Gerencia é :  {tempo} horas por dia");


                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro1.Nome);
                    Setor2.Add(Convert.ToString(Cadastro1.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro1.Id));
                    Setor2.Add(Convert.ToString(Cadastro1.Salario));
                    Setor2.Add(Convert.ToString(Cadastro1.TempoDeServico));
                    Setor2.Add(Cadastro.Nome);
                    Setor2.Add(Convert.ToString(Cadastro.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.Id));
                    Setor2.Add(Convert.ToString(Cadastro.Salario));
                    Setor2.Add(Convert.ToString(Cadastro.TempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= GERENTE 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro1.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro1.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro1.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro1.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro1.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro1.TempoDeServico} \n");

                        Console.WriteLine("\n ======= GERENTE 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.TempoDeServico} \n");
                    }


                }

                else if (Cadastro.CodidoFuncao == 2)
                {
                    Console.WriteLine("\n ======= Atendente ======= \n");

                    float soma1 = Cadastro2.Salario + Cadastro.Salario;
                    float tempo1 = Cadastro2.TempoDeServico + Cadastro.TempoDeServico;

                    Console.WriteLine($"\n A média salarial dos atendentes é:  {soma1 / 2}");
                    Console.WriteLine($"\n Registro de tempo no setor dos Atendentes é :  {tempo1} horas por dia");

                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro2.Nome);
                    Setor2.Add(Convert.ToString(Cadastro2.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro2.Id));
                    Setor2.Add(Convert.ToString(Cadastro2.Salario));
                    Setor2.Add(Convert.ToString(Cadastro2.TempoDeServico));
                    Setor2.Add(Cadastro.Nome);
                    Setor2.Add(Convert.ToString(Cadastro.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.Id));
                    Setor2.Add(Convert.ToString(Cadastro.Salario));
                    Setor2.Add(Convert.ToString(Cadastro.TempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= ATENDENTE 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro2.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro2.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro2.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro2.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro2.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro2.TempoDeServico} \n");
                        Console.WriteLine("\n ======= ATENDENTE 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.TempoDeServico} \n");
                    }

                }

                else if (Cadastro.CodidoFuncao == 3)
                {
                    Console.WriteLine("\n ======= RH ======= \n");

                    float soma2 = Cadastro3.Salario + Cadastro.Salario;
                    float tempo2 = Cadastro3.TempoDeServico + Cadastro.TempoDeServico;

                    Console.WriteLine($"\n A média salarial da RH é:  {soma2 / 2}");
                    Console.WriteLine($"\n Registro de tempo no setor do RH é :  {tempo2} horas por dia");

                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro3.Nome);
                    Setor2.Add(Convert.ToString(Cadastro3.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro3.Id));
                    Setor2.Add(Convert.ToString(Cadastro3.Salario));
                    Setor2.Add(Convert.ToString(Cadastro3.TempoDeServico));
                    Setor2.Add(Cadastro.Nome);
                    Setor2.Add(Convert.ToString(Cadastro.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.Id));
                    Setor2.Add(Convert.ToString(Cadastro.Salario));
                    Setor2.Add(Convert.ToString(Cadastro.TempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= RH 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro3.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro3.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro3.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro3.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro3.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro3.TempoDeServico} \n");
                        Console.WriteLine("\n ======= RH 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.TempoDeServico} \n");

                    }

                }

                else if (Cadastro.CodidoFuncao == 4)
                {
                    Console.WriteLine("\n ======= Suporte ======= \n");

                    float soma3 = Cadastro4.Salario + Cadastro.Salario;
                    float tempo3 = Cadastro4.TempoDeServico + Cadastro.TempoDeServico;

                    Console.WriteLine($"\n A média salarial do suporte é:  {soma3 / 2}");

                    Console.WriteLine($"\n Registro de tempo no setor do suporte é :  {tempo3} horas por dia");


                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro4.Nome);
                    Setor2.Add(Convert.ToString(Cadastro4.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro4.Id));
                    Setor2.Add(Convert.ToString(Cadastro4.Salario));
                    Setor2.Add(Convert.ToString(Cadastro4.TempoDeServico));
                    Setor2.Add(Cadastro.Nome);
                    Setor2.Add(Convert.ToString(Cadastro.CodidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.Id));
                    Setor2.Add(Convert.ToString(Cadastro.Salario));
                    Setor2.Add(Convert.ToString(Cadastro.TempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= Suporte 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro4.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro4.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro4.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro4.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro4.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro4.TempoDeServico} \n");
                        Console.WriteLine("\n ======= Suporte 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.Id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.CodidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.Nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.Educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.Salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.TempoDeServico} \n");
                    }


                }

            }
        }
    }
}





