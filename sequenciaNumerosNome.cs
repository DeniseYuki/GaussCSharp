using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int i = 0;
        while (i <= 100)
        {
            numeros.Add(i);
            i += 2;
        }

        var soma = numeros.Sum();
        Console.WriteLine("Soma dos números pares de 0 a 100: " + soma);

        foreach (int numero in numeros)
        {

            if (numero % 5 == 0)
            {

                Console.WriteLine("\n Yuki \n");
            }
            else
            {
                Console.WriteLine(numero);

            }
        }
    }
}



