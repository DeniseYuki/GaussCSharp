using System;
using System.Collections;
class Program
{

    public class Livro
    {

        public Livro() { }

        public string Prato { get; set; }
        public string TipoPrato { get; set; }

        public Livro(string Prato, string TipoPrato)
        {
            this.Prato = Prato;
            this.TipoPrato = TipoPrato;
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

                Console.WriteLine(l.Prato +" "+ l.TipoPrato);
            }




        }
    }
}




   // public class Livro
    

      //  public Livro() { }

       // public string Prato { get; set; }
       // public string TipoPrato { get; set; }

      //  public Livro(string Prato, string TipoPrato)
        
        //    this.Prato = Prato;
        //    this.TipoPrato = TipoPrato;
       // }


    

