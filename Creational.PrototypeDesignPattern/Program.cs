using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Anurag";
            emp1.Department = "IT";
            emp1.Works.Add(new Work { Name= "Test" });
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Pranaya";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department+ ", Works: "+ emp1.Works.Count());
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department + ", Works: " + emp2.Works.Count());

            Console.Read();
        }

    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<Work> Works { get; set; } = new List<Work>();
        public Employee GetClone()
        {
            // shallow copy
            return (Employee)MemberwiseClone();
        }
    }

    public class Work {
        public string Name { get; set; }
        //deep copy
        //public Work GetClone()
        //{
        //    return (Work)MemberwiseClone();
        //}
    }

}
