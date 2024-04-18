//Clase Random C#
Random rnd = new Random();

//Matriz de las mascotas
string[][] ourAnimals = new string[2][];

//Matriz para crear ids de animales
string[] idRandom = new string[15]
{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O"};

//Apartado de la web
string index = "";

//Validacion de opcion
bool valid = false;

//Mensaje de bienvenida
Console.WriteLine
("\nBienvenid@ a Contoso Pets, a que apartado quiere acceder?\n");
Console.WriteLine
("1-Enumerar informacion de las mascotas");
Console.WriteLine
("2-Agregar nueva mascota");
Console.WriteLine
("3-Editar mascota");
Console.WriteLine
("4-Gatos que cumplen caracteristicas");
Console.WriteLine
("5-Perros que cumplen caracteristicas");
Console.WriteLine
("6-Cerrar el programa");


//Animales de ejemplo
ourAnimals[0] = 
["123ABC", "Perro", "2", "Fuerte", "Gruñona", "Cleo"];
ourAnimals[1] = 
["456DEF", "Gato", "6", "Pequeña", "Buena", "Zoe"];

do{
    //Introducemos el apartado de la web al que queremos acceder
    index = Console.ReadLine();

    switch(index){
        case "1":
            //Bucle para ver los animales
            for(int i = 0; i<ourAnimals.Length; i++){
                Console.WriteLine("\n");

                foreach (string dato in ourAnimals[i]){
                    Console.WriteLine(dato);
                }
            }

            Console.WriteLine("A que apartado quiere acceder ahora? ");
            break;
        case "2":
            //Crear un animal
            string id;
            string especie;
            string edad;
            string 

            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;
        case "6":
            valid = true;
            break;
        default:
            Console.WriteLine("Introduce un numero valido: ");
            break;
    }

}while(valid == false);

Console.WriteLine("Aplicación cerrada con éxito!!");





