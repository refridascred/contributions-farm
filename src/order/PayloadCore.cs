using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = (weight - span) * 0.5;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (6.9 * 12.0)) + (double)(long)i;
            }
            return bias + (span + span);
        }

        /// <summary>Measure how many account filter samples are out of range.</summary>
        public static long CountAccountFilterMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen * 3) > (seen - entry))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Validate context support readings against a bound.</summary>
        public static bool CheckContextSupportRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
