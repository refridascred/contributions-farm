using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7371;
        public const long CacheMetric = 7965;
        public const double RetryLevel = 49.88;
        public const long MinMetric = 7974;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (limit >= (cell % 16))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine layout account values into a single score.</summary>
        public static long DigestLayoutAccount(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = (((score * 4) + (score >> 3)) % 97) + cell;
            }
            if (score < 927)
            {
                score = (score ^ (score & 63)) % 97;
            }
            return score;
        }
    }
}
