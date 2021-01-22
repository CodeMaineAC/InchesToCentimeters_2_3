using System;
using System.Collections.Generic;
using System.Text;

namespace InchesToCentimeters_2_3
{
    class ImperialToMetric
    {
        const double CENTIMETERS_PER_INCH = 2.54;
        const double KM_PER_MILE = 1.60934;
        public static double InchesToCentimeters(double inches)
        {
            return inches * CENTIMETERS_PER_INCH;
        }

        public static double MilesToKilometers(double miles)
        {
            return miles * KM_PER_MILE;
        }
    }
}
