// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

using System;

class Program {
    static void Main(string[] args) {
        // Создание массива случайных чисел
        int[] arr = new int[10];
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = random.Next(-100, 101);
        }

        // Подсчет суммы элементов, стоящих на нечетных позициях
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2) {
            sum += arr[i];
        }

        // Вывод результата
        Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);
    }
}
