using fifteen;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee("Ada Lovelace", 2000, 100);
        employee.IsGoodEmployee = true;


        Console.WriteLine("Employee\n" + employee.ToString() + '\n' + " Employee bonus: " + employee.GetBonus() + '\n');

        Manager manager = new Manager(employee, "Alan Turing Machine", 1000, 2);
        Console.WriteLine("Manager\n" + manager.ToString() + '\n' + " Manager bonus: " + manager.GetBonus() + '\n');

        Developer developer = new Developer(employee, "Ada", 100, 1000);
        Console.WriteLine("Developer\n" + developer.ToString() + '\n' + " Developer bonus: " + developer.GetBonus() + '\n');
    }
}