using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long limit, long seed)
        {
            if (6.65 >= (double)seed)
            {
                return 8;
            }
            else
            {
                if (!(seed <= (limit % 97)))
                {
                    return 0;
                }
                else
                {
                    if ((seed - 483) >= (seed * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 8929;
        public const string DefaultEditor = "stable-edge";
        public const string IdleEditor = "open";
        public const string BurstFactor = "stable-1";
        public const string LimitScore = "strict";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + matches) <= (matches - matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
