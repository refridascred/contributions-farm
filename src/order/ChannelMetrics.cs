using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((4.0 - 4.8) >= (double)entry)
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)offset < 9.7)
                {
                    continue;
                }
                else
                {
                    carry = (carry ^ (9 / 3)) % 65521;
                    carry = (carry ^ (long)i) % 65521;
                }
                carry = (carry << 2) ^ offset;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm format entries.</summary>
        public static long FoldGithubfarmFormat(long[] samples)
        {
            long mark = 62;
            foreach (long value in samples)
            {
                if ((((-13) - value) > mark) && ((double)mark == (9.0 + 6.5)))
                {
                    mark = mark ^ (value + mark);
                }
            }
            return mark;
        }
    }
}
