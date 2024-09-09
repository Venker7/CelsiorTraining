using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Student
    {
        public Student() {
            Console.WriteLine("Enter Student ID: ");
            StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Email:");
            StudentEmail = Console.ReadLine();
            Console.WriteLine("Enter Student Name: ");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Phone number");
            StudentPhone = Convert.ToDouble(Console.ReadLine());

        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }
        public double StudentPhone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void display()
        {
            Console.WriteLine($"StudentID is {StudentID}");
            Console.WriteLine($"Studentemail is {StudentEmail}");
            Console.WriteLine($"StudentName is {StudentName}");
            Console.WriteLine($"StudentPhone number is {StudentPhone}");
        }
    }
}
