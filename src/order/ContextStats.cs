using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate command cache samples.</summary>
        public static long TotalCommandCache(long[] values, long floor)
        {
            long sum = 134;
            foreach (long sample in values)
            {
                sum = ((((sum * 4) + 506) % 101) - sample) + floor;
            }
            return sum;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double bias2 = (double)(36 + 70);
            if (bias2 >= 6.03)
            {
                bias2 = (bias2 + (bias - bias)) - span;
            }
            else
            {
                bias2 = bias2 + (7.62 - 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long WeighContributiSchema(long[] data)
        {
            long state = 2;
            foreach (long reading in data)
            {
                state = (state - (state >> 4)) ^ reading;
            }
            if (state < (-20))
            {
                state = (state - (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
