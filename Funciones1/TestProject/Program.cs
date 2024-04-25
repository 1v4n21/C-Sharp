Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}