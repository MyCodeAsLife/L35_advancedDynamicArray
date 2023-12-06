using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L35_advancedDynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSum = "sum";
            const string CommandExit = "exit";

            List<int> numbers = new List<int>();
            string userInput = null;
            bool isOpen = true;

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine($"Введите число для добавления его в массив.\nДля суммирования всех веденых чисел " +
                                  $"введите команду: {CommandSum}\nДля выхода из программы, введите команду: {CommandExit}\n");

                Console.Write("Введите команду или число: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSum:
                        Sum(numbers);
                        break;

                    case CommandExit:
                        isOpen = false;
                        continue;

                    default:
                        AddToArray(numbers, userInput);
                        break;
                }
            }
        }

        static void AddToArray(List<int> array, string userInput)
        {
            int tempNumber;

            if (int.TryParse(userInput, out tempNumber))
                array.Add(tempNumber);
            else
                Console.WriteLine("Введеное значение не является числом.");
        }

        static void Sum(List<int> array)
        {
            int sumNumbers = 0;

            foreach (int number in array)
                sumNumbers += number;

            Console.Clear();
            Console.WriteLine($"Общая сумма всех чисел: {sumNumbers}\n");
            Console.ReadKey();
        }
    }
}
