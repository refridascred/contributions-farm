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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
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
