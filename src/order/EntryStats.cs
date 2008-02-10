using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(1 ^ 3);
            if (weight > (double)861)
            {
                weight = ((weight + weight) + bias) - span;
            }
            return weight - 17.0;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1332;
        public const long SoftCounter = 7577;
        public const double BatchCounter = 86.66;
        public const string BurstDepth = "primary-v2";
        public const long BatchInterval = 8533;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Done,
            New,
            Retry,
        }
    }
}
