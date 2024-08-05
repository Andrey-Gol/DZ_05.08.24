// // Задача 1
// void Main ()
// {
//  int N = ReadInt("Введите число N: ");
//  int M = ReadInt("Введите число M: ");
//  PrintNumber(N, M);
// }
// void PrintNumber(int N, int M)
// {
// if (N+1 >= M) return;
// System.Console.Write(N+1+" ");
// N = N + 1;
// PrintNumber(N, M);
// }


// int ReadInt(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();

// Задача 2

// void Main()
// {
//     int m = ReadInt("Введите неотрицательное число m: ");
//     int n = ReadInt("Введите неотрицательное число n: ");
//     int result = Ackermann(n, m);
//     Console.WriteLine($"Ackermann({n}, {m}) = {result}");
// }

// int Ackermann(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (m == 0)
//     {
//         return Ackermann(n - 1, 1);
//     }
//     else
//     {
//         return Ackermann(n - 1, Ackermann(n, m - 1));
//     }
// }

// int ReadInt(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();

// Задача 3

// void Main()
// {
//     int size = ReadInt("Введите количество элементов массива: ");
    
//     int[] array = GenerateRandomArray(size);
    
//     Console.WriteLine("Сгенерированный массив:");
//     PrintArray(array);
    
//     Console.WriteLine("Элементы массива, начиная с конца:");
//     PrintArrayInReverse(array, size - 1);
// }


// int[] GenerateRandomArray(int size)
// {
//     Random random = new Random();
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = random.Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//     {
//         Console.Write(item + " ");
//     }
//     Console.WriteLine();
// }

// void PrintArrayInReverse(int[] array, int index)
// {
//     if (index < 0)
//     {
//         return;
//     }
//     Console.Write(array[index] + " ");
//     PrintArrayInReverse(array, index - 1);
// }

// int ReadInt(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Main();