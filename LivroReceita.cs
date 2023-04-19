using System;
using System.Collections.Generic;
class Program
{

    public class Livro
    {

        public Livro() { }

        public string Receita { get; set; }
        public string Categoria { get; set; }

        public Livro(string Receita, string Categoria)
        {
            this.Receita = Receita;
            this.Categoria = Categoria;
        }

        

        static List<Livro> receitasBolo;

        static void Main(string[] args)

        {
            receitasBolo = new List<Livro>();

            receitasBolo.Add(new Livro("brigadeiro", "bolo"));
            receitasBolo.Add(new Livro("morango", "bolo"));
            receitasBolo.Add(new Livro("Laranja", "bolo"));
            receitasBolo.Add(new Livro("Cenoura", "bolo"));


            foreach (Livro l in receitasBolo)

            {

            Console.WriteLine(l.Categoria + " de " + l.Receita);

            }

            Console.WriteLine("\n");


            List<Livro> receitasTorta;

            {
                receitasTorta = new List<Livro>();

                receitasTorta.Add(new Livro("frango", "Torta"));
                receitasTorta.Add(new Livro("carne","Torta"));
                receitasTorta.Add(new Livro("morango", "Torta"));
                receitasTorta.Add(new Livro("banana", "Torta"));
                receitasTorta.Add(new Livro("batata", "Torta"));
                receitasTorta.Add(new Livro("doce", "Torta"));

                foreach (Livro t in receitasTorta)

                {
                    Console.WriteLine(t.Categoria + " de " + t.Receita);

                }


            }
        }
    }
}
    






    
