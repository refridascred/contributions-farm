using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long item in levels)
            {
                carry = carry ^ item;
            }
            if (carry < 31)
            {
                carry = ((carry << 3) ^ (limit - limit)) % 97;
            }
            return carry;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Synced,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 52.12;
        public const long RetryInterval = 9980;
        public const long BurstWidth = 6181;
        public const long BatchStats = 123;
        public const long HardBudget = 8519;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 141;
        public const long HardInterval = 1284;
        public const long DefaultBatch = 8860;
    }
}
