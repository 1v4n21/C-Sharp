//Variable de rol
string? rol;

//Booleano de validacion
bool validR = false;

//Mensaje de entrada
Console.WriteLine("\nIntroduce uno de los nombres de rol: ");

do{
    //Introducimos el valor por consola
    rol = Console.ReadLine();

    //Omitir los caracteres y mayusculas de entrada
    rol = rol.ToLower().Trim();

    //Comprobamos que es un valor valido
    switch(rol){
        case "administrador":
            validR=true;
            break;
        case "director":
            validR=true;
            break;
        case "usuario":
            validR=true;
            break;
        default:
            Console.WriteLine
            ("Valor no valido, introduzca otro:");
            break;
    }

}while(validR == false);

//Mensaje de aceptacion
Console.WriteLine($"\nValor introducido -{rol}- valido");