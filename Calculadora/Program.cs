//Consiga: Crear un Programa de Consola que pueda SUMAR, RESTAR, MULTIPLICAR, DIVIDIR Y sacar el RESTO. Usando C#

//INTRODUCCIÓN
var bienvenida = "Este Programa de Consola es una Calculadora, puede SUMAR, RESTAR, MULTIPLICAR, DIVIDIR Y encontrar el RESTO!";
var autor = "Programa creado por : Fabricio Santillán Luis Alejandro.";
var cont = "¡Presione cualquier tecla para Avanzar!";
Console.WriteLine(bienvenida + "\n" + "\n" + autor + "\n" + "\n" + cont);
Console.ReadKey();
Console.Clear();


//SUMA
int numeroSuma1;
Console.WriteLine("Ingrese el PRIMER número para SUMAR" + "\n");
numeroSuma1 = int.Parse(Console.ReadLine());
Console.Clear();
int numeroSuma2;
Console.WriteLine("Ingrese el SEGUNDO número para SUMAR" + "\n");
numeroSuma2 = int.Parse(Console.ReadLine());
Console.Clear();    
var suma = numeroSuma1 + numeroSuma2;
Console.WriteLine("El resultado de la SUMA es:" + "\n" + "\n" + suma + "\n" + "\n" + "Presionar cualquier tecla para continuar");
Console.ReadKey();
Console.Clear();

//RESTA
int numeroResta1;
Console.WriteLine("Ingrese el PRIMER número para RESTAR" + "\n");
numeroResta1 = int.Parse(Console.ReadLine());
Console.Clear();

int numeroResta2;
Console.WriteLine("Ingrese el SEGUNDO número para RESTAR" + "\n");
numeroResta2 = int.Parse(Console.ReadLine());
Console.Clear();

var resta = numeroResta1 - numeroResta2;
Console.WriteLine("El resultado de la RESTA es:" + "\n" + "\n" + resta + "\n" + "\n" + "Presionar cualquier tecla para continuar" + "\n");
Console.ReadKey();
Console.Clear();

//MULTIPLICACIÓN
int numeroMulti1;
Console.WriteLine("Ingrese el PRIMER número para MULTIPLICAR" + "\n");
numeroMulti1 = int.Parse(Console.ReadLine());
Console.Clear();

int numeroMulti2;
Console.WriteLine("Ingrese el SEGUNDO número para MULTIPLICAR" + "\n");
numeroMulti2 = int.Parse(Console.ReadLine());
Console.Clear();

var multi = numeroMulti1 * numeroMulti2;
Console.WriteLine("El resultado de la MULTIPLICACIÓN es:" + "\n" + "\n" + multi + "\n" + "\n" + "Presionar cualquier tecla para continuar");
Console.ReadKey();
Console.Clear();

//DIVISIÓN
int numeroDivi1;
Console.WriteLine("Ingrese el PRIMER número para DIVIDIR" + "\n");
numeroDivi1 = int.Parse(Console.ReadLine());
Console.Clear();

int numeroDivi2;
Console.WriteLine("Ingrese el SEGUNDO número para DIVIDIR" + "\n");
numeroDivi2 = int.Parse(Console.ReadLine());
Console.Clear();

var divi = numeroDivi1 / numeroDivi2;
Console.WriteLine("El resultado de la DIVISIÓN es:" + "\n" + "\n" + divi + "\n" + "\n" + "Presionar cualquier tecla para continuar");
Console.ReadKey();
Console.Clear();

//RESTO
int numeroResto1;
Console.WriteLine("Ingrese el PRIMER número para sacar el RESTO" + "\n");
numeroResto1 = int.Parse(Console.ReadLine());
Console.Clear();

int numeroResto2;
Console.WriteLine("Ingrese el SEGUNDO número para sacar el RESTO" + "\n");
numeroResto2 = int.Parse(Console.ReadLine());
Console.Clear();

var resto = numeroResto1 % numeroResto2;
Console.WriteLine("El RESTO es:" + "\n" + "\n" + resto + "\n" + "\n" + "Presionar cualquier tecla para finalizar");
Console.ReadKey();
Console.Clear();

var thx = "GRACIAS POR USARME :)";
Console.WriteLine(thx);