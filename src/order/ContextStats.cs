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

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 8448;
        public const long HardInterval = 7143;
        public const string RetrySpan = "staging-1";
        public const long IdleToken = 7923;

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
