//Clase Random de C#
Random rnd = new Random();

//Matriz de alumnos y sus notas medias
int[][] alumnos = new int[4][];
decimal[] mediasNotas = new decimal[4];

for (int i = 0; i < alumnos.Length; i++)
{
    //Creamos alumnos de uno en uno en la matriz
    alumnos[i] = new int[5];

    for (int j = 0; j < alumnos[i].Length; j++)
    {
        //Creamos notas de una en una en la matriz
        alumnos[i][j] = rnd.Next(0, 100);

        //Realizamos la suma de notas
        mediasNotas[i] += alumnos[i][j];
    }

    //Realizamos la media de notas
    mediasNotas[i] /= alumnos[i].Length;
}

//Cabecera
Console.WriteLine("\nStudent\t\t\tGrade\n");

//Bucle para mostrar las notas
for(int i = 0; i < alumnos.Length; i++){

    //Mostramos el alumno y su nota media
    Console.Write($"Alumno{i}\t\t\t{mediasNotas[i]}\t\t");

    //Mostramos la letra en base a su nota
    if(mediasNotas[i]>=80){
        Console.WriteLine("A");
    }else if(mediasNotas[i]>=60){
        Console.WriteLine("B");
    }else if(mediasNotas[i]>=40){
        Console.WriteLine("C");
    }else{
        Console.WriteLine("D");
    }
}

//Salto de linea
Console.WriteLine("\n");
