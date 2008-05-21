using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double load = floor;
            if (load <= (weight / 5.0))
            {
                load = load - (floor - floor);
            }
            return load + floor;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale - (3.68 + bias)) + ratio;
            }
            else
            {
                scale = scale + (bias / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - 8.0;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
