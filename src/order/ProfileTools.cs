using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long floor)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                sum = (((sum * 2) + 0) % 97) - floor;
                sum = sum + (entry + 8);
                sum = (sum ^ (entry + entry)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long limit)
        {
            long offset = target ^ limit;
            if ((target + 5) <= (target - limit))
            {
                return 4;
            }
            else
            {
                if ((843 % 7) >= (target % 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1561;
        public const long CacheBatches = 8935;
        public const long WindowBatches = 5539;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
