// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//  int[] arr = new int[12];
//  int k = 0;
//  Random rnd = new Random();
 
//  Console.WriteLine("Исходный массив");
//  for (int i = 0; i < 12; i++)
//  {
//     arr[i] = rnd.Next(-100, 999);
//     Console.Write("{0} ", arr[i]);
//  }
 
// foreach(int element in arr)
// {
//     Console.Write("{0} ", element);
//     if (element % 2 == 0)
//     {
//         k++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Количество четных элементов {0}", k);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] arr = new int[4];
// int sum = 0;
// Random rnd = new Random();
 
// Console.WriteLine("Исходный массив");
// for (int i = 0; i < 4; i++)
// {
//     arr[i] = rnd.Next(-10, 99);
//     Console.Write("{0} ", arr[i]);
// }
// foreach(int element in arr)
// {
//     Console.Write("{0} ", element);
//     if (element % 2 == 0)
//        {
//         sum += element;
//     }
// }
// Console.WriteLine();
// Console.WriteLine("сумма четных элементов {0}", sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 class Program
// class program
// {
// static void Main(string[] args)
// {
//    Random rnd = new Random();
//    int[] d = new int[30];
//    int max=0, min=100;
//    for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
//    for (int i = 0; i < d.Length; i++)
//    {
//         if (d[i] > max) max = d[i];
//         if (d[i] < min) min = d[i];
//    }
           
//    for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
//    Console.WriteLine();
//    Console.WriteLine("max:  " + max);
//    Console.WriteLine("min  " +min);
//    Console.WriteLine("Разница максимального и минимального:  "+(max - min));
//    Console.ReadKey();
// }
// }
