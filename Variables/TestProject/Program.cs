//Declaramos las variables al inicio,
//fuera de los bloques de codigo
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0; 

//Recorremos la matriz
foreach (int number in numbers)
{
    //Suma total de numeros
    total += number;

    //Comprobar si se encuentra el 42
    if (number == 42)
        found = true;

}

//Mensaje en caso de encontrar el 42
if (found) 
    Console.WriteLine("Set contains 42");

//Mensaje de suma total
Console.WriteLine($"Total: {total}");