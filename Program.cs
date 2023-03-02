// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void Nums (int[] array)
// {
//     int call = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]  % 2 == 0)
//         {
//             call++;
//         }
//     }
//     Console.WriteLine($"из {array.Length} чисел, {call} четных");
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] nums = CreateRandomArray(size, minValue, maxValue);
// ShowArray(nums);
// Nums(nums);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void Nums (int[] array)
// {
//     int call = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             call += array[i];
//         }
//     }
//     Console.WriteLine($"Сумма элементов нечетных позиций = {call}");
// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] nums = CreateRandomArray(size, minValue, maxValue);
// ShowArray(nums);
// Nums(nums);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



// [3 7 22 2 78] -> 76 

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[size];
// FillArrayRandomNumbers(array);
// Console.WriteLine("массив: ");
// PrintArray(array);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//         {
//             max = array[i];
//         }
//     if (array[i] < min)
//         {
//             min = array[i];
//         }
// }
// Console.WriteLine($"-> {max - min}");

// void FillArrayRandomNumbers(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         {
//             array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] array)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write(array[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }
