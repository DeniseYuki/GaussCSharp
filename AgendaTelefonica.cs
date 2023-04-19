using System;
using System.Collections.Generic;

class program
{
    public class Agenda
    {
    }
    public class AgendaTelefonica
    {
        public AgendaTelefonica()
        { }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public static string nome { get; private set; }

        public AgendaTelefonica(string nome, int telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }


        static List<AgendaTelefonica>? contato;
        private static int telefone;

        static void Main(string[] args)

        {
            {

                contato = new List<AgendaTelefonica>();

                {
                    Console.WriteLine("Digite um nome: ");
                    nome = string.Format(Console.ReadLine());

                    Console.WriteLine("Digite um número: ");
                    telefone = Int32.Parse(Console.ReadLine());


                    contato.Add(new AgendaTelefonica(nome, telefone));

                    foreach (AgendaTelefonica a in contato)
                        Console.WriteLine("Nome: " + a.Nome + " cel: 11 " + a.Telefone);
                }
            }

        }
    }
}