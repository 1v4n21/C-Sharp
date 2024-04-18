//Cadena de valores que debemos ordenar y verificar
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//Dividimos la cadena por las comas ,
string [] matriz = orderStream.Split(",");

//Ordenamos la matriz en orden alfabetico
Array.Sort(matriz);

//Recorremos la matriz id por id y comprobamos que es valido
foreach(string valor in matriz){
    if(valor.Length == 4){
        Console.WriteLine(valor);
    }else{
        Console.WriteLine(valor+"\t\t\t\t--Error");
    }
}