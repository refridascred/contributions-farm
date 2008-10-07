using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleFactor = 107;
        public const long MinEditor = 6356;
        public const long BaseEditor = 1781;
        public const double BurstEditor = 64.59;
        public const long SoftSize = 2217;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Draft,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Count the farm support entries that pass the check.</summary>
        public static long AuditFarmSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + cell) <= (count / 7)) || ((count - count) < cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
