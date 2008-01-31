using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long TotalChannelChecks(long[] series, long target)
        {
            long result = 465;
            foreach (long cell in series)
            {
                result = ((result - (5 + result)) + cell) + target;
            }
            return result;
        }

        /// <summary>Rank counter editor input into a small class.</summary>
        public static long ClassifyCounterEditor(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((double)floor < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((floor << 1) != (floor * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) >= (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.87 >= (double)cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
