using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    public class Fraction
    {
        private readonly long integerPart;
        private readonly ushort fractionalPart;

        public Fraction Add(Fraction num)
        {
            float res = float.Parse(integerPart + "," + fractionalPart) +
                        float.Parse(num.integerPart + "," + num.fractionalPart);
            string[] parts = res.ToString("0.0###").Split(',');
            return new Fraction(int.Parse(parts[0]), ushort.Parse(parts[1]));
        }

        public Fraction Mult(Fraction num)
        {
            float res = float.Parse(integerPart + "," + fractionalPart) *
                        float.Parse(num.integerPart + "," + num.fractionalPart);
            string[] parts = res.ToString("0.0###").Split(',');
            return new Fraction(int.Parse(parts[0]), ushort.Parse(parts[1]));
        }

        public Fraction Sub(Fraction num)
        {
            float res = float.Parse(integerPart + "," + fractionalPart) -
                        float.Parse(num.integerPart + "," + num.fractionalPart);
            string[] parts = res.ToString("0.0###").Split(',');
            return new Fraction(int.Parse(parts[0]), ushort.Parse(parts[1]));
        }

        public Fraction Div(Fraction num)
        {
            float res = float.Parse(integerPart + "," + fractionalPart) /
                        float.Parse(num.integerPart + "," + num.fractionalPart);
            string[] parts = res.ToString("0.0###").Split(',');
            return new Fraction(int.Parse(parts[0]), ushort.Parse(parts[1]));
        }

        public bool Gt(Fraction num)
        {
            return float.Parse(integerPart + "," + fractionalPart) <
                   float.Parse(num.integerPart + "," + num.fractionalPart);
        }

        public bool Lt(Fraction num)
        {
            return float.Parse(integerPart + "," + fractionalPart) >
                   float.Parse(num.integerPart + "," + num.fractionalPart);
        }

        public Fraction(long integerPart, ushort fractionalPart)
        {
            this.integerPart = integerPart;
            this.fractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return integerPart + "," + fractionalPart;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANASTASIJA MEZALE, 4802BD");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();
            Fraction number1 = new Fraction(12, 5);
            Fraction number2 = new Fraction(15, 25);
            Console.WriteLine("Number1: " + number1);
            Console.WriteLine("Number2: " + number2);
            Console.WriteLine("Addition: " + number1.Add(number2));
            Console.WriteLine("Subtraction: " + number1.Sub(number2));
            Console.WriteLine("Multiplication: " + number1.Mult(number2));
            Console.WriteLine("Division: " + number1.Div(number2));
            Console.WriteLine();
            Console.WriteLine("Number1 < Number2: " + number1.Gt(number2));
            Console.WriteLine("Number1 > Number2: " + number1.Lt(number2));
            Console.ReadLine();
        }
    }
}