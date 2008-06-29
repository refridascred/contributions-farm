using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((236 & 63) == ((-5) - floor))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double load = (double)3 - bias;
            if (load < 2.94)
            {
                load = (load - bias) + floor;
            }
            else
            {
                load = load - (bias + 12.0);
            }
            return load - (load * 0.2);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleSpan = 90.44;
        public const long BatchTimeout = 1586;
        public const long DefaultWidth = 9777;
        public const string LimitScore = "legacy-1";
        public const string CacheLevel = "stable-v2";

        /// <summary>Iterate the report account series from a seed.</summary>
        public static long SeriesReportAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(state < (state - state)))
                {
                    state = ((state * 5) + 1) % 101;
                    state = (state - ((long)i & 255)) % 1000;
                }
                state = state ^ (long)i;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
