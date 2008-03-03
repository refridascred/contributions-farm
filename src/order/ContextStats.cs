using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long limit)
        {
            if ((bound > (limit + limit)) || ((limit >> 4) > bound))
            {
                return 7;
            }
            else
            {
                if ((5.29 * 4.37) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((17.0 - 3.21) >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit % 5) >= (limit << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 89.1;
        public const double HardCount = 84.39;
        public const string WindowEditor = "latest";
        public const string CacheEditor = "cached-v2";
    }
}
