/*
//Задача 2: 
//Напишите программу, которая на вход принимает два числа и 
//выдаёт, какое число большее, а какое меньшее.

int num1;
int num2;

//Ввод данных

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

// Вычисление (Сначала проверка условия, что числа неравны)

if(num1 != num2) {
    if(num1 > num2){
    Console.WriteLine("Наибольшее число: " + num1);
    Console.WriteLine("Наименьшее число: " + num2);
    }
    else {
    Console.WriteLine("Наибольшее число: " + num2);
    Console.WriteLine("Наименьшее число: " + num1);
    }
}
else {
    Console.WriteLine("Числа равны");
}

//Вывод ответа на экран


//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

int num1;
int num2;
int num3;

//Ввод данных

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

// Вычисление

int max = 0;

if(num1 > max) max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine("Максимальное число: " + max);

//Вывод значения на экран


//Задача 6: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num1;

//Ввод данных 

Console.WriteLine("Введите число: ");
num1 = Convert.ToInt32(Console.ReadLine());

//Вычисление

if(num1 %2 == 0) {
    Console.WriteLine("Четное число");
}
else {
    Console.WriteLine("Нечетное число");
}

//Вывод данных 


//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

int N;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

//Ввод данных

int current = 1;

//Вычисление (Сначала проверка числа N(положительное или отрицательное), а потом цикл)

if(N > 0) {
    while(current <= N) {
        if(current %2 == 0) { 
        Console.Write(current + " ");
        };
        current++;
    }
}
else {
    while(current >= N){
        if(current %2 == 0) { 
        Console.Write(current + " ");
        };
        current = current - 1;
    }
}

//Вывод данных на экран
*/

