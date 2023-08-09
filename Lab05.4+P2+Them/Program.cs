using Lab05._4_P2_Them;

internal class Program
{
    private static void Main(string[] args)
    {
        int MaxEmployees = 100;
        Employee[] employees = new Employee[MaxEmployees];

        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Employee {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            employees[i] = new Employee(id, name, age, salary);
        }

        Console.WriteLine("\nList of Employees:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. ");
            employees[i].Display();
        }

        // Sorting by Salary in descending order using Bubble Sort
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (employees[j].Salary < employees[j + 1].Salary)
                {
                    Employee temp = employees[j];
                    employees[j] = employees[j + 1];
                    employees[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nList of Employees after sorting by Salary (descending):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. ");
            employees[i].Display();
        }

        Console.Write("\nEnter a name to search for: ");
        string searchName = Console.ReadLine();

        bool found = false;
        Console.WriteLine("\nSearch results:");
        for (int i = 0; i < n; i++)
        {
            if (employees[i].Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                employees[i].Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"No employee with the name '{searchName}' found.");
        }
    }
}