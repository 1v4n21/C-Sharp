string customerName = "Ms. Barros";

//PRODUCTO 1
string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

//PRODUCTO 2
string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

//Todos los mensajes que aparecen por consola
Console.WriteLine("Dear Ms. Barros,");
Console.WriteLine("As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}\n");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:N2}.\n");

Console.WriteLine("Here's a quick comparison:\n");

//Mensaje de comparación de precios
string comparisonMessage = $"{currentProduct.PadRight(20)}{currentReturn:P2}   {currentProfit:C}\n{newProduct.PadRight(20)}{newReturn:P2}   {newProfit:C}";

//Mostrar mensaje de comparacion de precios
Console.WriteLine(comparisonMessage);
