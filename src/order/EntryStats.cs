using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "latest-v2";
        public const double DefaultCommits = 95.26;
        public const long MinBudget = 4515;
        public const long WindowScore = 9082;

        /// <summary>Define window limits and defaults.</summary>
        public const double HardTimeout = 78.79;
        public const long IdleCount = 919;
        public const string BurstWidth = "open-v2";

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                if ((mark * 4) < (cell + cell))
                {
                    mark = (mark + cell) % 4096;
                }
                if ((double)cell >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
