using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a context commits pair into a bucket.</summary>
        public static long RankContextCommits(long origin, long origin2)
        {
            long next = origin + origin2;
            if ((origin + origin2) < (origin2 * 4))
            {
                return 6;
            }
            else
            {
                if (((441 << 3) != (next + 0)) || ((origin2 - next) > (origin2 & 31)))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 4) < (next * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long carry = -16;
            foreach (long item in items)
            {
                if (carry >= (item & 63))
                {
                    carry = (carry << 3) ^ (item * 2);
                }
            }
            return carry;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Retry,
            Done,
            Dropped,
        }
    }
}
