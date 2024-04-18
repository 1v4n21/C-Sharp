//Matriz con todos los valores (numericos y alfanumericos)
string[] values = { "12,3", "45", "ABC", "11", "DEF" };

//Cadena de letras
string cadena = "";

//Suma de los numeros
decimal sumaT = 0m;

//Decimal para hacer el tryParse
decimal result = 0m;

//For para recorrer la matriz de valores
for(int i = 0; i<values.Length; i++){
    
    //Si es un valor numerico lo sumamos a sumaT
    if (decimal.TryParse(values[i], out result))
    {
        sumaT += result;
    }

    //Si es un valor alfanumerico lo concatenamos a la cadena
    else
    {
        cadena += values[i];
    }
}

//Mostramos los resultados
Console.WriteLine($"Message:\t\t\t{cadena}");
Console.WriteLine($"Total:\t\t\t\t{sumaT}");
