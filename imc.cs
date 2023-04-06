using System.Data;
using System.Diagnostics.SymbolStore;

Console.WriteLine(" Digite o seu peso: ");

float peso = float.Parse(Console.ReadLine());

Console.WriteLine("Digite sua altura: ");

float altura = float.Parse(Console.ReadLine());
float alturaAoQuadrado = altura * altura;
float imc = peso / alturaAoQuadrado;

Console.WriteLine("O IMC é: " + imc);

if (imc < 18.5)
{
    Console.WriteLine("O IMC está abaixo do peso");
}
if (imc > 18.6 && imc < 24.9)
{
    Console.WriteLine(" Peso ideal");
}
if (imc > 25 && imc < 29.9)

{
    Console.WriteLine("Acima do peso");

}
else

{
    Console.WriteLine("Obesidade");
 }
    
 
