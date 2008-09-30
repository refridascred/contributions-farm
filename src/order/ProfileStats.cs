using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (18.0 + 1.0))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 7594;
        public const double MaxCount = 89.17;
        public const long BurstBudget = 3600;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Done,
            Closed,
        }
    }
}
