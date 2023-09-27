//Ejercicio 1

Console.WriteLine(@"Utilizando la constante matemática de PI: Math.PI utilizar ese valor para hacer los
siguientes cálculos utilizando las funciones en C# y mostrarlas en consola.
1- Truncar el valor de PI
2- Redondear hacia arriba
3- Redondear hacia abajo");

double Pi = Math.PI;

Console.WriteLine($"\nValor de PI truncado: {Math.Truncate(Pi)}");

Console.WriteLine($"Valor de PI redondeado hacia arriba: {Math.Ceiling(Pi)}");

Console.WriteLine($"Valor de PI redondeado hacia abajo: {Math.Floor(Pi)}");