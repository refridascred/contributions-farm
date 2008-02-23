using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((double)result >= (3.5 + 4.3)) && ((44 + result) < (bound / 7)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((71 & 3) <= (entry & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Dropped,
            Idle,
            Pending,
        }
    }
}
