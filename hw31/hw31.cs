// задача 2
// Задачу понимаю так: 1) целые числа 2) пользователь вводит числа в терминал 3) Пользователь может ввести как одинаковые числа, так и разные по значению

Console.WriteLine("Введите первое число");
var num1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
var num2 = decimal.Parse(Console.ReadLine());

if (num1 == num2) {
	Console.Write("Числа равны");
} else if (num1 > num2) {
	Console.WriteLine("Большее число: " + num1);
	Console.WriteLine("Меньшее число: " + num2);
} else if (num1 < num2) {
	Console.WriteLine("Большее число: " + num2);
	Console.WriteLine("Меньшее число: " + num1);
}

// задача 4
// Задачу понимаю так: 1) целые числа 2) пользователь вводит числа в терминал 3) Пользователь может ввести как одинаковые числа, так и разные по значению

Console.WriteLine("Введите первое число");
var numb1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
var numb2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
var numb3 = decimal.Parse(Console.ReadLine());
var max = numb1;

if (max < numb2) {
	max = numb2;
}
if (max < numb3) {
	max = numb3;
}
Console.WriteLine("Максимальное число из трех: " + max);

// задача 6
// Задачу понимаю так: 1) целые числа 2) пользователь вводит число в терминал

Console.WriteLine("Введите число");
var num = decimal.Parse(Console.ReadLine());

if (num % 2 == 0) {
	Console.WriteLine("Это число четное");
}
else {
	Console.WriteLine("Это число нечетное");
}

// задача 8
// Задачу понимаю так: 1) целые числа от 1-цы 2) пользователь вводит число в терминал

Console.WriteLine("Введите число");
var number = decimal.Parse(Console.ReadLine());
int count = 1;

Console.Write("Все четные числа до " + number + "(включительно): ");
while (count <= number) {
	if (count % 2 == 0 && !(number==1)) {
		Console.Write(count + " ");
	}
	else if (number == 1) {
		Console.Write("Нет четных чисел");
	}
	count++;
}

