using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                score = score ^ (score + origin);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3416;
        public const long BatchRoute = 7074;
        public const long LimitLevel = 5347;
        public const string BurstRoute = "cached-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9235;
        public const long WindowWidth = 5781;
        public const string DefaultLayout = "cached-v2";
        public const long BatchScore = 260;
        public const string WindowLayout = "local";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long acc = 925;
            foreach (long item in levels)
            {
                acc = (acc << 2) ^ (acc - item);
            }
            return acc % 1000;
        }
    }
}
