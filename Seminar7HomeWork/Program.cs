﻿// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// // Используем две функции для формирования двумерного массива и его заполнения.
// // Для заполнения массива случайными вещесственными числами нужного диапазона используем NextDouble()

// double[,] CreateRandom2dArray(int rows,int cols){
//     double[,] array = new double[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//             array[i,j] = new Random().NextDouble() * 20 - 10;
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(Math.Round(array[i,j],1) + " ");
//         }
//     }
// }

// // Вычисления 

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// // Console.Write("Input numb of min: ");
// // double min = Convert.ToDouble(Console.ReadLine());
// // Console.Write("Input numb of max: ");
// // int max = Convert.ToDouble(Console.ReadLine());

// double[,] array = CreateRandom2dArray(rows,cols);
// Show2dArray(array);

// // Вывод результата на экран 


// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // 1,7 -> такого числа в массиве нет
// // 1,2 -> 2

// // Используем две функции для формирования двумерного массива и его заполнения.

// int[,] CreateRandom2dArray(int rows,int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//             array[i,j] = new Random().Next(min,max);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// // Создаем функцию void для поиска нужного элемента или уточнение отсутствия элемента в данном массиве

// void EssenceNumbers(int[,] array, int k, int l){
//     if(k<array.GetLength(0) && l<array.GetLength(1)) Console.WriteLine ($"Искомое число {array[k,l]}");
//     else Console.WriteLine("Такого числа нет в массиве");
// }

// // Вычисления

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.Write("Input index of rows: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input index of cols: ");
// int l = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// EssenceNumbers(array, k, l);

// // Вывод результата на экран


// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// // Задаем двумерный массив 

// int[,] CreateRandom2dArray(int rows,int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j=0; j<cols; j++)
//             array[i,j] = new Random().Next(min,max);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     }
// }

// // Создаем функцию void для вывода среднего арифметического по столбцам 

// void AverageSum(int[,] array){
//     double count = 0;
//     double sum = 0;
//     double averageSum = 0;
//     for(int j=0; j<array.GetLength(1);j++){
//         for(int i=0; i<array.GetLength(0);i++){
//             count = array.GetLength(0);
//             sum = sum + array[i,j];
//         }
//     averageSum = (sum / count);
//     Console.WriteLine($"average sum column of index [{j}] is {averageSum}"); 
//     sum-=sum;
//     };

// }

// // Вычисления

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// Console.WriteLine();
// AverageSum(array);

// // Вывод результата на экран

