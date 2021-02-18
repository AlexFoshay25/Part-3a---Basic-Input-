using System;

namespace Part_3___Basic_Input
{
    class Program
    {
        static void Main(string[] args)
        {   //Part 3a

            string name;
            int age;
            int year;

            Console.WriteLine("What's Your Name?");
            name = Console.ReadLine();
            Console.WriteLine("Name:" + name);


            Console.WriteLine("How Old Are You?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age:" + (age));

            Console.WriteLine("What Year is it?");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year:" + (year));

            Console.WriteLine("______________________________________");
            Console.WriteLine("");

            int a;
            int b;
            int c;

            Console.WriteLine("Enter 3 Numbers");
            Console.WriteLine("#1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#3:");
            c = Convert.ToInt32(Console.ReadLine());

            int d = a + b + c;
            Console.WriteLine($"The sum of {a}, {b}, and {c} is {d}.");

            Console.WriteLine("______________________________________");
            Console.WriteLine("");

            string dis1;
            string dis2;
            string dis3;
            double final;
            double avg = 3;

            Console.WriteLine("Enter a number to be recorded as distance in km");
            dis1 = Console.ReadLine();
            double cal1 = Convert.ToDouble(dis1);

            Console.WriteLine("Please enter another distance in km");
            dis2 = Console.ReadLine();
            double cal2 = Convert.ToDouble(dis2);

            Console.WriteLine("Please enter a final distance in km");
            dis3 = Console.ReadLine();
            double cal3 = Convert.ToDouble(dis2);

            final = (cal1 + cal2 + cal3) / avg;
            final = Math.Round(final, 2);

            Console.WriteLine($"The average of  {cal1}km, {cal2}km, and {cal3}km is {final}km");

            Console.WriteLine("______________________________________");
            Console.WriteLine("");

            Console.WriteLine("Enter a length to be used as a side of a triangle in cm");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a 2nd length to be used as a side of a triangle in cm");
            double sideB = Convert.ToDouble(Console.ReadLine());

            double hyp = Math.Sqrt(sideA * sideA + sideB * sideB);
            
            Console.WriteLine($"The Hypotenuse of the Triangle is {Math.Round(hyp, 2)}cm");

            Console.ReadLine();






























            Console.ReadLine();

        }
    }
}
