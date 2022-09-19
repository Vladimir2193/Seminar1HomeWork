// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// // За счет двух функций заполняем массив

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

// // Создаем возвращаемую функцию, в которой элементы массива будут сортироваться от большего к меньшему 
// // Добавляем еще один внутренний цикл по столбцам

// int[,] FromMaxToMin(int[,] array){
//     int temp =0;
//     for(int i =0; i<array.GetLength(0); i++)
//         for(int l=0; l<array.GetLength(1);l++)
//             for(int j=0; j<array.GetLength(1)-1;j++)
//                 if (array[i,j] < array[i,j+1]){
//                 temp = array[i,j+1];
//                 array[i,j+1] = array[i,j];
//                 array[i,j] = temp;      
//             }
//     return array;
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
// int[,] array2 = FromMaxToMin(array);
// Show2dArray(array2);

// // Вывод результата на экран


// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// // Например, задан массив:

// // 1 4 7 2

// // 5 9 2 3

// // 8 4 2 4

// // 5 2 6 7


// // За счет двух функций заполняем массив

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

// // Создаем невозвращаемую функцию, которая будет считать сумму строк и показывать минимальную сумму среди строк заданного массива  

// void MinSum(int[,] array){
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//       {
//         minsum = minsum + array[0,i];
//         row = 0;
//       }
//     Console.WriteLine($"сумма по строкe 0 равна {minsum}");
    
// // За счет первого цикла по 0 строке задаем минимальную сумму, с которой будет сравнивать другие строки в следующем цикле

//     for(int i = 1; i<array.GetLength(0); i++){
//         int sum = 0;
//         for(int j=0; j<array.GetLength(1); j++){
//             sum += array[i,j];
//             }
//             Console.WriteLine($"сумма по строкe {i} равна {sum}");
//             if(minsum > sum){
//             minsum = sum;
//             row = i;
//             }
//         }
//         Console.WriteLine($" Минимальная сумма по строкe {row} равна {minsum}");
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
// MinSum(array);

// // Вывод результата на экран


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// // В функции,в которой создаем массив указываем порядок заполнения (сначала по внешнему периметру, а потом по внутреннему)  

// int[,] CreateRandom2dArray(int rows,int cols){
//     int[,] array = new int[rows,cols];
//     int number = 1;
//     for(int i=0; i<rows; i++){
//         for(int j=i; j<cols - i; j++)         array[i,j] = number++;
//         for(int k = i + 1; k<rows-i; k++)     array[k,cols-1-i] = number++;
//         for(int l = cols - i - 2; l>=i; l--)  array[rows-1-i,l] = number++;
//         for(int m = rows - 2 - i; m>i; m--)   array[m,i] = number++;
//     }

//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j] + "\t");
//         }
//     }
// }

// // Вычисления 

// int[,] array = CreateRandom2dArray(4,4);
// Show2dArray(array);

// // Вывод массива на экран

