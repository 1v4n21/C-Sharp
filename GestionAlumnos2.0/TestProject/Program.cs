//Random C#
Random rnd = new Random();

//Matriz de notasExamenes con las notas y medias
int[][] notasExamenes = new int[4][];
decimal[] mediasExamenes = new decimal[4];

//Matriz de notasTareas con las notas y medias
int[][] notasTareas =new int[4][];
decimal[] mediasTareas = new decimal[4];

//Puntos Extra
decimal [] puntosExtra =new decimal[4];

//Nota Final
decimal [] notaFinal = new decimal[4];

//Recorremos cada alumno y le introducimos las notas de exmanes y tareas
for(int i = 0; i<notasExamenes.Length; i++){

    //Creacion de matriz con 5 notas de examenes y tareas
    notasExamenes[i] = new int[5];
    notasTareas[i] = new int[5]; 

    //Introducimos las notas con Random
    for(int j = 0; j<notasExamenes[i].Length; j++){
        //Notas
        notasExamenes[i][j] = rnd.Next(0,100);
        notasTareas[i][j] = rnd.Next(0,100);

        //Medias
        mediasExamenes[i] += notasExamenes[i][j];
        mediasTareas[i] += notasTareas[i][j];
    }

    //Sacamos los puntos extra
    puntosExtra[i]=mediasTareas[i]/10;

    //Sacamos la nota total
    notaFinal[i]=(mediasExamenes[i]+puntosExtra[i]) / notasExamenes[i].Length;

    //Media total
    mediasExamenes[i] /= notasExamenes[i].Length;
    mediasTareas[i] /= notasTareas[i].Length;

    //Puntos extra totales
    puntosExtra[i]=notaFinal[i]-mediasExamenes[i];
}

//Cabecera
Console.WriteLine("\nStudent\t\t\tExam Score\t\tOverall\t\tGrade\t\tExtra Credit\n");

//Mostrar los alumnos
for(int i = 0; i<notasExamenes.Length; i++){

    //Mostramos la letra en base a su nota
    if(notaFinal[i]>=80){
        Console.WriteLine($"Alumno{i}\t\t\t{mediasExamenes[i]}\t\t\t{notaFinal[i]}\t\tA\t\t{mediasTareas[i]} ({puntosExtra[i]})");
    }else if(notaFinal[i]>=60){
        Console.WriteLine($"Alumno{i}\t\t\t{mediasExamenes[i]}\t\t\t{notaFinal[i]}\t\tB\t\t{mediasTareas[i]} ({puntosExtra[i]})");
    }else if(notaFinal[i]>=40){
        Console.WriteLine($"Alumno{i}\t\t\t{mediasExamenes[i]}\t\t\t{notaFinal[i]}\t\tC\t\t{mediasTareas[i]} ({puntosExtra[i]})");
    }else{
        Console.WriteLine($"Alumno{i}\t\t\t{mediasExamenes[i]}\t\t\t{notaFinal[i]}\t\tD\t\t{mediasTareas[i]} ({puntosExtra[i]})");
    }    
}

//Salto de linea
Console.WriteLine("\n");
