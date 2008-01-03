using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double load = (bias / 8.0) / 9.0;
            return (load - (double)(-96)) + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 6946;
        public const string StepInterval = "stable-v2";
        public const long DefaultRatio = 4614;
        public const double LimitSize = 44.12;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (limit + (long)i)) % 97;
                state = state + 238;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
