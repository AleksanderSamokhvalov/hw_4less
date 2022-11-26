// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine ("Программа для вывода суммы каждого элемента в (А). V 1.0");

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());

int summ = 0;

while (A>0)
{
    summ = summ +A%10;
    A = A/10;
}

Console.WriteLine("Сумма элементов числа " + summ);



