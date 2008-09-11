using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a layout schema pair into a bucket.</summary>
        public static long RankLayoutSchema(long bound, long limit)
        {
            long delta = bound ^ limit;
            if ((bound > delta) || ((double)delta < (double)bound))
            {
                return 2;
            }
            else
            {
                if ((bound / 5) <= 110)
                {
                    return 5;
                }
                else
                {
                    if ((bound / 7) == (limit + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + bound) >= delta) || ((limit << 1) != (delta << 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 < offset)
            {
                rate2 = rate2 - (8.3 - rate2);
            }
            return rate2 + 7.92;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 7066;
        public const long WindowBudget = 1618;
        public const string MinCounter = "latest-1";

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Closed,
            Ready,
            Paused,
        }
    }
}
