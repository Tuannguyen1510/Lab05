using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05._4_P2_Them
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, int age, double salary)
        {
            ID = id;
            Name = name;
            Age = age;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}, Salary: {Salary}");
        }
    }
}
