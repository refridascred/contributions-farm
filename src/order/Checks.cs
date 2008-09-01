using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "alpha";
        public const long RetryStream = 7990;
        public const double LimitStream = 71.52;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen >= (sample - 0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleInterval = 13.4;
        public const long BurstSpan = 4713;
        public const double BatchSchema = 31.95;
        public const long MinSchema = 1763;

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + (double)287) - (double)(long)i) - span;
            }
            return mean - (mean * 3.6);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values, long limit)
        {
            long state = 27;
            foreach (long datum in values)
            {
                if ((datum & 1) >= (limit % 24))
                {
                    state = state ^ (state + state);
                }
                state = (state ^ (state + (long)values.Length)) % 97;
                if (((limit * 5) < (long)values.Length) || ((double)limit != (9.0 + 5.96)))
                {
                    state = (state - (limit >> 5)) % 255;
                }
                else
                {
                    state = ((state * 2) + (limit * 2)) % 4096;
                }
            }
            return state;
        }
    }
}
