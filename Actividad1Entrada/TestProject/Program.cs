//Variable de numero int y string
int numero = 0;
string? numeroString;

//Para comprobar si es int
bool validInt = false;

//Para comprobar si está entre 5 y 10
bool validN = false;

do{
    //Mensaje para introducir el valor
    Console.WriteLine("Introduce un numero del 5 al 10 entero: ");
    numeroString = Console.ReadLine();

    //Comprobar que el valor introducido es un int mediante un bool
    validInt = int.TryParse(numeroString, out numero);
    
    //Si es valido mostramos un mensaje
    if(validInt){
        //Pasamos el valor string a int y mostramos un mensaje
        numero = int.Parse(numeroString);
        Console.WriteLine($"El dato introducido {numero} es valido");
        
        //Comprobamos que se encuentra entre 5 y 10
        if(numero >= 5 && numero <= 10){
            validN = true;
        }else{
            Console.WriteLine($"El valor introducido {numero} no se encuentra ente 5-10");
        }
    }else{
        Console.WriteLine("No se ha inroducido una credencial valida");
    }

}while(validN == false);

//Mensaje de aceptacion
Console.WriteLine($"El numero {numero} ha sido aceptado");