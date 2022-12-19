// Задача No12. 
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Enter the first number: ");

int N1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the second number: ");
int N2 = int.Parse(Console.ReadLine()!);
int ost;

if(N1%N2 == 0)
{
    Console.Write($"Числло {N1} кратно {N2} ");
}
else
{
    ost = N1%N2;
    Console.Write("Остаток от деления: " + ost);
}
 