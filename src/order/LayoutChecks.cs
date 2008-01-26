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

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings, long floor)
        {
            long state = 16;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (((state << 2) ^ (long)i) % 101) - floor;
                }
                state = (state + (datum & 7)) % 1000;
            }
            if (state < 376)
            {
                state = (state ^ 1) % 101;
            }
            return state;
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
