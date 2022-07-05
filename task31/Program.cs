// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
// int[] arr = new int[12];
// int sum_p = 0;
// int sum_n = 0;

// Console.Write("[");
// for (int i  = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(-9,10); // [-9, 9]
//     Console.Write($"{arr[i]} ");
//     if (arr[i] > 0) //positive number
//     {
//         sum_p = sum_p + arr[i]; // ==sum_p += arr[i]
//     }
//     if (arr[i] < 0) // negative number
//     {
//         sum_n = sum_n + arr[i];
//     }
// }
// Console.WriteLine("]");

// Console.WriteLine($"сумма положительных чисел массива {sum_p}");

// Console.WriteLine($"сумма отрицательных чисел массива {sum_n}");

//Напишите программу замена элементов массива: положительные элементы замените на соотвествуюшие отрицательные, и наоборот
// int[] arr = new int[12];
// Console.WriteLine("Массив с исходными знаками ");
// for (int i = 0; i< arr.Length; i++){
//     arr[i] = new Random().Next(-9, 10); // [-9 9]
//     Console.Write($" {arr[i]}");
// }
// Console.WriteLine("\nНовый массив с новыми знаками ");
// for (int i = 0; i < arr.Length; i++){
//     arr [i] = arr [i] * -1;
//     Console.Write($" {arr[i]}");
// }

//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
// int[] arr = new int[7];
// Console.WriteLine("Задайте массив ");
// for (int i = 0; i < arr.Length; i++){
//     arr[i] = int.Parse(Console.ReadLine());
// }
// Console.Write("Введите число ");
// int A = int.Parse(Console.ReadLine());
// bool ishere = false;
// for (int i = 0; i < arr.Length; i++){
//     if (arr[i] == A)
//     {
//         ishere = true;
//     }
// }
// if (ishere == true) {
//     Console.WriteLine("yes");
// }
// else {
//     Console.WriteLine("no");
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// int[] arr = new int[6];
// int sum = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(0, 301); // [0, 300]
//     Console.WriteLine(arr[i]); 
//     if (arr[i] >= 10 && arr[i] <= 99)
//     {
//         sum++;
//     }
// }
// Console.WriteLine($"Количество чисел лежащих в отрезке [10, 99] = {sum}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

