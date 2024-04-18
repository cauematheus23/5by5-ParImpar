int x;
Console.WriteLine("Digite o valor para verificar: ");
x = int.Parse(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine($"{x} é par");
}
else
{
    Console.WriteLine($"{x} é impar");
}