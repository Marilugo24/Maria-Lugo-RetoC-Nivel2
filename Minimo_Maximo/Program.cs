// See https://aka.ms/new-console-template for more information

int[] Array = { 60, 50, 40, 30, 20, 10, 70, 80, 99 };

int minimo = Array.Min();
int maximo = Array.Max();

for (int i = 0; i < 5; i++)
{
    if (Array[i] < minimo)
    {
        minimo = Array.Min();
    }

    if (Array[i] > maximo)
    {
        maximo = Array.Max();
    }
}

Console.WriteLine("El valor mínimo del Array es: " + minimo);
Console.WriteLine("El valor máximo del Array es: " + maximo);