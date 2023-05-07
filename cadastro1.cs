using pessoa.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Cadastro cadastro1 = new Cadastro();
cadastro1.id = 1;
cadastro1.nome = "jose";
cadastro1.funcao = "Enfermeiro";
cadastro1.educação = "Ensino médio";
cadastro1.salario = 1290.90f;
cadastro1.tempoDeServico = 8f;

Cadastro cadastro2 = new Cadastro();
cadastro2.id = 2;
cadastro2.nome = "Maria";
cadastro2.funcao = "médica";
cadastro2.educação = "Ensino superior";
cadastro2.salario = 32900.90f;
cadastro2.tempoDeServico = 4f;

List<string> lista = new List<string>();
lista.Add(cadastro1.id+" : "+cadastro1.nome);
lista.Add(cadastro2.id+" : "+cadastro2.nome);

foreach (var pessoa in lista)
{
    Console.WriteLine(pessoa);
   

}


Console.WriteLine("\nCADASTRO 1 \n"+cadastro1.nome + "\n" + cadastro1.funcao + "\n" + cadastro1.educação + "\n" + cadastro1.salario + "\n" + cadastro1.tempoDeServico+" horas \n");
Console.WriteLine("CADASTRO 2 \n"+cadastro2.nome + "\n" + cadastro2.funcao + "\n" + cadastro2.educação + "\n" + cadastro2.salario + "\n" + cadastro2.tempoDeServico+" horas \n");

