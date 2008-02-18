using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value == (1.1 / 3.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 6462;
        public const long DefaultBatch = 9522;
        public const string LimitFactor = "open-1";
        public const long MinBatch = 6926;
        public const long IdleLevel = 5425;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Failed,
            Paused,
            Synced,
        }
    }
}
