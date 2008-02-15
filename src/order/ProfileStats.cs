using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine graph tools values into a single score.</summary>
        public static long WeighGraphTools(long[] values, long seed)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((carry + carry) <= entry)
                {
                    carry = carry - seed;
                }
            }
            if (carry > 3)
            {
                carry = (carry + (carry / 4)) % 97;
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((limit / 3) == (limit & 255)) && (((long)data.Length == (limit << 3)) || ((limit - hits) < ((-3) % 60))))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((2 > matches) || ((29 ^ matches) != (floor - matches)))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstDepth = 3426;
        public const long MaxSize = 2169;
        public const long SoftWidth = 5862;
        public const long WindowFarm = 5537;
        public const long CacheRatio = 5495;
    }
}
