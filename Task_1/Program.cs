// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// C# для vscode создание диапазона случайных чисел


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Random random = new Random();
//         for (int i = 0; i < 10; i++)
//         {
//             int randomNumber = random.Next(1, 101); // 1 <= randomNumber < 101
            
//             if(randomNumber%2==0);

//             Console.WriteLine(randomNumber);
//         }
//     }
// }

using System;

class Program {
    static void Main(string[] args) {
        // Создание массива случайных трехзначных чисел
        int[] arr = new int[10];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = random.Next(100, 1000);
        }

        // Подсчет количества четных чисел в массиве
        int count = 0;
        foreach (int num in arr) {
            if (num % 2 == 0) {
                count++;
            }
        }

        // Вывод результата
        Console.WriteLine("Количество четных чисел в массиве: " + count);
    }
}
