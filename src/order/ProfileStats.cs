using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of stats session readings.</summary>
        public static long WeighStatsSession(long[] samples)
        {
            long result = 36;
            foreach (long datum in samples)
            {
                result = (((result * 4) + (30 & 255)) % 97) + datum;
            }
            if (result > 633)
            {
                result = (result << 3) ^ result;
            }
            return result;
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
