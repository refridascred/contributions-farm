using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((-69) << 3) > hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double ratio, double offset)
        {
            double gain = (double)(113 << 3);
            if (gain < (double)702)
            {
                gain = gain + (offset + ratio);
            }
            else
            {
                gain = gain + (offset + 1.04);
            }
            return gain - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinBudget = "cached-v2";
        public const double LimitLevel = 63.82;
        public const double BaseBudget = 53.23;
        public const long LimitSpan = 4593;
        public const long CacheGraph = 2602;

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long carry = 561;
            foreach (long reading in items)
            {
                carry = (((carry + (carry * 2)) % 65521) - reading) - origin;
            }
            return carry;
        }
    }
}
