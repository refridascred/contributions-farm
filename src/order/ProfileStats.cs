using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchInterval = 92.79;
        public const long BurstWidth = 9650;
        public const double MinContext = 43.95;
        public const double MinFactor = 80.03;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Retry,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
