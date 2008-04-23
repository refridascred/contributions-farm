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

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
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
