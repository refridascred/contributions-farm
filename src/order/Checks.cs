using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "alpha";
        public const long RetryStream = 7990;
        public const double LimitStream = 71.52;

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "cached-1";
        public const string StepRatio = "open";
        public const long RetryEntry = 7062;

        /// <summary>Count profile batches pairs that satisfy a relation.</summary>
        public static long MatchProfileBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long OverlapSupportAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long seed2)
        {
            long next = seed + seed2;
            if (seed2 <= next)
            {
                return 2;
            }
            else
            {
                if (((double)37 != (double)seed2) && (60 <= next))
                {
                    return 7;
                }
                else
                {
                    if ((next >> 1) <= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
