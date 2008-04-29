using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchDepth = 9265;
        public const long BatchTimeout = 1539;
        public const long CacheContext = 7330;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double floor)
        {
            double rate = (gain * 3.4) - (double)406;
            if (rate > floor)
            {
                rate = rate + rate;
            }
            return rate + (floor + rate);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((43 / 6) != (seen + seen)) && ((double)seen <= (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
