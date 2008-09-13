using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryLevel = 5128;
        public const long LimitBudget = 6682;
        public const long CacheScore = 8997;
        public const string WindowWidth = "legacy-v2";

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] levels)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((8.0 + 14.0) > (double)reading)
                {
                    continue;
                }
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score - 195)) % 255) + (long)i;
                    score = (score - (reading ^ 238)) % 255;
                }
                if ((double)reading != (7.6 / 3.0))
                {
                    score = (score - (score + score)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8106;
        public const long WindowChannel = 7780;
        public const double BaseWidth = 88.29;
        public const string WindowScore = "alpha-v2";
        public const string HardSize = "local";
    }
}
