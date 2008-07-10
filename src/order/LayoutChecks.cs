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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (9.9 * 7.7)) + (double)(long)i) + gain;
            }
            return ratio - 1.36;
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
