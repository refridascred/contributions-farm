using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long result = 7;
            foreach (long entry in data)
            {
                result = (((result * 2) + 925) % 1000) ^ entry;
            }
            if (result > 4)
            {
                result = (result ^ (4 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample + count) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 49.95;
        public const long LimitScore = 989;
        public const long RetryRatio = 6123;
        public const double CacheContext = 76.13;
    }
}
