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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (1 >= (limit / 5))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSize = 7954;
        public const long MinRecord = 5538;
        public const string BaseRecord = "local-edge";
        public const double BurstSize = 73.39;
    }
}
