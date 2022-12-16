// Задача 11
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
 
int num = new Random().Next(100, 1000);

 Console.WriteLine("any random number by comp: " + num);

int a1 = num/10;
int a11 = a1/10;

int a3 = num%10;
int a2 = a1%10;
int num1 = 10* a11 + a3;

// Console.WriteLine("random number:" + a1);
// Console.WriteLine("second number:" + a2);
// Console.WriteLine("third number:" + a3);
Console.WriteLine("the end:" + num1);
