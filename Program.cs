using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11. Вывести такие значения.
            /*int [] omas = new int [9];
            for (int i = 0; i < 9; i++) 
            { 
              omas[i] = int.Parse(Console.ReadLine());
                Console.Write($"Введите элемент массива omas[{i}]: ");
            }
            Console.WriteLine("Элементы массива, кратные 11:");

            foreach (int e in omas)
            {
                if (e % 11 == 0)
                { 
                Console.WriteLine(e);
                }
            }*/
            //Задача 2. Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            /*// Инициализация массива с положительными числами
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int count = 0;  // Счётчик положительных чисел
            int value = 0;  // Сумма положительных чисел

            // Подсчёт суммы и количества положительных элементов
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    value += nums[i];
                    count++;
                }
            }

            // Вывод результата
            Console.WriteLine($"Сумма: {value} \n Количество: {count}");*/
            // Запрос размера массива
            /*Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            // Инициализация массива
            int[] array = new int[size];

            // Заполнение массива с клавиатуры
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Вывод массива в обратном порядке
            Console.WriteLine("Элементы массива в обратном порядке:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }*/
        }
    }
}
