using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a batch already sample.</summary>
        public static long FindBatchAlreadyIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long limit)
        {
            if ((double)origin == (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a route queue sample.</summary>
        public static long SeekRouteQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long limit, long bound)
        {
            long gap = limit - bound;
            if ((bound + gap) < (bound - bound))
            {
                return 8;
            }
            else
            {
                if ((5 & 3) != (gap & 63))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
