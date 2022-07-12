// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите 1е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = (number1 % number2);

if (sum != 0) Console.WriteLine($"Не кратно, остаток {sum}");
if (sum == 0) Console.WriteLine($"Кратно, остаток {sum}");




// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum1 = number % 7;
int sum2 = number % 23;

if (sum1 == 0 && sum2 == 0) Console.WriteLine($"{number}, Да");
if (sum1 != 0 || sum2 != 0) Console.WriteLine($"{number}, Нет");