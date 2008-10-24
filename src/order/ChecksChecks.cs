using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 4) < sample)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Pending,
            Done,
        }
    }
}
