// Задача 10.
// как я понимаю эту задачу: пользователь вводит любое трехзначное целое число. Если число будет 
// состоять из одинаковых цифр - вывести любую. 

Console.WriteLine("Введите трехзначное число");
int num = Int32.Parse(Console.ReadLine());

int firstMod = num % 100;
int secFig = firstMod / 10;
Console.WriteLine($"Вторая цифра трехзначного числа: {secFig}");

// // Задача 13: Напишите программу, которая выводит третью цифру 
// // заданного числа или сообщает, что третьей цифры нет.
// // я понимаю задачу так: числа генерируются рандомные, интервал от 0 до 10000

Console.WriteLine($"Введите число");
int number = Int32.Parse(Console.ReadLine());
int ThirdDig = 0;

// проверка на однозначные и двузначные значения чисел
if (number < 100 && number > -100) {
    Console.WriteLine("Третьей цифры нет");
}

// цикл для любого значения числа большего чем 999 и меньше, чем -999
while (number > 999 || number < -999) {
    number = number / 10;
}
// Находит третью цифру от 100 до бесконечности
ThirdDig = number % 10;
Console.WriteLine($"Третья цифра данного числа: {ThirdDig}");


// <----------Методы 15-15*---------> 

// проверка вхождения в заданный диапозон
void CheckTheRange(int numb) {
	if (numb > 7 || numb < 1) {
		Console.WriteLine("Такого дня недели нет!");
	}
}

// Проверка дня недели для задачи 15
void CheckDays(int numb) {
	if (numb > 0 && numb < 6) {
		Console.WriteLine("Это будний день");
	} else if (numb > 5 && numb < 8) {
		Console.WriteLine("Это выходной день!!");
	}
}

// проверка дня недели для задачи 15*
void CheckDaysWithThemNames (int numb) {
	if (numb == 1) {
		Console.Write("Это понедельник");
	}
	if (numb == 2) {
		Console.Write("Это вторник");
	}
	if (numb == 3) {
		Console.Write("Это среда");
	}
	if (numb == 4) {
		Console.Write("Это четверг");
	}
	if (numb == 5) {
		Console.Write("Это пятница");
	}
	if (numb == 6) {
		Console.Write("Это суббота");
	}
	if (numb == 7) {
		Console.Write("Это воскресенье");
	}
}
// <------------------->

Console.WriteLine("Введите число от 1 до 7");
int numb = Int32.Parse(Console.ReadLine());

// задача 15
CheckTheRange(numb);
CheckDays(numb);

// Задача 15*
CheckTheRange(numb);
CheckDaysWithThemNames(numb);
