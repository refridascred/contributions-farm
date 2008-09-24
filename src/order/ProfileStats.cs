using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 2) < seen)
                {
                    seen = ((seen + 3) + entry) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long floor)
        {
            long sum = 55;
            foreach (long value in samples)
            {
                if (floor <= (sum >> 4))
                {
                    sum = ((sum << 3) ^ (value % 3)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
