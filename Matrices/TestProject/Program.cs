
//Pasar cada caracter del string a un indice de la matriz
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();

Console.WriteLine(valueArray[5]);
*/

//Dar la vuelta a la matriz
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
*/

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}