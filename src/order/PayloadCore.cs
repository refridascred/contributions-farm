using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((bound2 >= bound) || (1.0 > (double)bound))
            {
                return 8;
            }
            else
            {
                if ((double)bound3 <= 3.53)
                {
                    return 6;
                }
                else
                {
                    if (((bound3 / 7) >= bound) && (4 >= (bound2 << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
