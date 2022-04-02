int n;

Console.Write("\nDigite um número: ");
n = Convert.ToInt32(Console.ReadLine());

bool positivo = n > 0;
bool negativo = n < 0; 
bool zero = n == 0;

if (positivo)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{n} é POSITIVO!\n");

}
if (negativo)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{n} é NEGATIVO!\n");
}

if (zero)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("ZERO.\n");
}

Console.ResetColor();