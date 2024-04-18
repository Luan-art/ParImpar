// See https://aka.ms/new-console-template for more information
float number;

Console.WriteLine("Escreva um numéro");
number = float.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("par");
}
else
{
    Console.WriteLine("impar");
}