using System;
using System.Collections.Generic;
using System.Linq;

namespace SynergyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> staff = new List<Worker>();
            Console.WriteLine("--- Система учета кадров Университета 'Синергия' (2026) ---");

            Console.Write("Введите количество сотрудников: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nВвод данных сотрудника #{i + 1}:");
                Console.Write("Фамилия и инициалы: ");
                string name = Console.ReadLine();
                Console.Write("Должность: ");
                string pos = Console.ReadLine();
                Console.Write("Зарплата: ");
                double sal = double.Parse(Console.ReadLine());
                Console.Write("Год поступления на работу: ");
                int year = int.Parse(Console.ReadLine());

                staff.Add(new Worker(name, pos, sal, year));
            }

            Console.Write("\nВведите минимальный стаж работы для поиска: ");
            int requiredExperience = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nСотрудники со стажем более {requiredExperience} лет:");
            bool found = false;

            foreach (var worker in staff)
            {
                if (worker.GetExperience() > requiredExperience)
                {
                    Console.WriteLine(worker.GetFullName());
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Таких работников нет.");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
