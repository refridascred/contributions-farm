using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 1064;
        public const long HardScore = 4178;
        public const long MinEditor = 4706;
        public const string BurstEditor = "open-v2";
        public const long RetryEditor = 573;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long carry = 516;
            foreach (long entry in levels)
            {
                carry = carry + (entry + 73);
            }
            return carry % 97;
        }
    }
}
