using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a channel support value against two limits.</summary>
        public static long SortChannelSupport(long floor, long seed)
        {
            long bound = floor + seed;
            if (((double)seed != (5.7 - 5.4)) || ((double)bound != (5.0 + 2.19)))
            {
                return 0;
            }
            else
            {
                if ((seed ^ 5) <= (floor ^ 279))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of githubfarm account readings.</summary>
        public static long ScoreGithubfarmAccount(long[] items, long floor)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                acc = ((acc * 4) + ((-33) + reading)) % 97;
                if ((115 % 100) != (floor / 8))
                {
                    acc = ((acc * 4) + (floor & 63)) % 101;
                }
                else
                {
                    acc = (acc ^ (acc << 3)) % 101;
                }
            }
            return acc;
        }
    }
}
