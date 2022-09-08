// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 4

// // Создаем две функции, чтобы задать и вывести М числа 

// int[] CreateM(int M){
//     int[] array = new int[M];
//     Console.WriteLine("Введите искомые числа: ");
//     for(int i=0; i<M; i++){
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowM(int[] array){
//     Console.WriteLine("");
//     for(int i=0; i<array.Length-1; i++){
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"{array[array.Length-1]} ");
// }

// // Создвем функцию для определения чисел, которые больше 0

// void NumbersMoreNull(int[] array){
//     int count=0;
//     for(int i=0; i<array.Length; i++){
//         if(array[i]>0) count+=1;
//     }
//     Console.WriteLine($"Количество чисел, которые больше 0 равно {count}");
// }

// // Вычисления

// Console.Write("Введите количество М чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] array = (CreateM(M));
// ShowM(array);
// Console.WriteLine("");
// NumbersMoreNull(array);

// // Вывод результата на экран


// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// // Создаем функцию void для написания формулы подсчета точки пересечения

// void DotCross(double b1, double k1, double b2, double k2){
//     double x = (b2-b1) / (k1-k2);
//     double y = k1*x + b1;
//     if(k1-k2 == 0) Console.WriteLine("Прямые не пересекаются");                                                   // Учитывая формулу, на ноль делить нельзя
//     else    Console.WriteLine($"Точка пересечения двух прямых равна ({Math.Round (x, 2)};{Math.Round(y,2)})");
// }
   
// // Вычисления
    
// Console.WriteLine("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// DotCross(b1,k1,b2,k2);

// // Вывод результата на экран 

