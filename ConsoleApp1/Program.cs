using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Fibseries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; i++) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        int rollno;
        string name;
        int age;
        int standard;
        public void setstudent(int rollno,string name,int age,int standard)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void getstudent()
        {
            Console.WriteLine("your roll no is;{0}",this.rollno);
            Console.WriteLine("your name  is;{0}", this.name);
            Console.WriteLine("your age  is;{0}", this.age);
            Console.WriteLine("your standard  is;{0}", this.standard);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter roll number");
            int roll =Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter Name");
            
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter standards");
            int standard = Convert.ToInt32(Console.ReadLine());

             //Program obj = new Program();
            //obj.Fibseries();
            
            Program student = new Program();
            student.setstudent(roll, "name", age, standard);
            student.getstudent();
            Console.ReadLine();


        }
    }
}
