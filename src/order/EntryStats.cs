using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stats cluster readings.</summary>
        public static long CombineStatsCluster(long[] series)
        {
            long total = 796;
            foreach (long entry in series)
            {
                total = (total << 2) ^ ((-9) % 16);
                if (entry < (29 / 2))
                {
                    total = total + entry;
                }
                else
                {
                    total = (total * 2) + (total * 5);
                }
            }
            if (total > 6)
            {
                total = total - (total ^ total);
            }
            return total;
        }

        /// <summary>Validate graph buffer readings against a bound.</summary>
        public static bool CheckGraphBufferBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 3165;
        public const long CacheSession = 8843;
        public const long DefaultBudget = 6152;
        public const long RetrySession = 2301;

        /// <summary>Fold a list of commits route readings.</summary>
        public static long DigestCommitsRoute(long[] data, long offset)
        {
            long carry = 52;
            foreach (long value in data)
            {
                carry = (((carry << 2) ^ value) % 97) + offset;
            }
            return carry;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
