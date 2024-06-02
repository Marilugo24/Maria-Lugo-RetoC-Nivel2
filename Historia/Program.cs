// See https://aka.ms/new-console-template for more information


List<string> Personas = new List<string>() { "Elias", "Juana", "Johana", "Danielys", "Gregorio" };
List<string> Evento = new List<string>() { "gano el juego", "encontro un perrito", "esta comiendo", "empezo a Trabajar", "esta viendo una pelicula" };
List<string> Lugares = new List<string>() { "la playa", "el bosque encantado", "el jardin", "el cine", "la biblioteca" };

Random random = new Random();

for (int i = 0; i < 5; i++)
{
    string personaRandom = Personas[random.Next(Personas.Count)];
    string lugarRandom = Lugares[random.Next(Lugares.Count)];
    string eventoRandom = Evento[random.Next(Evento.Count)];

    string historia = personaRandom + " " + eventoRandom + " en " + lugarRandom + ".";
    if (personaRandom == "Juana")
    {
         historia += " Y lo hizo con una sonrisa en su rostro.";
        }
         else if (eventoRandom == "encontro un perrito")
        {
        historia += " Decidió llevarlo a casa y cuidarlo.";
        }
         else
        {
         historia += " Fue un día normal como cualquier otro.";
    }
         Console.WriteLine(historia);

}

