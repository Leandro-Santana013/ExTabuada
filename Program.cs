int n;

Console.Write("digite o numero da tabuada: ");
n = int.Parse(Console.ReadLine()!);


for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}
