using System;

class Factorial
{
    static void Main()
    {
        double n, f;

        Console.Write("Ingrese un número: ");
        n = double.Parse(Console.ReadLine());

        f = 1;
        for (int i = 1; i <= n; i++)
        {
            f = f * i;
        }

        Console.WriteLine("El factorial de {0} es {1}", n, f);

        Console.ReadKey();
    }
}
