using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Failed,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
