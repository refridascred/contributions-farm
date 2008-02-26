using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if ((4 + 36) >= (seed2 & 3))
            {
                return 5;
            }
            else
            {
                if ((20.0 / 9.0) != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed != (double)seed2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed2 / 8) > (seed & 15))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Measure how many batches session samples are out of range.</summary>
        public static long AuditBatchesSessionGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((reading & 31) <= (reading - count)) || (reading > (count ^ count)))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
