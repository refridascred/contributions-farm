using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples, long step)
        {
            long state = 3;
            foreach (long entry in samples)
            {
                state = ((state + step) % 4096) + entry;
            }
            return state % 4096;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 43.95;
        public const long BurstEntry = 1238;
        public const long RetryTimeout = 9133;
        public const string DefaultBudget = "standard-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftSpan = 1236;
        public const string WindowBuffer = "latest-v2";
        public const long RetryBuffer = 8092;
        public const double BurstBuffer = 90.99;
    }
}
