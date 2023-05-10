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
            Cadastro1.id = 1;
            Cadastro1.nome = "Jose";
            Cadastro1.educacao = "Ensino superior";
            Cadastro1.salario = 1290.90f;
            Cadastro1.tempoDeServico = 12f;
            Cadastro1.codidoFuncao = 1;

            Cadastro Cadastro2 = new Cadastro();
            Cadastro2.id = 2;
            Cadastro2.nome = "Carla";
            Cadastro2.educacao = "Ensino Médio";
            Cadastro2.salario = 32900.90f;
            Cadastro2.tempoDeServico = 10f;
            Cadastro2.codidoFuncao = 2;

            Cadastro Cadastro3 = new Cadastro();
            Cadastro3.id = 3;
            Cadastro3.nome = "Maria";
            Cadastro3.educacao = "Ensino Superior";
            Cadastro3.salario = 3000.90f;
            Cadastro3.tempoDeServico = 8f;
            Cadastro3.codidoFuncao = 3;

            Cadastro Cadastro4 = new Cadastro();
            Cadastro4.id = 4;
            Cadastro4.nome = "José";
            Cadastro4.educacao = "Ensino superior";
            Cadastro4.salario = 3590.90f;
            Cadastro4.tempoDeServico = 6f;
            Cadastro4.codidoFuncao = 4;


            List<Cadastro> Cadastros = new List<Cadastro>();
            Cadastros.Add(Cadastro1);
            Cadastros.Add(Cadastro2);

            int i = 5;
            while (i < 9)
            {
                Cadastro CadastroAdicional = new Cadastro();
                CadastroAdicional.id = (i);

                Console.WriteLine(" DIGITE O CÓDIGO DA FUNÇÃO: ");
                CadastroAdicional.codidoFuncao = Int32.Parse(Console.ReadLine());

                Console.WriteLine("NOME: ");
                CadastroAdicional.nome = Console.ReadLine();

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

                Console.WriteLine($"\n ID: {Cadastro.id}");
                Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.codidoFuncao}");
                Console.WriteLine($"NOME: {Cadastro.nome}");
                Console.WriteLine($"ESCOLARIDADE: {Cadastro.educacao}");
                Console.WriteLine($"SALÁRIO: {Cadastro.salario}");
                Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.tempoDeServico} \n");

                if (Cadastro.codidoFuncao == 1)
                {
                    //somar somente os valores do cadastro 1
                    Console.WriteLine("\n ========= Gerente ========= \n");
                    float soma = Cadastro1.salario + Cadastro.salario;
                    float tempo = Cadastro1.tempoDeServico + Cadastro.tempoDeServico;
                    Console.WriteLine($"\n A média salarial da Gerencia é:  {soma / 2}");
                    Console.WriteLine($"\n Registro de tempo no setor da Gerencia é :  {tempo} horas por dia");


                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro1.nome);
                    Setor2.Add(Convert.ToString(Cadastro1.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro1.id));
                    Setor2.Add(Convert.ToString(Cadastro1.salario));
                    Setor2.Add(Convert.ToString(Cadastro1.tempoDeServico));
                    Setor2.Add(Cadastro.nome);
                    Setor2.Add(Convert.ToString(Cadastro.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.id));
                    Setor2.Add(Convert.ToString(Cadastro.salario));
                    Setor2.Add(Convert.ToString(Cadastro.tempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= GERENTE 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro1.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro1.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro1.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro1.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro1.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro1.tempoDeServico} \n");

                        Console.WriteLine("\n ======= GERENTE 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.tempoDeServico} \n");
                    }


                }

                else if (Cadastro.codidoFuncao == 2)
                {
                    Console.WriteLine("\n ======= Atendente ======= \n");

                    float soma1 = Cadastro2.salario + Cadastro.salario;
                    float tempo1 = Cadastro2.tempoDeServico + Cadastro.tempoDeServico;

                    Console.WriteLine($"\n A média salarial dos atendentes é:  {soma1 / 2}");
                    Console.WriteLine($"\n Registro de tempo no setor dos Atendentes é :  {tempo1} horas por dia");

                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro2.nome);
                    Setor2.Add(Convert.ToString(Cadastro2.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro2.id));
                    Setor2.Add(Convert.ToString(Cadastro2.salario));
                    Setor2.Add(Convert.ToString(Cadastro2.tempoDeServico));
                    Setor2.Add(Cadastro.nome);
                    Setor2.Add(Convert.ToString(Cadastro.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.id));
                    Setor2.Add(Convert.ToString(Cadastro.salario));
                    Setor2.Add(Convert.ToString(Cadastro.tempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= ATENDENTE 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro2.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro2.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro2.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro2.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro2.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro2.tempoDeServico} \n");
                        Console.WriteLine("\n ======= ATENDENTE 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.tempoDeServico} \n");
                    }

                }

                else if (Cadastro.codidoFuncao == 3)
                {
                    Console.WriteLine("\n ======= RH ======= \n");

                    float soma2 = Cadastro3.salario + Cadastro.salario;
                    float tempo2 = Cadastro3.tempoDeServico + Cadastro.tempoDeServico;

                    Console.WriteLine($"\n A média salarial da RH é:  {soma2 / 2}");
                    Console.WriteLine($"\n Registro de tempo no setor do RH é :  {tempo2} horas por dia");

                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro3.nome);
                    Setor2.Add(Convert.ToString(Cadastro3.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro3.id));
                    Setor2.Add(Convert.ToString(Cadastro3.salario));
                    Setor2.Add(Convert.ToString(Cadastro3.tempoDeServico));
                    Setor2.Add(Cadastro.nome);
                    Setor2.Add(Convert.ToString(Cadastro.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.id));
                    Setor2.Add(Convert.ToString(Cadastro.salario));
                    Setor2.Add(Convert.ToString(Cadastro.tempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= RH 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro3.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro3.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro3.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro3.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro3.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro3.tempoDeServico} \n");
                        Console.WriteLine("\n ======= RH 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.tempoDeServico} \n");

                    }

                }

                else if (Cadastro.codidoFuncao == 4)
                {
                    Console.WriteLine("\n ======= Suporte ======= \n");

                    float soma3 = Cadastro4.salario + Cadastro.salario;
                    float tempo3 = Cadastro4.tempoDeServico + Cadastro.tempoDeServico;

                    Console.WriteLine($"\n A média salarial do suporte é:  {soma3 / 2}");

                    Console.WriteLine($"\n Registro de tempo no setor do suporte é :  {tempo3} horas por dia");


                    List<string> Setor2 = new List<string>();
                    Setor2.Add(Cadastro4.nome);
                    Setor2.Add(Convert.ToString(Cadastro4.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro4.id));
                    Setor2.Add(Convert.ToString(Cadastro4.salario));
                    Setor2.Add(Convert.ToString(Cadastro4.tempoDeServico));
                    Setor2.Add(Cadastro.nome);
                    Setor2.Add(Convert.ToString(Cadastro.codidoFuncao));
                    Setor2.Add(Convert.ToString(Cadastro.id));
                    Setor2.Add(Convert.ToString(Cadastro.salario));
                    Setor2.Add(Convert.ToString(Cadastro.tempoDeServico));

                    foreach (var SetorAtendente in Setor2)
                    {
                        Console.WriteLine("\n ======= Suporte 1 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro4.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro4.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro4.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro4.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro4.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro4.tempoDeServico} \n");
                        Console.WriteLine("\n ======= Suporte 2 ======= \n");

                        Console.WriteLine($"\n ID: {Cadastro.id}");
                        Console.WriteLine($"CODIGO DA FUNÇÃO:{Cadastro.codidoFuncao}");
                        Console.WriteLine($"NOME: {Cadastro.nome}");
                        Console.WriteLine($"ESCOLARIDADE: {Cadastro.educacao}");
                        Console.WriteLine($"SALÁRIO: {Cadastro.salario}");
                        Console.WriteLine($"HORAS TRABALHADAS NO DIA:{Cadastro.tempoDeServico} \n");
                    }


                }

            }
        }
    }
}



