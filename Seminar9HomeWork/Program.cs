// //Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// // M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// // M = 4; N = 8. -> ""4, 6, 7, 8""


// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// //Рекурсия чисел от M до N, где M меньше N
// string NumMN(int numberM, int numberN)
// {
//     //Точка остановки рекурсии
//     if (numberM >= numberN)
//     {
//         return numberN.ToString();
//     }
//     else
//     {
//     //Рекурентный вызов метода    
//         return numberM + ", " + NumMN(numberM + 1, numberN);
//     }
// }

// //Рекурсия чисел от M до N, где M больше N
// string NumMmoreThanN(int numberM, int numberN)
// {
//     //Точка остановки рекурсии
//     if (numberM <= numberN)
//     {
//         return numberN.ToString();
//     }
//     else
//     {
//     //Рекурентный вызов метода    
//         return numberM + ", " + NumMmoreThanN(numberM - 1, numberN);
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int numberM = ReadData("Введите число M:");

// int numberN = ReadData("Введите число N:");

// string res = (numberM < numberN)? NumMN(numberM, numberN) : NumMmoreThanN(numberM, numberN);

// PrintData("Натуральные числа в промежутке от M до N: ", res);


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// //Рекурсия суммы чисел от M до N
// int SumMN(int m, int n)
// {
//     //Точка остановки рекурсии
//     if (m >= n)
//     {
//         return n;
//     }
//     else
//     {
//     //Рекурентный вызов метода    
//         return m + SumMN(m + 1, n);
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int m = ReadData("Введите число M:");

// int n = ReadData("Введите число N:");

// int sum = 0;

// if (m < n)  sum = SumMN(m, n);
// else   sum = SumMN(n, m);

// PrintData("Сумма натуральных чисел от M до N: ", sum.ToString());


// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// // m = 2, n = 3 -> A(m,n) = 29

// //Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// //Рекурсивный метод функции Аккермана
// int Akkerman(int m, int n)
// {
//     //Точка остановки
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     //Рекурентный вызов метода    
//     if (m > 0 && n == 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
// }

// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int m = ReadData("Введите число M:");

// int n = ReadData("Введите число N:");

// int outline = Akkerman(m, n);

// PrintData("Вычисление функции Аккермана: ", outline.ToString());

