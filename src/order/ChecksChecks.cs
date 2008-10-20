using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double rate = 1.5;
            if (rate >= (span * 9.13))
            {
                rate = (rate - span) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 20.0) + (double)(long)i;
            }
            return rate - (double)(-42);
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total * 5) + total) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4307;
        public const string BatchContributi = "latest";
        public const long MaxContributi = 8034;
        public const long WindowContributi = 4965;
    }
}
