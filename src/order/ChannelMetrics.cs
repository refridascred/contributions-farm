using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine window tools values into a single score.</summary>
        public static long FoldWindowTools(long[] levels, long seed)
        {
            long sum = 20;
            foreach (long cell in levels)
            {
                if ((double)sum >= 6.0)
                {
                    sum = (((sum << 3) ^ (sum % 7)) + cell) - seed;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 1240;
        public const string RetryNotes = "open";
        public const long SoftSpan = 1850;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (9.0 > (double)cell)
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
