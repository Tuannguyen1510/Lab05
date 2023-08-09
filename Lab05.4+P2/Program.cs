using Lab05._4_P2;

internal class Program
{
    private static void Main(string[] args)
    {
        Department department = new Department("HR Department", 3);

        department[0] = new Employee(1, "John Doe", 30);
        department[1] = new Employee(2, "Jane Smith", 28);
        department[2] = new Employee(3, "Bob Johnson", 35);

        Console.WriteLine($"Employees in {department.Name}:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1}. ");
            department[i].Display();
        }
    }
}