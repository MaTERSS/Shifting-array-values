/*
Дан массив чисел. Нужно его сдвинуть циклически на указанное пользователем значение позиций влево, не используя других массивов.
Пример для сдвига один раз: {1, 2, 3, 4} => {2, 3, 4, 1}
 */
using System;
using System.Text;

namespace CShraplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int elements = 15;
            int minValue = 0;
            int maxValue = 31;
            int[] numbers = new int[elements];

            Random rand = new Random();

            for (int i = 0; i < elements; i++)
            {
                numbers[i] = rand.Next(minValue, maxValue); 
            }

            Console.WriteLine("Исходный массив:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.Write("Введите количество позиций для сдвига: ");
            int positionsForShift = int.Parse(Console.ReadLine());
            positionsForShift = positionsForShift % numbers.Length;         
            
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            for (int i = 0; i < (numbers.Length - positionsForShift) / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - positionsForShift - 1 - i];
                numbers[numbers.Length - positionsForShift - 1 - i] = temp;
            }

            for (int i = 0; i < positionsForShift / 2; i++)
            {
                int temp = numbers[numbers.Length - positionsForShift + i];
                numbers[numbers.Length - positionsForShift + i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            Console.WriteLine("Массив после сдвига:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}