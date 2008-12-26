using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item - 5) >= (floor + floor))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
