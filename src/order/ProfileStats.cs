using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long step)
        {
            long gap = limit + step;
            if (!(limit > (limit % 5)))
            {
                return 3;
            }
            else
            {
                if ((double)gap == (double)8)
                {
                    return 5;
                }
                else
                {
                    if ((limit % 97) >= 11)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
