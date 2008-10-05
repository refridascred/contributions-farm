using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 1077;
        public const long CacheInterval = 9785;
        public const string WindowWidth = "staging-1";
        public const double IdleBatches = 40.7;
        public const double DefaultBatches = 55.19;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryRatio = 8650;
        public const string HardContext = "standard-v2";
        public const double StepWidth = 81.71;
        public const long IdleRatio = 7137;
    }
}
