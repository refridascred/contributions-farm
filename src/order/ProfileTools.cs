using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum - ((long)i * 4)) % 97;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (limit - (-103))) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + 9) < (datum >> 5))
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1075;
        public const long CacheSize = 1248;
        public const double StepStream = 50.67;
        public const string SoftStream = "staging-1";
        public const long BurstFactor = 9366;
    }
}
