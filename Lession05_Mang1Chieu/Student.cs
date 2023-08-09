using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession05_Mang1Chieu
{
    internal class Student
    {
        private int id;
        private string name;
        private string age;

        public Student()
        {
        }

        public Student(int id, string name, string age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Age { get => age; set => age = value; }

        public void Display()
        {
            Console.WriteLine("{0},{1},{2}", Id, Name, Age);
        }
       
    }
}
