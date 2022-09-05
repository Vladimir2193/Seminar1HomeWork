// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// // возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16

// //Создаем функцию void (рассчеты впоследствии не используем)

// void Expon(int a, int b){
//     int result = 1;
//     if(a == 0) result = 1;
//     else {
//     for (int curr=0; curr != b; curr++){
//         result = result * (a/a) * a;
//     }
//     }
//     Console.WriteLine(" ");
//     Console.WriteLine($"Возведение числа {a} в степень {b} равна {result}");
// }

// // Вычисление 

// Console.WriteLine("Введите числа А и B: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Expon(a,b);

// // Вывод результата на экран


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12

// // Создаем функцию void 

// void SumNumbers(int a){
//     int result = 0;
//     int resultN = 0;
//     int resultNfinal = 0;
//     if(a>0){
//         for(int curr = a; curr != 0; curr/=10){
//         result = result + (curr%10);
//     }
//     Console.WriteLine($"Сумма цифр в числе {a} равна {result}");
//     }
//     else {
//         for(int index=a; index !=0; index/=10){         //цикл для поиска первого отрицательного числа
//             resultN = index * 2;
//         }
//         for(int curr = a; curr != 0; curr/=10){
//         result = result + (curr%10);                    //цикл положительного числа 
//         }
//         resultNfinal = resultN - result;                
//         Console.WriteLine($"Сумма цифр в числе {a} равна {resultNfinal}"); 
//     }
// }

// // Вычисление

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumbers(num);

// // Вывод результата на экран


// // Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]

// // Задаем массив, создавая возвращаемую функцию

// int[] CreateArray(int size){
//     int[] array = new int[size];
//     for(int i=0; i <size; i++){
//         Console.Write($"Введите элемент с индексом {i}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // Создаем функцию для отображения полученного ранее массива

// void ShowArray(int[] array){
//     Console.Write("[ ");
//     for(int i=0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }

// // Вычисление 

// Console.Write("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = (CreateArray(size));
// ShowArray(array);

// // Вывод массива на экран

