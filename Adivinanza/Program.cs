// See https://aka.ms/new-console-template for more information

Random random = new Random();
List<string> Frutas = new List<string>() {"Piña","Manzana","Uva","Mango","Pera" };
Dictionary<string, int> Adivina = new Dictionary<string, int>();

Adivina.Add("Piña", 10);
Adivina.Add("Manzana", 20);
Adivina.Add("Uva", 30);
Adivina.Add("Mango", 40);
Adivina.Add("Pera", 50);

Console.WriteLine("¡Bienvenido al juego de adivinanzas! Tienes que adivinar el número de cada fruta.");

    foreach (string fruta in Frutas)
{
        string frutaRandom = Frutas[random.Next(Frutas.Count)];
        Console.WriteLine($"Adivina el número de la fruta o salir para terminar el juego. Tienes 3 intentos. {frutaRandom}");
        string adivinanza = Console.ReadLine();

        if (adivinanza.ToLower() == "salir")
        {
            Console.WriteLine("Has elegido salir del juego. ¡Hasta la próxima!");
            break;
        }

        for (int intento = 1; intento <= 3; intento++)
        {
        Console.Write($"Intento {intento}: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero == Adivina[frutaRandom])
        {
            Console.WriteLine($"¡Correcto! Has adivinado el número de la fruta: {frutaRandom}");
            break;
        }
        else
        {
            Console.WriteLine("Incorrecto. Intenta de nuevo.");
        }
        if (intento == 3)
        {
            Console.WriteLine($"Lo siento, no has adivinado el número. La fruta era {frutaRandom} y su número es {Adivina[frutaRandom]}.");
        }
    }
}

