using DemoBiblioteca;
using DemoConsolaAvanzado;

// Biblioteca de Clases
int suma = Calculadora.sumar(10, 30);
int resta = Calculadora.restar(20, 14);
int mult = Calculadora.multplicar(6, 9);
int division = Calculadora.dividir(10, 4);
int modulo = Calculadora.modulo(10, 4);
Console.WriteLine($"Suma: {suma}, Resta: {resta}, Multiplicación: {mult}, División: {division}");

// Delegados
static string revertirCadena(string cadena)
{
    return new string(cadena.Reverse().ToArray());
}
Revertir revertir = revertirCadena;
Console.WriteLine(revertir("Hola Delegado"));

void imprimir(string cadena)
{
    Console.WriteLine($"Delegado Action: {cadena}");
}
Action<string> imp = imprimir;
imp("Fundamentos de la Programación");

Func<int, int, int> multiplicacion = (v1, v2) => v1 * v2;
int valor = multiplicacion(7, 5);
Console.WriteLine($"Func. El resultado es {valor}");

Predicate<int> mayorDeEdad = e => e >= 18;
bool esMayorEdad = mayorDeEdad(21);
Console.WriteLine($"Predicate. Mayor de Edad: {(esMayorEdad ? "SI" : "NO")}");

// Genéricos
Generico<int, string, Automovil> generico = new Generico<int, string, Automovil>();
generico.campo1 = 25;
generico.campo2 = "Cadena en genérico";
generico.campo3 = new Automovil();
generico.imprimir(6);
generico.campo3.acelerar(5);

// Interfaces
// IVehiculo vehiculo = new IVehiculo(); // No se puede instanciar
Automovil auto = new Automovil();
auto.acelerar(100);
auto.frenar();
auto.girar(15);

// Clases Abstractas
// FiguraGeometrica figura = new FiguraGeometrica(); // No se puede instanciar
Cuadrado cuadrado = new Cuadrado(5);
Console.WriteLine($"Área del cuadrado: {cuadrado.area()}");
Console.WriteLine($"Perímetro del cuadrado: {cuadrado.perimetro()}");

FiguraGeometrica rectangulo = new Rectangulo(10, 6);
Console.WriteLine($"Área del rectángulo: {rectangulo.area()}");
Console.WriteLine($"Périmetro del rectángulo: {rectangulo.perimetro()}");

// Manejo de Excepciones (try/catch/finally)
int dividendo, divisor, resultado;
try
{
    Console.WriteLine("Introduzca el dividendo: ");
    dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Introduzca el divisor: ");
    divisor = Convert.ToInt32(Console.ReadLine());

    resultado = dividendo / divisor;
    Console.WriteLine($"El resultado es: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por cero");
}
catch (Exception ex)
{
    Console.WriteLine($"Error en la división: {ex.Message}");
}
finally
{
    resultado = 0;
    Console.WriteLine("Finalizado");
}

// Programación Asíncrona
testAsyncAwaitMethod();
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();

static async void testAsyncAwaitMethod()
{
    await longRunningMethod();
}

static async Task<int> longRunningMethod()
{
    Console.WriteLine("Iniciando tarea de larga duración...");
    await Task.Delay(15000); // Esperar 5 segundos
    Console.WriteLine("Fin de la tarea de larga duración.");
    return 0;
}

// Inmutabilidad
Inmutable inmutable = new Inmutable(10);
