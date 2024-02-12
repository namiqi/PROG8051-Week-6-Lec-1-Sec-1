using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        // how to create a method
        static void Welcome()
        {
            Console.WriteLine("Hi welcome");

        }

        static void WelcomeBack(string name, string lastname, int age)
        {
            Console.WriteLine(name+ " "+ lastname + ", Hi welcome");

        }


        static void add(double a , double b)
        {
            Console.WriteLine(a + b);
        }
        static void sub(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void div(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        static void mul(double a, double b)
        {
            Console.WriteLine(a * b);
        }


        static void myCourse( string course="PROG8051")
        {
            Console.WriteLine(course);
        }

        static double addition(double a , int b)
        {
            return a + b;
        }

        static double addition(double a, int b, int c)
        {
            return a + b+c;
        }

      
        static void Main(string[] args)
        {

           
            Console.WriteLine(addition(2.5, 3));
            Console.WriteLine(addition(2.5, 3,4));

            
            Console.WriteLine(addition(2, 3).GetType());

            Console.WriteLine("--------------------------------------");

            myCourse();
            myCourse("STAT3000");



            Console.WriteLine("Please enter 1st num: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter 2nd num: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter operation: ");

            string op = Console.ReadLine();

            if (op == "+")
            {
                add(num1, num2);
            }

            else if (op == "-")
            {
                sub(num1, num2);
            }

            else if (op == "/")
            {
                div(num1, num2);
            }

            else if (op == "*")
            {
                mul(num1, num2);
            }

            else
            {
                Console.WriteLine("");
            }

          




            // how to use a method
            for (int i = 0; i < 10; i++)
            {
                Welcome();
                WelcomeBack("Johnny", "hgvj",23);
            }

            WelcomeBack("Johnny","hgvj", 23);
        }
    }
}