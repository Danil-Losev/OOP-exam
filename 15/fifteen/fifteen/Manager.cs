using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifteen
{
    public class Manager : Employee// наследование от класса Employee
    {
        public string DepartmentName { get; set; } // свойство для названия отдела
        public int CountOfSelledProducts { get; set; } // свойство для количества проданных продуктов
        public int CountOfEmployees { get; set; } // свойство для количества сотрудников в отделе

        public Manager(string name, double salary, int countOfMonthsWorked, string departmentName, int countOfSelledProducts, int countOfEmployees)
            : base(name, salary, countOfMonthsWorked) // вызов конструктора базового класса
        {
            DepartmentName = departmentName;
            CountOfSelledProducts = countOfSelledProducts;
            CountOfEmployees = countOfEmployees;
        }

        public Manager(Employee employee, string departmentName, int countOfSelledProducts, int countOfEmployees)
            : base(employee) // вызов конструктора базового класса
        {
            DepartmentName = departmentName;
            CountOfSelledProducts = countOfSelledProducts;
            CountOfEmployees = countOfEmployees;
        }



        // констрруктор копирования
        public Manager(Manager manager) : base(manager.Name, manager.Salary, manager.CountOfMonthsWorked)
        {
            DepartmentName = manager.DepartmentName;
            CountOfSelledProducts = manager.CountOfSelledProducts;
            CountOfEmployees = manager.CountOfEmployees;
        }




        public Manager() : base() // конструктор без параметров
        {
            DepartmentName = "Default Department";
            CountOfSelledProducts = 0;
            CountOfEmployees = 0;
        }

        override public double GetBonus() // переопределение метода GetBonus
        {
            if (IsGoodEmployee) return base.GetBonus() + (CountOfSelledProducts * 20) / Salary * 100; // бонус для хорошего менеджера
            else return base.GetBonus() + (CountOfSelledProducts * 10) / Salary * 100; // бонус для плохого менеджера
        }

        override public string ToString() // переопределение метода ToString для вывода информации о менеджере
        {
            return base.ToString() + // вызов ToString базового класса
                   "  DepartmentName: " + DepartmentName + "\n" +
                   "  CountOfSelledProducts: " + CountOfSelledProducts + "\n" +
                   "  CountOfEmployees: " + CountOfEmployees + "\n";
        }
    }
}
