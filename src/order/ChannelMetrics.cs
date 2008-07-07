using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultWidth = 426;
        public const string BatchBudget = "local-1";
        public const long LimitQueue = 5971;
        public const long BurstQueue = 8207;
        public const double HardQueue = 47.24;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seed + seed) > 930)
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
