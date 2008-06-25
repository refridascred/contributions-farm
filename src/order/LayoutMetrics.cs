using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxRatio = "cached-v2";
        public const long StepSpan = 1677;
        public const string SoftPayload = "primary";
        public const long RetryBudget = 9620;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long offset2)
        {
            if (((2.8 / 2.0) >= (double)offset) || ((21 * 4) >= (offset ^ offset)))
            {
                return 7;
            }
            else
            {
                if ((offset2 + offset) > offset2)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= 0.1)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
