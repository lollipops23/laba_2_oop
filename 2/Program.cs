// вар 8
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.Generic;
using System.Linq;



namespace aboba
{
    abstract class Function
    {
        public abstract double Calculate(double x);
        public virtual void PrintResult()
        {
            Console.WriteLine("Результат функции: " + Calculate(1));
        }
    }
    class Ellipse : Function
    {
        private double a, b;

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Calculate(double x)
        {
            double y = b * Math.Sqrt(1 - x * x / (a * a));
            return y;
        }

        public void CalculateArea()
        {
            double area = Math.PI * a * b;
            Console.WriteLine("Площадь эллипса: " + area);
        }
    }

    class Hyperbola : Function
    {
        private double a, b;

        public Hyperbola(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Calculate(double x)
        {
            double y = b * Math.Sqrt((x * x) / ((a * a) - 1));
            return y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ellipse = new Ellipse(2, 1);
            Hyperbola hyperbola = new Hyperbola(2, 1); // создаем объект класса Hyperbola 

            Function ptr1 = ellipse; // создаем указатель на базовый класс и присваиваем ему адрес объекта класса Ellipse
            ptr1.PrintResult(); // вызываем метод PrintResult() через указатель на базовый класс
            ellipse.CalculateArea(); // вызываем метод CalculateArea() для объекта класса Ellipse

            Function ptr2 = hyperbola; // создаем указатель на базовый класс и присваиваем ему адрес объекта класса Hyper
            ptr2.PrintResult(); // вызываем метод PrintResult() через указатель на базовый класс
        }
    }
}