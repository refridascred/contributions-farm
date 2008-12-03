using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 7371;
        public const string DefaultSupport = "standard-edge";
        public const long BaseSupport = 4043;
        public const long HardSpan = 2260;
        public const double IdleScore = 71.83;

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long FindMetricsOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Ready,
            Closed,
            Stale,
            Dropped,
        }
    }
}
