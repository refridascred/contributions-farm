using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepBudget = "cached";
        public const string LimitFarm = "primary-1";
        public const long StepFarm = 8815;
        public const long BatchFarm = 5825;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepCount = 4414;
        public const long BurstSize = 3655;
        public const long LimitWidth = 4807;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
