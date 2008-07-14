using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 1872;
        public const double MaxBudget = 25.7;
        public const string RetrySize = "fallback-1";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 6681;
        public const long BurstRecord = 907;
        public const long CacheRecord = 5619;
        public const double WindowDepth = 62.12;
        public const long CacheFactor = 2611;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values, long limit)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score ^ limit) % 101) ^ value;
            }
            return score;
        }
    }
}
