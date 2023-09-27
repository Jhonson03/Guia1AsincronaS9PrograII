//Ejercicio 4
Console.WriteLine(@"Aplicar las funciones matemáticas vistas en clases para la codificación de un
programa que calcule las raíces de una ecuación de segundo grado utilizando la
fórmula cuadrática. El usuario deberá ingresar los valores de las constantes a, b y c
para resolver las raíces.
");

Console.WriteLine("\nCálculo de raíces de una ecuación de segundo grado (ax^2 + bx + c = 0)");

Console.Write("Ingresa el valor de a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el valor de b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el valor de c: ");
double c = Convert.ToDouble(Console.ReadLine());

double discriminante = Math.Pow(b, 2) - 4 * a * c;

if (discriminante > 0)
{
    double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
    double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
    Console.WriteLine($"Las raíces son: {raiz1} y {raiz2}");
}
else if (discriminante == 0)
{
    double raiz = -b / (2 * a);
    Console.WriteLine($"La raíz doble es: {raiz}");
}
else
{
    double Real = -b / (2 * a);
    double Imaginaria = Math.Sqrt(-discriminante) / (2 * a);
    Console.WriteLine($"Las raíces son complejas: {Real} + {Imaginaria}i y {Real} - {Imaginaria}i");
}