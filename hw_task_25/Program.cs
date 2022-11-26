// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine ("Программа для расчета результата возведения в степерь(В) числа (А). V 1.0");

Console.WriteLine ("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (x);

Console.WriteLine ("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());

int GetRes(int res)

{
int sum =A;
int count =0;

while(count<B)
{
count++;
sum *=A;

}
return sum;
}

Console.WriteLine(GetRes(A));