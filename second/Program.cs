// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да #
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// int a = 25,
//     b = 5,
//     sum_b = 0;

// sum_b = b * b;

// if a == sum_b {
//     Console.WriteLine("Yes");
// } else {
//     Console.WriteLine("No");
// }

// Console.WriteLine();


// int a = Console.WriteLine("Введите число: ");
// int b = Console.WriteLine("Введите число: ");
// int sum_b = b * b;

// if sum_b == a {
//     Console.WriteLine("Yes");
// } else {
//     Console.WriteLine("No");
// }

Console.WriteLine("Введите целое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = Convert.ToInt32(Console.ReadLine());

int result = number_1 / number_2;
if(result == number_2)
Console.WriteLine("Yes");
else Console.WriteLine("No");