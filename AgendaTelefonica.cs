using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

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
        private static object or;

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

                    Console.WriteLine("Adicionar mais um número? [aperte S para continuar ou qualquer outra tecla para sair]");
                    string c = Console.ReadLine();

                    while (c == "S")
                    {
                        Console.WriteLine("Adicionar mais um número? [aperte S para continuar ou qualquer outra tecla para sair]");
                        string d = Console.ReadLine();
                        
                        if (c == "S")
                        {
                            Console.WriteLine("Digite um nome: ");
                            nome = string.Format(Console.ReadLine());

                            Console.WriteLine("Digite um número: ");
                            telefone = Int32.Parse(Console.ReadLine());


                            contato.Add(new AgendaTelefonica(nome, telefone));

                            foreach (AgendaTelefonica a in contato)
                                Console.WriteLine("Nome: " + a.Nome + " cel: 11 " + a.Telefone);
                        }
                        else
                        {
                            break;
                        }
                    }


                }
            }

        }
    }
}