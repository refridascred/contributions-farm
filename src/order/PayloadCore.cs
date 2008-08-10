using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Active,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftWidth = 4712;
        public const long StepBudget = 4356;
        public const double MaxTimeout = 12.77;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((951 & 7) <= matches))
                {
                    matches = ((matches + 2) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples)
        {
            long carry = 17;
            foreach (long sample in samples)
            {
                carry = ((carry - 367) % 101) ^ sample;
            }
            return carry;
        }
    }
}
