using System;
using System.Linq;

int[,] matriz = new int[2,4];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("Escreva o peso do Boi");

            double peso = Convert.ToDouble(Console.ReadLine());
        matriz[i, j] = (int)peso;
        Console.Clear();
    }
};

int linha = matriz.GetLength(0);
int coluna = matriz.GetLength(1);
int pesoMaximo = int.MinValue;
int pesoMinimo = int.MaxValue;

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)

    {
        int pesoAtual = matriz[i, j];

        if (pesoAtual > pesoMaximo)
        {
            pesoMaximo = pesoAtual;
        }
        else if (pesoAtual < pesoMinimo)
        {

            pesoMinimo = pesoAtual;

        }
    }
}

Console.WriteLine("Peso máximo: " + pesoMaximo);
Console.WriteLine("Peso mínimo: "+pesoMinimo);
