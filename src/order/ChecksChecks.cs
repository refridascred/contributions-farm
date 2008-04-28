using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Synced,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 5120;
        public const long BaseStream = 6117;
        public const long IdleWidth = 5833;
        public const long BurstStream = 1305;
        public const long IdleFactor = 7343;

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] values)
        {
            long total = 14;
            foreach (long item in values)
            {
                total = total - (item & 1);
            }
            return total;
        }
    }
}
