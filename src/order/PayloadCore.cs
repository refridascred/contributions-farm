using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long seed)
        {
            long bound = floor + seed;
            if (!(701 > (seed << 2)))
            {
                return 7;
            }
            else
            {
                if ((double)755 >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor << 3) == (bound ^ floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + offset) < (8 << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TotalFilterMetric(long[] data, long limit)
        {
            long acc = 386;
            foreach (long value in data)
            {
                if ((double)value <= (double)13)
                {
                    acc = (acc - (acc - (-1))) % 4096;
                }
                if ((limit * 2) < (2 - (-736)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
