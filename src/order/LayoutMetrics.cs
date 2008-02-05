using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging-edge";
        public const string MinFactor = "stable-v2";
        public const string SoftScore = "cached-1";
        public const long RetryContext = 1312;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((step >> 5) == (step / 2))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next order filter value.</summary>
        public static double ProjectOrderFilter(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 9; i++)
            {
                load = (((load - (5.51 * 18.0)) + (double)(long)i) + scale) - span;
            }
            return load + (double)4;
        }
    }
}
