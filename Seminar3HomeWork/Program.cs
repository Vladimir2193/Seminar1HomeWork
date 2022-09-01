// // Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// // и проверяет, является ли оно палиндромом.

// //Создаем функцию void для проверки является ли пятизначное число палиндромом

// void Equal(int a){
//     int last = a % 10;
//     int first = a / 10000;
//     int secondnumb = (a / 1000) - ((a / 10000) * 10);
//     int lastbutone = (a / 10) % 10;
//     if(a >= 0) {
//         if (first == last && secondnumb == lastbutone) Console.WriteLine("Заданное число - палиндром");
//         else Console.WriteLine("Число не является палиндромом пятизначного числа");
//     }
//     else Console.WriteLine("Отрицательное число не может быть палиндромом");
// }

// //Вычисление 

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// Equal(number);

// //Вывод результата на экран 


// // Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// // и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

// //Создаем возвращаемую функцию (скорее всего, полученное значение будет использовано)

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2){
//     int ax = x2 - x1;
//     int by = y2 - y1;
//     int cz = z2 - z1;
//     double result = Math.Sqrt((ax * ax) + (by * by) + (cz*cz));
//     return result;
// }

// //Создаем переменную finalresult, в которой будут отображены введенные нами координаты двух точек
// //(в данном случае как в примере)

// double finalresult = Distance(3,6,8,2,1,-7);
// Console.WriteLine($"Расстояние между точками А и B равно {Math.Round(finalresult, 2)}");

// // //Выводим итоговое значение на экран 


// // Задача 23 Напишите программу, которая принимает на вход число (N) 
// // и выдаёт таблицу кубов чисел от 1 до N.

// // Создаем функцию void (так как итоговые значения дальше не используем)

// void Cube(int n){
//     int index = 1;
//     int result = 1;
//     if(n>0){
//     while(index<=n){
//         result = index * index * index;
//         index++;
//         Console.Write(result + " ");
//     }
//     }
//     else {
//     while(index>=n){                        // отрицательные числа также возводятся в куб
//         result = index * index * index;
//         index--;
//         Console.Write(result + " ");
//     }
//     }
// }

// //Вычисление 

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Cube(num);

// //Вывод на экран итогового значения 

