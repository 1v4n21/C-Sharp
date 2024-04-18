int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

//Dividir (int) valor1 / (decimal) valor2 == int
int result1 = value1/(int)value2;

//Dividir (decimal) valor2 / (float) valor3 == decimal
decimal result2 = value2/(decimal)value3;

//Dividir (float) valor3 / (int) value1 == float
float result3 = value3/(float)value1;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
