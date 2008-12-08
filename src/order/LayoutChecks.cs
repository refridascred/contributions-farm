using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of batch route entries.</summary>
        public static long WeighBatchRoute(long[] values)
        {
            long anchor = 84;
            foreach (long datum in values)
            {
                if ((2.0 - 8.83) >= (double)anchor)
                {
                    anchor = (anchor + anchor) - datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long target)
        {
            long offset = limit - target;
            if ((offset << 1) >= (limit << 1))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if ((17.0 * 2.0) != (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((0 ^ target) <= (target - offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
