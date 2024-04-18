//Clase Random C#
Random rnd = new Random();

//Valores aleatorios con rnd
string permission = rnd.Next(0,2) == 1 ? "Admin" : "Manager";
int level = rnd.Next(0,70);

//Visualizacion de los valores
Console.WriteLine($"\n{permission} --- {level}\n");

//Comprobacion de valores
if(permission.Contains("Admin") && level > 55){
    Console.WriteLine("Welcome, Super Admin user\n");
}else if(permission.Contains("Admin") && level <= 55){
    Console.WriteLine("Welcome, Admin user\n");
}else if(permission.Contains("Manager") && level > 20){
    Console.WriteLine("Contact an Admin for access\n");
}else if(permission.Contains("Manager") && level <= 20){
    Console.WriteLine("You do not have sufficient privileges\n");
}else{
    Console.WriteLine("You do not have sufficient privileges\n");
}