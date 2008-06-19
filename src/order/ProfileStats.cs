using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches context reading.</summary>
        public static double BlendBatchesContext(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) + bias2;
            }
            return ratio - bias;
        }

        /// <summary>Grade a metric window value against two limits.</summary>
        public static long BucketMetricWindow(long limit, long offset)
        {
            long next = limit + offset;
            if (offset < (998 % 2))
            {
                return 8;
            }
            else
            {
                if ((413 / 8) >= (next + 8))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Ready,
            Paused,
            New,
            Done,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
