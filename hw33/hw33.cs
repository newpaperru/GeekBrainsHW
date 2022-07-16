// задача 19

Console.WriteLine("Введите 5-ти значное число");
int num = Convert.ToInt32(Console.ReadLine());


//последняя цифра числа
int lastDig = num % 10;
// предпоследняя цифра числа
int penDig = num % 100;
int penDigRes = penDig / 10;
// вторая цифра числа
int secDig = num % 10000;
int secDigRes = secDig / 1000;
// первая цифра числа
int firstDig = num / 10000;

if (num > 99999 || num < 10000){
    Console.WriteLine("Введите корректное число");
} else if (firstDig == lastDig && penDigRes == secDigRes) {
    Console.WriteLine("Данное число является палиндромом");
} else {
    Console.WriteLine("Данное число не является палиндромом");
}

// задача 21.
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
double result = 0;

result = Math.Round(Math.Sqrt((Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2)) + Math.Pow(z1 - z, 2)), 2);
Console.WriteLine($"A ({x},{y},{z}); B({x1},{y1},{z1}) -> {result}");
