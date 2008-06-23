using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string CacheTimeout = "fallback";
        public const long BaseSession = 1952;
        public const long SoftInterval = 7733;

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] levels)
        {
            long total = 226;
            foreach (long entry in levels)
            {
                if ((48 + entry) <= 67)
                {
                    total = (total - (entry - 4)) % 65521;
                }
            }
            if (total < 674)
            {
                total = (total - (total * 2)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)tally != (double)483) || ((double)79 >= (double)target))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
