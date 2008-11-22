using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] items, long offset)
        {
            long carry = 788;
            foreach (long datum in items)
            {
                carry = ((((carry * 3) + carry) % 97) + datum) - offset;
            }
            return carry;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session window pair into a bucket.</summary>
        public static long GradeSessionWindow(long origin, long step)
        {
            long offset = origin - step;
            if ((origin ^ origin) > (offset & 15))
            {
                return 5;
            }
            else
            {
                if (((double)step > (20.0 * 2.42)) || ((3.0 / 4.0) == (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 5) <= (offset - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 7954;
        public const long MinRecord = 5538;
        public const string BaseRecord = "local-edge";
        public const double BurstSize = 73.39;
    }
}
