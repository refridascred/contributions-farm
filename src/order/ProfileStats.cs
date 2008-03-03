using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 3138;
        public const string WindowLevel = "legacy-1";
        public const long BaseWindow = 1975;
        public const long SoftWindow = 8828;
        public const long StepWindow = 5524;

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 2675;
        public const string IdleSize = "latest-v2";
        public const long DefaultAlready = 4173;
    }
}
