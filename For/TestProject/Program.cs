//For para recorrer de 1 a 100
for (int i = 1; i <= 100; i++)
{
    /*Condiciones para comprobar si el numero es divisible entre
    5, 3 o los dos a la vez*/
    
    if(i%3 == 0 && i%5 != 0) 
        Console.WriteLine($"{i} - Fizz");
    else if(i%5 == 0 && i%3 != 0) 
        Console.WriteLine($"{i} - Buzz");
    else if(i%3 == 0 && i%5 == 0) 
        Console.WriteLine($"{i} - FizzBuzz");
    else 
        Console.WriteLine(i);
}
