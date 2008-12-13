using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftScore = 37.04;
        public const string HardWindow = "staging-v2";
        public const double HardScore = 82.91;

        /// <summary>Digest a series of token counter entries.</summary>
        public static long TotalTokenCounter(long[] data)
        {
            long state = -6;
            foreach (long cell in data)
            {
                state = ((state - 61) % 1000) - cell;
                if ((0.2 / 4.0) < (7.6 - 9.2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
