// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите день недели в цифре: ");
int day_week = Convert.ToInt32(Console.ReadLine());

if (day_week == 1) {
    Console.WriteLine("Понедельник");
} else if (day_week == 2) {
Console.WriteLine("Вторник");
} else if (day_week == 3) {
Console.WriteLine("Среда");
} else if (day_week == 4) {
Console.WriteLine("Четверг");
} else if (day_week == 5) {
Console.WriteLine("Пятница");
} else if (day_week == 6) {
Console.WriteLine("Суббота");
} else if (day_week == 7) {
Console.WriteLine("Воскресенье");
} else {
    Console.WriteLine("Ошибка");
}