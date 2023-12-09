// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// void RandMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void FindCell(int[,] matrix)
// {
//     Console.Write("Введите координаты элемента от 0 до 9: ");
//     int[] coords = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     if(coords[0] >= matrix.GetLength(0) || coords[1] >= matrix.GetLength(1)){
//         Console.WriteLine("Элемент не обнаружен. Повторите попытку");
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == coords[0] && j == coords[1])
//             {
//                 Console.WriteLine(matrix[i, j]);
//                 break;
//             }
//         }
//     }
// }

// Console.Clear();
// int x = new Random().Next(3, 10);
// int y = new Random().Next(3, 10);
// int[,] matrix = new int[x, y];
// RandMatrix(matrix);
// PrintMatrix(matrix);
// FindCell(matrix);


// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void SumRows(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == 0)
//             {
//                 int y = matrix[matrix.GetLength(0) - 1, j];
//                 matrix[matrix.GetLength(0) - 1, j] = matrix[i, j];
//                 matrix[i, j] = y;
//             }
//         }
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];

// InputMatrix(matrix);
// PrintMatrix(matrix);
// SumRows(matrix);
// PrintMatrix(matrix);


// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11);
//         }
//     }
// }

// void SumRows(int[,] matrix)
// {
//     int[] array = new int[matrix.GetLength(0)];
//     int sum = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         array[i] = sum;
//     }
//     int min = array[0];
//     for (int l = 1; l < array.Length; l++)
//     {
//         if(array[l] < array[l-1]){
//             min = l;
//         }
//     }
//     Console.WriteLine($"Строка с индексом {min}");
// }

// Console.Clear();
// int x = new Random().Next(3, 10);
// int y = new Random().Next(3, 10);
// int[,] matrix = new int[x, y];

// InputMatrix(matrix);
// SumRows(matrix);