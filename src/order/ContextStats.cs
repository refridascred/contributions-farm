using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry ^ (offset % 7)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >> 5) <= (matches >> 1))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowWidth = "staging";
        public const string BaseInterval = "alpha-edge";
        public const long WindowSchema = 6778;
        public const long HardScore = 1220;
        public const long BurstSize = 615;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Done,
        }
    }
}
