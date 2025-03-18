using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryExample
{
    internal class Student {
        private string name;
        private string phoneNumber;
        private Address address;
        private DateTime dateOfBirth;
        internal Student(string name, string phoneNumber, string address,DateTime dateOfBirth)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = new Address();
            this.address.setAddress(address);
            this.dateOfBirth = dateOfBirth;
        }

        internal string getName() { return this.name; }
        internal int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (today < dateOfBirth.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }

    internal class  Address
    {
        private string address;
        internal Address()
        {
            this.address = "";
        }

        internal void setAddress(string address)
        {
            this.address = address;
        }
    }


    internal abstract class Stream
    {
        public List<Student> students;
        public Stream()
        {
            this.students = new List<Student>();
        }
        public abstract void PrintStudents();
        public abstract void AddStudent(Student student);
    }
    internal class Science:Stream { 
        
        public Science():base()
        {
            
        }
        public override void PrintStudents()
        {
            foreach (Student student in this.students)
            {
                Console.WriteLine($"Name: {student.getName()}, Age: {student.CalculateAge()}");
            }
        }

        public override void AddStudent(Student student)
        {
            students.Add(student);
        }
    }

    internal class Maths : Stream
    {

        public Maths() : base()
        {

        }
        public override void PrintStudents()
        {
            foreach (Student student in this.students)
            {
                Console.WriteLine($"Name: {student.getName()}, Age: {student.CalculateAge()}");
            }
        }

        public override void AddStudent(Student student)
        {
            students.Add(student);
        }
    }

    internal class Arts : Stream
    {

        public Arts() : base()
        {

        }
        public override void PrintStudents()
        {
            foreach (Student student in this.students)
            {
                Console.WriteLine($"Name: {student.getName()}, Age: {student.CalculateAge()}");
            }
        }

        public override void AddStudent(Student student)
        {
            students.Add(student);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           
            Stream scienceStream = new Science();
            Stream mathsStream = new Maths();
            Stream artsStream = new Arts();

           
            Console.WriteLine("Enter details for Science Student:");
            Student scienceStudent = GetStudentDetails();
            scienceStream.AddStudent(scienceStudent);

            
            Console.WriteLine("Enter details for Maths Student:");
            Student mathsStudent = GetStudentDetails();
            mathsStream.AddStudent(mathsStudent);

            Console.WriteLine("Enter details for Arts Student:");
            Student artsStudent = GetStudentDetails();
            artsStream.AddStudent(artsStudent);

          
            Console.WriteLine("\nScience Stream Students:");
            scienceStream.PrintStudents();

            Console.WriteLine("\nMaths Stream Students:");
            mathsStream.PrintStudents();

            Console.WriteLine("\nArts Stream Students:");
            artsStream.PrintStudents();
        }

        static Student GetStudentDetails()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Date of Birth (YYYY-MM-DD): ");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.Write("Invalid date format. Please enter again (YYYY-MM-DD): ");
            }

            return new Student(name, phoneNumber, address, dateOfBirth);
        }
    }
}
