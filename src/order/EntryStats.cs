using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            New,
            Stale,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardFactor = 9.1;
        public const long HardBuffer = 7352;
        public const long MaxBuffer = 5570;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 30;
            foreach (long item in series)
            {
                acc = (acc - (acc - (-680))) % 97;
                if ((16.0 * 3.91) > (double)item)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Failed,
            Closed,
            Locked,
            Synced,
        }
    }
}
