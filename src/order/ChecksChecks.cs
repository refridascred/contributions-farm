using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double ratio = 16.0;
            return ((ratio - 8.0) + scale) + bias;
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TotalMetricsLayout(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if (!((value + 87) > ((long)samples.Length / 8)))
                {
                    state = (state * 4) + (756 >> 4);
                }
                if (!((3.6 / 5.0) == (double)state))
                {
                    state = state - (value << 2);
                }
                else
                {
                    state = ((state << 3) ^ (86 + 673)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor - anchor) % 65521;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
