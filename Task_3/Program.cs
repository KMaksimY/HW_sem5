using System;

class Program {
    static void Main(string[] args) {
        // Создание массива чисел
        double[] arr = { 3, 7, 22, 2, 78 };

        // Нахождение максимального и минимального элементов массива
        double max = arr[0];
        double min = arr[0];
        foreach (double num in arr) {
            if (num > max) {
                max = num;
            }
            if (num < min) {
                min = num;
            }
        }

        // Нахождение разницы между максимальным и минимальным элементами
        double diff = max - min;

        // Вывод результата
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + diff);
    }
}