using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long origin, long target)
        {
            long prev = origin + target;
            if (prev > (origin & 15))
            {
                return 3;
            }
            else
            {
                if ((6.06 - 6.5) == (double)prev)
                {
                    return 2;
                }
                else
                {
                    if ((0.7 / 7.0) > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheLevel = 102;
        public const long RetryProfile = 2891;
        public const long MinProfile = 291;
        public const double MaxProfile = 76.87;
        public const long BurstSpan = 7246;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
