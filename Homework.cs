// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// System.Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int SecondDigit (int eNum)
// {
//     int result = eNum / 10 % 10;
//     return result;
// }

// System.Console.WriteLine($"Вторая цифра числа {num} - {SecondDigit(num)}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// System.Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// int ThreeDigit (int num) {
//         while (num > 999) {
//             num /= 10;
//     }
//         return num % 10;
// }

// if (n >=100) {
//     System.Console.WriteLine($"{n} -> {ThreeDigit(n)}");
// } else Console.WriteLine($"{n} не имеет третьей цифры");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// System.Console.WriteLine("Введите номер дня недели");
// int num = Convert.ToInt32(Console.ReadLine());

// bool Week (int num) {
//     if (num == 6 || num == 7) return true;
//     else return false;
// }

// System.Console.WriteLine($"{num} -> {Week(num)}");