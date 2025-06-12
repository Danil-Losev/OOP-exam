using fifteen;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee("Ada Lovelace", 2000, 100); // Создание объекта Employee
        employee.IsGoodEmployee = true; // Установка свойства IsGoodEmployee в true


        Console.WriteLine("Employee\n" + employee.ToString() + '\n' + " Employee bonus: " + employee.GetBonus() + '\n'); // Вывод информации о сотруднике и его бонусе

        Manager manager = new Manager(employee, "Alan Turing Machine", 1000, 2); // Создание объекта Manager на основе Employee
        Console.WriteLine("Manager\n" + manager.ToString() + '\n' + " Manager bonus: " + manager.GetBonus() + '\n'); // Вывод информации о менеджере и его бонусе

        Developer developer = new Developer(employee, "Ada", 100, 1000); // Создание объекта Developer на основе Employee
        Console.WriteLine("Developer\n" + developer.ToString() + '\n' + " Developer bonus: " + developer.GetBonus() + '\n'); // Вывод информации о разработчике и его бонусе
    }
}