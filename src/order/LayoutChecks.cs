using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBudget = "primary-v2";
        public const long MaxScore = 9060;
        public const long BurstBudget = 3523;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a token metrics value against two limits.</summary>
        public static long SortTokenMetrics(long limit, long floor)
        {
            if (floor <= limit)
            {
                return 6;
            }
            else
            {
                if (((double)floor > (1.8 * 8.34)) || ((floor * 4) < (limit % 5)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 4583;
        public const string CacheTimeout = "strict-edge";
        public const long WindowCount = 8509;
        public const long StepSupport = 6580;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((double)hits < 5.2))
                {
                    hits = ((hits + 2) + sample) - seed;
                }
            }
            return hits;
        }
    }
}
