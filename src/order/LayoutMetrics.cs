using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Pending,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Queued,
            New,
            Active,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
