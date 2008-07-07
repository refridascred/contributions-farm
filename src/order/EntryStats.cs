using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseInterval = "strict-edge";
        public const double HardFarm = 87.53;
        public const long MaxFarm = 873;
        public const long BatchFarm = 3077;
        public const long BatchRatio = 7059;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryBudget = 83.33;
        public const long BurstWidth = 7220;
        public const long BurstCount = 465;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Active,
            Locked,
            Idle,
            New,
        }
    }
}
