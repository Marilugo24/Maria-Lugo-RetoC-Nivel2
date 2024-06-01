// See https://aka.ms/new-console-template for more information


List<string> estudiantes = new List<string>{"Valentina", "Elias", "Jose", "Fernanda", "Maria"};
List<double> notas = new List<double>{ 90, 85, 78, 92, 88 };

bool salir = false;

while (!salir)

{  
    Console.WriteLine("1. Añadir estudiante");
    Console.WriteLine("2. Mostrar lista de estudiantes");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Elige una de las opciones");

    int opcion = Convert.ToInt32(Console.ReadLine());
    

    switch (opcion)
    {
         case 1:
     Console.WriteLine("Introduce el nombre del estudiante:");
     string nombre = Console.ReadLine();
     estudiantes.Add(nombre);
     break;
        case 2:
     Console.WriteLine("Lista de estudiantes:");
     foreach(string estudiante in estudiantes)
     {
         Console.WriteLine(estudiante);
     }
     break;
        case 3:
     salir = true; 
     break;
        default:
     Console.WriteLine("Opción no válida. Por favor, elige de nuevo.");
     break;
    }
}

double suma = 0;

foreach (int nota in notas)
{
    suma += nota;
}

double promedio = suma / notas.Count;

Console.WriteLine($"El promedio de las notas finales es: {promedio}");



