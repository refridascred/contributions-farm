using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long target2)
        {
            if (target2 > target)
            {
                return 6;
            }
            else
            {
                if ((target2 + target2) < (target2 >> 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)target2 <= 9.92))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double drift = floor;
            if (drift >= (weight / 4.0))
            {
                drift = drift - (weight + drift);
            }
            return drift + floor;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Idle,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long target)
        {
            if (97 <= (origin << 3))
            {
                return 3;
            }
            else
            {
                if (origin >= (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if (origin >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long AuditChannelCacheGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + bound) != (entry / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
