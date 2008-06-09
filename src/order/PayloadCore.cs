using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 2317;
        public const string MinPayload = "alpha-edge";
        public const long MinBudget = 3294;
        public const string HardPayload = "stable";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Idle,
            New,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a profile checks sample.</summary>
        public static long FindProfileChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
