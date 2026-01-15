using System;

namespace SynergyPractice
{
    public class Worker
    {
        // Поля класса
        private string fullName;
        private string position;
        private double salary;
        private int yearStarted;

        // Конструктор по умолчанию
        public Worker()
        {
            fullName = "Неизвестно";
            position = "Стажер";
            salary = 0;
            yearStarted = DateTime.Now.Year;
        }

        // Конструктор с параметрами
        public Worker(string name, string pos, double sal, int year)
        {
            fullName = name;
            position = pos;
            salary = sal;
            yearStarted = year;
        }

        // Деструктор (в C# реализуется через финализатор)
        ~Worker()
        {
            Console.WriteLine($"Объект для {fullName} удален из памяти.");
        }

        // Методы изменения полей
        public void SetFullName(string name) => fullName = name;
        public void SetPosition(string pos) => position = pos;
        public void SetSalary(double sal) => salary = sal;
        public void SetYear(int year) => yearStarted = year;

        // Методы получения данных
        public string GetFullName() => fullName;
        public int GetYearStarted() => yearStarted;

        // Метод отображения
        public void DisplayInfo()
        {
            Console.WriteLine($"Сотрудник: {fullName} | Должность: {position} | Зарплата: {salary} | Год поступления: {yearStarted}");
        }

        // Метод расчета стажа (актуально на 2026 год)
        public int GetExperience()
        {
            return 2026 - yearStarted;
        }
    }
}
