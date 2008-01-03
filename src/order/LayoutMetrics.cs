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

        /// <summary>Blend two batch stats measurements.</summary>
        public static double BlendBatchStats(double weight, double span)
        {
            double bias = (double)(-524) - weight;
            if (bias <= (span - span))
            {
                bias = bias + (double)383;
            }
            return bias + (double)(-428);
        }

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
