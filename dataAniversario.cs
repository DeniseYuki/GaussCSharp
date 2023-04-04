

namespace ContagemCaracter;
class Program
{
    static void Main(string[] args)
    {
        string stdata;
        DateTime dtdata;
        DateTime aniversario = new DateTime(1990,08,03);
        
        Console.WriteLine("Digite a data:  (ano/mês/data)");
        stdata = Console.ReadLine();
        dtdata = DateTime.Parse(stdata);
        Console.WriteLine(dtdata);

        if (aniversario == dtdata)
        {
            Console.WriteLine(" A data informada é seu aniversário.");
        }
        else
        {
            Console.WriteLine("Não é seu aniversário!");
        }
        


    }
}
