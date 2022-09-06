// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// // Задаем массив и его отображаем путем создания двух функций

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for(int i=0; i <size; i++){
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// // Создаем функцию для посчета количества четных чисел массива

// void ShowEven(int[] array){
//     int current = 0;
//     for(int i=0; i<array.Length; i++){
//         if(array[i] %2 == 0){
//             current=current + 1;
//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Количество четных чисел в масиве равно {current}");
// }

// // Вычисление

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[]array = CreateArray(size);
// ShowArray(array);
// ShowEven(array);

// // Вывод результата на экран


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.

// // [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

// // Задаем массив и его отображаем путем создания двух функций

// int[] CreateArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i=0; i <size; i++){
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// // Создаем функцию void для подсчета суммы элементов с нечетным индексом

// void SumEvenIndex(int[] array){
//     int result = 0;
//     for(int i = 1; i<array.Length;i= i+2){
//         result += array[i];
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {result}");
// }

// // Вычисление 

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[]array = CreateArray(size, min, max);
// ShowArray(array);
// SumEvenIndex(array);

// // Вывод результата на экран 


// // Задача 38: Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.

// // [3 7 22 2 78] -> 76

// // Задаем массив за счет создания двух функций

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for(int i=0; i <size; i++){
//         array[i] = new Random().Next(-999999,1000000);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// // Создаем функцию void для определения разницы максимального и минимального элементов массива

// void DiffMaxMin(int[] array){
//     int min = array[0];
//     int max = array[0];
//     int result = 0;
//     for(int i = 0; i<array.Length; i++){
//         if(array[i] < min) min = array[i];
//         if(array[i]> max) max = array[i];
//         result = max - min;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равна {result}");
// }

// // Вычисление 

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[]array = CreateArray(size);
// ShowArray(array);
// DiffMaxMin(array);

// // Выводим результат на экран

