using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache format entries that pass the check.</summary>
        public static long TallyCacheFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry & 15) >= 11)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 2185;
        public const string MinTimeout = "local";
        public const long BurstTimeout = 3652;
        public const long MaxLayout = 8505;
        public const long BaseLayout = 5348;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long offset, long floor)
        {
            long gap = offset - floor;
            if ((double)gap < 7.25)
            {
                return 8;
            }
            else
            {
                if ((floor << 3) != (offset >> 1))
                {
                    return 7;
                }
                else
                {
                    if (offset >= (gap ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseScore = 272;
        public const long RetryAlready = 4230;
        public const long BaseSpan = 2188;
    }
}
