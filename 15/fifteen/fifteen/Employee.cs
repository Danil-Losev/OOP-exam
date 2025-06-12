using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteen
{
    public class Employee
    {
        public string Name { get; set; } // свойство для имени
        public double Salary { get; set; } // свойство для зарплаты
        public int CountOfMonthsWorked { get; set; } // свойство для количества отработанных месяцев

        public bool IsGoodEmployee { get; set; } // свойство для проверки, хороший ли сотрудник

        public Employee(string name, double salary, int countOfMonthsWorked)
        { // конструктор с параметрами
            Name = name;
            Salary = salary;
            CountOfMonthsWorked = countOfMonthsWorked;
        }

        public Employee(Employee employee) // конструктор копирования
        {
            Name = employee.Name;
            Salary = employee.Salary;
            CountOfMonthsWorked = employee.CountOfMonthsWorked;
            IsGoodEmployee = employee.IsGoodEmployee;
        }


        public Employee() // конструктор без параметров
        {
            Name = "Default Name";
            Salary = 0.0;
            CountOfMonthsWorked = 0;
        }

        virtual public double GetBonus() // виртуальный метод для получения бонуса
        {
            if (IsGoodEmployee) return ( Salary * 0.1 * CountOfMonthsWorked ) / Salary * 100;
            else return (Salary * 0.001 * (CountOfMonthsWorked > 10 ? CountOfMonthsWorked * 0.1 : CountOfMonthsWorked) ) / Salary * 100; // используется тернарный оператор
        }

        override public string ToString() // переопределение метода ToString для вывода информации о сотруднике
        {
            return "--Name: " + Name + "\n" +
                   "  Salary: " + Salary + "\n" +
                   "  CountOfMonthsWorked: " + CountOfMonthsWorked + "\n" +
                   "  IsGoodEmployee: " + IsGoodEmployee + "\n";
        }
    }
}
