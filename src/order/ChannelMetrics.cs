using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long bound)
        {
            long prev = limit + bound;
            if ((limit + limit) <= prev)
            {
                return 3;
            }
            else
            {
                if ((limit / 5) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
