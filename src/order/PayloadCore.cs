using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSpan = 3911;
        public const long HardSize = 5332;
        public const double IdleDepth = 15.97;
        public const string IdleChecks = "cached-v2";

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long WeighClusterCounter(long[] data)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = (acc - (acc / 7)) - entry;
            }
            return acc;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((double)datum != (double)seen) && (seen <= (seen & 127)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double gain, double offset)
        {
            double rate = (double)(124 / 4);
            if (rate > (double)66)
            {
                rate = rate + gain;
            }
            return rate + (offset / 2.0);
        }
    }
}
