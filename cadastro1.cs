using pessoa.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Cadastro Cadastro1 = new Cadastro();
Cadastro1.id = 1;
Cadastro1.nome = "jose";
Cadastro1.funcao = "Enfermeiro";
Cadastro1.educacao = "Ensino médio";
Cadastro1.salario = 1290.90f;
Cadastro1.tempoDeServico = 8f;

Cadastro Cadastro2 = new Cadastro();
Cadastro2.id = 2;
Cadastro2.nome = "Maria";
Cadastro2.funcao = "médica";
Cadastro2.educacao = "Ensino superior";
Cadastro2.salario = 32900.90f;
Cadastro2.tempoDeServico = 4f;

Cadastro Cadastro3 = new Cadastro();
Console.WriteLine("ID");
Cadastro3.id =
Int32.Parse(Console.ReadLine());

Console.WriteLine("NOME: ");
Cadastro3.nome =
Console.ReadLine();

Console.WriteLine("FUNÇÃO: ");
Cadastro3.funcao =
Console.ReadLine();

Console.WriteLine("ESCOLARIDADE: ");
Cadastro3.educacao =
Console.ReadLine();

Console.WriteLine("SALARIO: ");
Cadastro3.salario =
float.Parse(Console.ReadLine());

Console.WriteLine("HORAS TRABALHADAS NO DIA:  ");
Cadastro3.tempoDeServico =
float.Parse(Console.ReadLine());

List<string> lista = new List<string>();
lista.Add(Cadastro1.id + " : " + Cadastro1.nome);
lista.Add(Cadastro2.id + " : " + Cadastro2.nome);
lista.Add(Cadastro3.id + " : " + Cadastro3.nome);

foreach (var Pessoa in lista)
{
    Console.WriteLine("\n"+Pessoa);


}


Console.WriteLine("\nCADASTRO 1 \n" + Cadastro1.nome + "\n" + Cadastro1.funcao + "\n" + Cadastro1.educacao + "\n" + Cadastro1.salario + "\n" + Cadastro1.tempoDeServico + " horas \n");
Console.WriteLine("CADASTRO 2 \n" + Cadastro2.nome + "\n" + Cadastro2.funcao + "\n" + Cadastro2.educacao + "\n" + Cadastro2.salario + "\n" + Cadastro2.tempoDeServico + " horas \n");
Console.WriteLine("\nCADASTRO 3 \n" + Cadastro3.nome + "\n" + Cadastro3.funcao + "\n" + Cadastro3.educacao + "\n" + Cadastro3.salario + "\n" + Cadastro3.tempoDeServico + " horas \n");


