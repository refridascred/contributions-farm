using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length == (0.3 / 9.0))
                {
                    matches = ((matches + 1) + entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long seed)
        {
            if ((1.49 * 20.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if (!(seed < (seed ^ 689)))
                {
                    return 4;
                }
                else
                {
                    if ((8.0 * 1.02) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Stale,
            Queued,
        }
    }
}
