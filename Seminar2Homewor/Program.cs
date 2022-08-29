// //Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// //и на выходе показывает вторую цифру этого числа.

// // Написание функции

// int SecondNumb(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is " + num);
//     int hund = num / 10;
//     int dec = num /100; 
//     int result = hund - (dec * 10);
//     return result;
// }

// // Вычисление 

// int number = SecondNumb();
// Console.WriteLine("Second number is " + number);

// //Вывод на экран


// //Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// //или сообщает, что третьей цифры нет.

// //Написание функции (void - просто отображаем цифру или что ее нет)

// void tnum(int a){
//     int b = 10;
//     int c = b*10;
//     int d = c*10;
//     if(a >= c && a < d) {
//         int dec = a / 1;
//         int ed = a / 10;
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //123
//     } 
//     else if(a >= d && a < (d*b)) {
//         int dec = a / b;
//         int ed = a / c;
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //1234
//     }
//     else if(a >= (d*b) && a < (d*c)) {
//         int dec = a / c;
//         int ed = a / d;
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //12345
//     }
//     else if(a >= (d*c) && a < (d*d)) {
//         int dec = a / d;
//         int ed = a / (d*b);
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //123456
//     }
//     else if(a >= (d*d) && a < (d*d*b)) {
//         int dec = a / (d*b);
//         int ed = a / (d*c);
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //1234567
//     }
//     else if(a >= (d*d*b) && a < (d*d*c)) {
//         int dec = a / (d*c);
//         int ed = a / (d*d);
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //12345678
//     }
//     else if(a >= (d*d*c) && a < (d*d*d)) {
//         int dec = a / (d*d);
//         int ed = a / (d*d*b);
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //123456789
//     }
//     else if(a >= (d*d*d) && a < (d*d*d*b)) {
//         int dec = a / (d*d*b);
//         int ed = a / (d*d*c);
//         int result = dec - (ed*10);
//         Console.WriteLine("Third Number is " + result); //1234567891
//     }
//     else {
//         Console.WriteLine("Третья цифра отсутствует");
//     }
// }

// //Вычисление 

// Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// tnum(number);

// //Вывод данных на экран


// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// // и проверяет, является ли этот день выходным.

// //Написание функции (void используем, так как данные на выходе в дальнейшем не используем) 
// void wekday(int a){
//     if(a >= 6 && a <= 7){
//         Console.WriteLine("Ура, выходной!");
//     }
//     else if(a >= 1 && a <= 5){
//         Console.WriteLine("Сегодня рабочий день!");
//     }
//     else {
//         Console.WriteLine("Введите корректное число");
//     }
// }

// //Вычисление

// Console.WriteLine("Введите день недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// wekday(number);

// //Вывод данных на экран

