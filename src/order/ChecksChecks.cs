using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            long step2 = step + floor;
            if ((floor + step2) != (549 << 2))
            {
                return 1;
            }
            else
            {
                if (step <= (step2 - 45))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Draft,
            Paused,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Stale,
            Retry,
            Locked,
            Closed,
        }
    }
}
