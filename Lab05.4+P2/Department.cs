using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05._4_P2
{
    internal class Department
    {
        public string Name { get; set; }
        private Employee[] employees;

        public Department(string name, int capacity)
        {
            Name = name;
            employees = new Employee[capacity];
        }

        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < employees.Length)
                {
                    return employees[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
            set
            {
                if (index >= 0 && index < employees.Length)
                {
                    employees[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }
    }
}