using System;

namespace mohit_masahat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the radius of circle :");
            Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("mohit = " + circle.mohit + " masahat = " + circle.masahat);
            Console.WriteLine("******************");
            Console.WriteLine("please enter the side of square :");
            square Square = new square(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("mohit = " + Square.mohit + " masahat = " + Square.masahat);
            Console.WriteLine("******************");
            Console.WriteLine("please enter the ghaede and ertefa of triangle:");
            double ghaede = Convert.ToDouble(Console.ReadLine());
            double ertefa = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(ghaede, ertefa);
            Console.WriteLine("masahat = " + triangle.masahat);
            Console.WriteLine("******************");
            Console.WriteLine("please enter the ertefa and ghede of trapezium :");
            double Ertefa = Convert.ToDouble(Console.ReadLine());
            double Ghaede1 = Convert.ToDouble(Console.ReadLine());
            double Ghaede2 = Convert.ToDouble(Console.ReadLine());
            Trapezium trapezium = new Trapezium(Ertefa, Ghaede1, Ghaede2);
            Console.WriteLine("masahat = " + trapezium.masahat);
            Console.ReadKey();
        }
    }
}
