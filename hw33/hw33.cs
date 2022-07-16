// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-ти значное число");
int num = Convert.ToInt32(Console.ReadLine());


// // // последняя цифра числа
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