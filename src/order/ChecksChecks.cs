using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long FoldAlreadyStats(long[] values, long target)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ target) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double floor)
        {
            double drift = floor / 2.0;
            if (drift <= (drift + floor))
            {
                drift = drift - (weight + weight);
            }
            else
            {
                drift = drift - (weight + drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (1.0 - drift)) + (double)(long)i;
            }
            return drift - (double)(-1);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftTimeout = 25.52;
        public const long StepAlready = 3208;
        public const long BurstDepth = 2904;
        public const string SoftAlready = "staging";
    }
}
