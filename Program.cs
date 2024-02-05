// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// ________________________________________________________________________

// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }

// Console.Write("Введите начальное число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int start = 1;

// ShowNumbers(m, n);

// ________________________________________________________________________

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int ShowAkkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return ShowAkkerman(m - 1, 1);
//     else return ShowAkkerman(m - 1, ShowAkkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно { ShowAkkerman(m, n)} ");


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// ________________________________________________________________________

// void ShowArray(int[] arr, int size)
// {
//     int j = size - 1;
//     if (j == 0)
//     {
//         Console.Write(arr[j]);
//         return;
//     }
//     Console.Write($"{arr[j]} ");
//     ShowArray(arr, size-1);
// }

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
// int size = array.Length;
// ShowArray(array, size);

// ________________________________________________________________________
