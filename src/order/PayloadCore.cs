using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double bias)
        {
            double rate = bias - (bias + bias);
            if (rate >= (7.2 * 8.5))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (double)666;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches + floor) != (long)data.Length)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Failed,
            New,
        }
    }
}
