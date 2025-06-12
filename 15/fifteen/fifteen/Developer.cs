using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteen
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; } // свойство для языка программирования
        public int CountOfProjects { get; set; } // свойство для количества проектов
        public int HoursWorked { get; set; } // свойство для количества отработанных часов

        public Developer(string name, double salary, int countOfMonthsWorked, string programmingLanguage, int countOfProjects, int hoursWorked)
            : base(name, salary, countOfMonthsWorked) // вызов конструктора базового класса
        {
            ProgrammingLanguage = programmingLanguage;
            CountOfProjects = countOfProjects;
            HoursWorked = hoursWorked;
        }

        public Developer(Employee employee, string programmingLanguage, int countOfProjects, int hoursWorked)
            : base(employee) // вызов конструктора базового класса
        {
            ProgrammingLanguage = programmingLanguage;
            CountOfProjects = countOfProjects;
            HoursWorked = hoursWorked;
        }

        // конструктор копирования
        public Developer(Developer developer) : base(developer.Name, developer.Salary, developer.CountOfMonthsWorked)
        {
            ProgrammingLanguage = developer.ProgrammingLanguage;
            CountOfProjects = developer.CountOfProjects;
            HoursWorked = developer.HoursWorked;
        }

        public Developer() : base() // конструктор без параметров
        {
            ProgrammingLanguage = "Default Language";
            CountOfProjects = 0;
            HoursWorked = 0;
        }

        override public double GetBonus() // переопределение метода GetBonus
        {
            if (IsGoodEmployee) return base.GetBonus() + (CountOfProjects * 100) / Salary * 100; // бонус для хорошего разработчика
            else return base.GetBonus() + (CountOfProjects * 50 ) / Salary * 100; // бонус для плохого разработчика
        }

        override public string ToString() // переопределение метода ToString для вывода информации о разработчике
        {
            return base.ToString() + // вызов ToString базового класса
                   "  ProgrammingLanguage: " + ProgrammingLanguage + "\n" +
                   "  CountOfProjects: " + CountOfProjects + "\n" +
                   "  HoursWorked: " + HoursWorked + "\n";
        }
    }
}
