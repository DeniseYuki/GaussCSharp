// 1 maneira: usando WHILE: (não estava. no exercicio, mas foi o primeiro que eu imaginei, depois eu li direito e fiz o segundo)

int num = 101, i = 0;
while (i < 100)
{
    num --;
    Console.WriteLine(num);
    i++;
}




// 2 maneira: usando o FOR:

for (int a = 100; a > 0; a--)
{
    Console.WriteLine(a);
}





//  3 maneira: list e foreach

        List<int> numeros = new List<int>();
        int i = 100;
        while (i >0)
        {
            
            numeros.Add(i);
            i--;
        }

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }






