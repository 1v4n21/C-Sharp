//Variable con la cadena que debemos revertir
string pangram = "The quick brown fox jumps over the lazy dog";

//Guardamos la cadena en una matriz separando los trozos por los espacios
string[] message = pangram.Split(' ');

//Creamos una matriz con un indice similar a la longitud de las palabras de la cadena de texto
string[] newMessage = new string[message.Length];

//Recorremos la matriz con la cadena sin los espacios en blanco
for (int i = 0; i < message.Length; i++)
{
    //Guardamos las letras de cada palabra
    char[] letters = message[i].ToCharArray();

    //Le damos la vuelta a las letras
    Array.Reverse(letters);

    //Guardamos la palabra al reves en su posicion del array
    newMessage[i] = new string(letters);
}

//Pasamos la matriz a un string con espacios en blanco en cada palabra
string result = String.Join(" ", newMessage);

//Mostramos la cadena de texto
Console.WriteLine(result);
