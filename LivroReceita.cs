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

        static List<Livro> receitas;

        static void Main(string[] args)
        {
            receitas = new List<Livro>();

            receitas.Add(new Livro("brigadeiro", "doce"));
            receitas.Add(new Livro("morango", "doce"));
            receitas.Add(new Livro("arroz", "salgado"));
            receitas.Add(new Livro("feijoada", "salgado"));
            //receitas.Add(new Livro(null, null));

            foreach (Livro l in receitas)
           
            {
                Console.WriteLine(l.Receita +" : "+ l.Categoria);
            }

        }
    }
}





    

