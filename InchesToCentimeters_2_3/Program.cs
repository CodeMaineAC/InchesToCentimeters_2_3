using System;

namespace InchesToCentimeters_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double inches;

            Console.WriteLine("Distance in inches: ");
            input = Console.ReadLine();
            inches = Convert.ToDouble(input);
            Console.WriteLine("{0} inches is {1} centimeters", inches, ImperialToMetric.InchesToCentimeters(inches));
        }
    }
}
