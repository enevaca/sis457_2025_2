using DemoConsola;
// Esto es un comentario en una sola línea
/* Esto es un comentario 
 * de múltiples líneas
 */

// Variables

var variable = "Cualquier valor";
bool esActivo = false;
short enteroCorto = 9;
int entero = 98;
long enteroLargo = 12345678905466;
double real = 3.1416;
decimal real2 = 3.1416m;
float real3 = 3.1416f;
char caracter = 'A';
string cadena = "Esto es una cadena";
Int16 enteroCorto2 = 10; // short
Int32 entero2 = 100; // int
Int64 enteroLargo2 = 12345678901234; // long
DateTime fecha = DateTime.Now;
DateTime fecha2 = new DateTime(2025, 8, 23);

// Constantes
const double PI = 3.1416;
const string SIGLA_MATERIA = "SIS457";

// Operadores y expresiones
entero = 45;
entero2 += 5;
entero2 %= 2;
bool esPar = entero % 2 == 0;
int a = 6 + 7 * 2;
int b = (6 + 7) * 2;
b++;

// Conversiones y cadenas
string conversionCadena = real.ToString();
string conversionCadena2 = Convert.ToString(real2);
int conversionEntero = int.Parse("12345");
int conversionEntero2 = Convert.ToInt32("54321");
bool conversionBooleano = bool.Parse("true");
bool conversionBooleano2 = Convert.ToBoolean("false");

string materia = "Fundamentos de la Programación";
string concatenar = SIGLA_MATERIA + " - " + materia;
string concatenar2 = $"{SIGLA_MATERIA} - ${materia}";
string minusculas = materia.ToLower();
string mayusculas = materia.ToUpper();
string remplazo = materia.Replace(" ", "%");
string subcadena = materia.Substring(5, 8);
string quitarEspaciosExtremos = $"      {materia}    ".Trim();
int longitudCadena = materia.Length;
string invertirCadena = new string(materia.Reverse().ToArray());
string[] separar = materia.Split(" ");

// Estructuras de control
bool esMayorCero;
if (cadena.Length > 0) esMayorCero = true;
else esMayorCero = false;
bool esMayorCero2 = cadena.Length > 0 ? true : false;
bool esMayorCero3 = cadena.Length > 0;

switch (materia)
{
    case "Informática": materia += "Info"; break;
    default: materia = materia.ToUpper(); break;
}

int contador = 0;
while (contador < 3) { 
    Console.WriteLine($"Contador while: {contador}");
    contador++;
}

do { 
    Console.WriteLine($"Contador do-while: {contador}");
    contador--;
} while (contador > 0);

for (int i = 0; i < separar.Length; i++) {
    Console.WriteLine($"Ciclo for -> Posición {i}: {separar[i]}");
}

foreach (string palabra in separar) {
    Console.WriteLine($"Ciclo foreach: {palabra}");
}

// Métodos
void saludar(string nombre) 
{
    Console.WriteLine($"Hola {nombre}");
}
saludar("Juan");

string revertirCadena(string cadena) 
{
    return new string(cadena.Reverse().ToArray());
}
string revertirCadena2(string cadena) => new string(cadena.Reverse().ToArray());

Console.WriteLine(revertirCadena2("Hola Mundo"));

int sumar(int numero1, int numero2) => numero1 + numero2;

long factorial(int numero) {
    long factorial = 1;
    for (int i = 2; i <= Math.Abs(numero); i++) factorial *= i;
    if (numero < 0) factorial *= -1;
    return factorial;
}

Console.Write("Ingrese un número para obtener los primieros N factoriales: ");
int numero = 1; //int.Parse(Console.ReadLine());
for (int i = 1; i <= numero; i++)
{
    Console.WriteLine($"El factorial de {i} es {factorial(i)}");
}

Console.WriteLine(materia);

// POO
Persona persona = new Persona();
persona.cedulaIdentidad = "123456";
persona.nombres = "Juan";
persona.primerApellido = "Pérez";
persona.segundoApellido = "López";
persona.fechaNacimiento = new DateOnly(2000, 8, 30);
persona.celular = 71717171;
persona.saludar();
Console.WriteLine($"Edad: {persona.calcularEdad()}");

Estudiante estudiante = new Estudiante();
estudiante.cedulaIdentidad = "654321";
estudiante.carnetUniversitario = "26-1234";
estudiante.nombres = "María";
estudiante.primerApellido = "Gómez";
estudiante.segundoApellido = "Rodríguez";
estudiante.fechaNacimiento = new DateOnly(2009, 5, 15);
estudiante.celular = 72727272;
estudiante.saludar();

int cantidadEstudiantes = 2;
List<Estudiante> estudiantes = new List<Estudiante>();
for (int i = 1; i <= cantidadEstudiantes; i++)
{
    var itemEstudiante = new Estudiante();
    Console.Write($"Ingrese el Nombre del estudiante {i}: ");
    itemEstudiante.nombres = Console.ReadLine() ?? "";

    Console.Write($"Ingrese el Primer Apellido del estudiante {i}: ");
    itemEstudiante.primerApellido = Console.ReadLine() ?? "";

    Console.Write($"Ingrese el Carnet Universitario del estudiante {i}: ");
    itemEstudiante.carnetUniversitario = Console.ReadLine() ?? "";

    estudiantes.Add(itemEstudiante);
}

foreach (var itemEstudiante in estudiantes) 
{
    itemEstudiante.saludar();
}
