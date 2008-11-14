using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Paused,
            New,
            Done,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-v2";
        public const double IdleTools = 94.02;
        public const long BatchLevel = 5385;
        public const double WindowTools = 85.83;

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Retry,
            Done,
            Active,
            Closed,
        }
    }
}
