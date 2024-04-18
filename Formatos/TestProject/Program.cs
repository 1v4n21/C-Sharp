/*
//Dos variables string que se concatenan
string first = "Hello";
string second = "World";

//Dar formato
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine("{1} {1} {0}!", first, second);
Console.WriteLine(result);

//Formato de moneda
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C2} (Save {discount:C2})");

//Cuantas decimales mostrar
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N2} units");

//Porcentajes
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
*/

//Crear espacios en blanco desde Left izq
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));

//Desde Right derecha
Console.WriteLine(input.PadRight(12));

//Crear espacios con caracteres -
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

//Texto con espacios
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine(formattedLine);

//Formato a las monedas porcentajes y decimales
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");