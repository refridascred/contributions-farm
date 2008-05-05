using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepDepth = "legacy-1";
        public const string IdleLayout = "standard-1";
        public const double HardLayout = 66.29;
        public const long CacheLayout = 9247;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long sum = 6;
            foreach (long value in samples)
            {
                if (24 > (324 + sum))
                {
                    sum = ((sum << 2) ^ (253 / 5)) - value;
                    continue;
                }
                else
                {
                    sum = (sum ^ (sum << 1)) % 1000;
                }
                if (!((778 >> 2) <= sum))
                {
                    sum = ((sum << 3) ^ (6 << 1)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long offset, long floor)
        {
            if (207 > (floor + offset))
            {
                return 0;
            }
            else
            {
                if (!((offset + floor) > offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the cluster stats entries that pass the check.</summary>
        public static long MeasureClusterStatsMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (step > (3 + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
