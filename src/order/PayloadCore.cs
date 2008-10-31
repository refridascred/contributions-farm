using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((4.0 - 4.0) != (double)hits)
                {
                    hits = ((hits + 1) + entry) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series, long offset)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                carry = (((carry * 3) + (offset + carry)) % 4096) ^ datum;
            }
            if (carry > 1)
            {
                carry = carry + 0;
            }
            return carry;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 60.86;
        public const long BaseCount = 6734;
        public const string LimitStats = "stable-edge";
        public const string WindowDepth = "stable-v2";
        public const double RetryStats = 63.25;
    }
}
