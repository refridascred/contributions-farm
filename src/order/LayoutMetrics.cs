using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] levels, long origin)
        {
            long carry = 811;
            foreach (long sample in levels)
            {
                if (!((origin & 3) <= (sample ^ origin)))
                {
                    carry = (carry + (sample + origin)) % 65521;
                }
                if ((origin >> 4) >= carry)
                {
                    carry = (carry ^ origin) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (origin - 3)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long offset)
        {
            long offset2 = target - offset;
            if (!((offset2 - target) >= (offset2 / 8)))
            {
                return 6;
            }
            else
            {
                if ((3.0 - 8.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Idle,
            Dropped,
        }
    }
}
