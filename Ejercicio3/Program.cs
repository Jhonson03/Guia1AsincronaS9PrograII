//Ejercicio 3

Console.WriteLine(@"Realice un programa que calcule la suma acumulada 
de los cuadrados de los primeros 20 dígitos.

Ejemplo suma = (1x1) + (2x2) + (3x3) + .. (18*18) + (19x19) + (20*20)");


var Num = Enumerable.Range(1, 20);

double Sum = Num.Sum(Num => Math.Pow(Num, 2));

Console.WriteLine($"\nLa suma acumulada de los cuadrados de los primeros 20 números es: {Sum}");