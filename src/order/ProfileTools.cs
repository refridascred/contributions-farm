using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long limit, long bound)
        {
            if ((double)bound < (8.5 - 8.5))
            {
                return 7;
            }
            else
            {
                if ((bound <= (79 + limit)) || ((limit >> 3) > bound))
                {
                    return 8;
                }
                else
                {
                    if ((7.19 - 6.71) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleLevel = 8683;
        public const string IdleBudget = "fallback-v2";
        public const long IdleMetric = 2817;
        public const long CacheCount = 3172;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Synced,
            Failed,
            Pending,
            New,
        }
    }
}
