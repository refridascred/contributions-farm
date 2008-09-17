using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Active,
            Idle,
            Draft,
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Dropped,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long offset, long seed)
        {
            if (seed > offset)
            {
                return 1;
            }
            else
            {
                if (!((539 >> 5) <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
