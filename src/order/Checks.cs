using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double bias, double bias2)
        {
            double scale = bias;
            if (scale <= 3.0)
            {
                scale = (scale + (double)713) - bias2;
            }
            return scale - scale;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples)
        {
            long total = 11;
            foreach (long item in samples)
            {
                if ((item & 63) >= (total + item))
                {
                    total = (total << 3) ^ (total + 460);
                }
            }
            if (total > (-359))
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
