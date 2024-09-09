Console.WriteLine("Hola Mundo");
//Console.WriteLine(); sirve para imprimir un mensaje en el CMD
Console.ReadLine();
//Console.ReadLine(); puede servir para escribir en el CMD
///////////////////////////////////////////////////////////////

//Tipos de datos

int a = 0;
//Los INT pueden ser usados para almacenar numeros.
short b = 0;
//los SHORT son como los INT pero almacenan numeros mas pequeños, esto sirve para la optimizacion en la aplicacion.
long c = 0;
//en los LONG se pueden almacenar numeros mucho mas grandes.
double d = 1.4;
//los DOUBLE sirven para almacenar numeros con comas

string saludo = "Hola Mundo";
//Los string sirven para almacenar caracteres, SON caracteres.
//////////////////////////////////////////////

//Vamos a usar todo lo aprendido para hacer una aplicación.

Console.WriteLine("Ingrese su nombre");
string? nombre = Console.ReadLine();
Console.WriteLine($"Bienvenido {nombre}");
//En este caso use $ para fusionar un mensaje con el string
/////////////////////////////////////////////////////////////

//Nuevas clases proximamentess