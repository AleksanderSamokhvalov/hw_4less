// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine ("Программа для вывода массива, количество элесентов которого равно (А). V 1.0");

Console.WriteLine ("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

int [] array = new int [A];
GetArray(array);

int [] GetArray(int [] array)

{

for (int i = 0; i <array.Length; i++)
{
array[i] = new Random().Next(0,99);
}

return array;
}

Console.Write(String.Join(",", array));

