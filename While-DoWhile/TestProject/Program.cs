//Clase random de C#
Random rnd = new Random();

//Vida de los personajes
int heroeV = 10;
int monstruoV = 10;

//Turno de ataque
bool heroeT = true;

//Daño realizado
int damage = 0;

//Salto de linea
Console.WriteLine("\n");

//do-while para el combate
do
{
    //Turno del heroe
    if(heroeT){
        damage = rnd.Next(1, 11);
        Console.WriteLine
        ($"El heroe ataca y hace -{damage} de daño al monstruo");
        monstruoV -= damage;
        Console.WriteLine
        ($"El monstruo se queda con {monstruoV} de vida");

        heroeT = false;
    }
    //Turno del monstruo
    else{
        damage = rnd.Next(1, 11);
        Console.WriteLine
        ($"El monstruo ataca y hace -{damage} de daño al heroe");
        heroeV -= damage;
        Console.WriteLine
        ($"El heroe se queda con {heroeV} de vida");

        heroeT = true;
    }

} while (heroeV > 0 && monstruoV > 0);

//Salto de linea
Console.WriteLine("\n");

//Mensaje final de victoria
if(heroeV <= 0)
    Console.WriteLine("El monstruo ha ganado");
else
    Console.WriteLine("El heroe ha ganado");

//Salto de linea
Console.WriteLine("\n");

