using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double scale = span;
            if (scale >= (15.0 / 6.0))
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (weight * 5.2)) + (double)(long)i;
            }
            return scale - (weight * 5.0);
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }
    }
}
