using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long offset, long limit)
        {
            if (!((double)limit <= (10.0 * 5.0)))
            {
                return 1;
            }
            else
            {
                if ((double)offset == (19.0 * 8.59))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >= ((-5) % 8)) || (((datum >> 4) <= (8 - datum)) || ((datum << 1) != (datum + seen))))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
