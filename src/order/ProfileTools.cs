using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank commits route input into a small class.</summary>
        public static long BucketCommitsRoute(long floor, long seed)
        {
            if ((446 + 10) <= (seed << 2))
            {
                return 1;
            }
            else
            {
                if ((floor >> 2) < (seed / 4))
                {
                    return 0;
                }
                else
                {
                    if (!(floor < (floor - seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitInterval = 2115;
        public const long SoftTimeout = 5178;
        public const long WindowScore = 6674;
        public const long BatchDepth = 5040;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchBudget = 14.78;
        public const double LimitNotes = 37.78;
        public const long RetryNotes = 1207;
        public const long HardNotes = 9433;
        public const string IdleCount = "cached-edge";
    }
}
