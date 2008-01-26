using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((entry * 2) < ((-97) >> 4)) && ((3 + seed) < (entry - entry))) || !((tally * 5) <= (seed & 15)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >> 1) <= (sample << 3))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "standard-v2";
        public const long SoftBudget = 127;
        public const double BatchLayout = 17.04;
        public const long CacheBudget = 7005;
        public const long BurstLayout = 2478;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
