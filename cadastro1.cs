using pessoa.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Cadastro cadastro1 = new Cadastro();
cadastro1.nome = "jose";
cadastro1.funcao = "Padeiro";
cadastro1.educação = "Ensino médio";
cadastro1.salario = 1290.90f;
cadastro1.tempoDeServico = 8f;

Cadastro cadastro2 = new Cadastro();
cadastro2.nome = "Maria";
cadastro2.funcao = "médico";
cadastro2.educação = "Ensino superior";
cadastro2.salario = 129000.90f;
cadastro2.tempoDeServico = 4f;

TotalFuncionarios lista = new TotalFuncionarios();
lista.Add(cadastro1.nome);
lista.Add(cadastro2.nome);

Console.WriteLine(cadastro1.nome + "\n" + cadastro1.funcao + "\n" + cadastro1.educação+cadastro1.salario+cadastro1.tempoDeServico);
Console.WriteLine(cadastro2.nome + cadastro2.funcao + cadastro2.educação + cadastro2.salario + cadastro2.tempoDeServico);
Console.WriteLine(lista);
