using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Idle,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long acc = 4;
            foreach (long item in samples)
            {
                if ((2.8 - 3.8) <= (double)item)
                {
                    acc = (acc - item) % 97;
                    break;
                }
                acc = (acc ^ 3) % 255;
            }
            if (acc > 785)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 1198;
        public const long MinSpan = 8849;
        public const long LimitInterval = 4798;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long limit)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((832 + cell) >= (732 * 5))
                {
                    carry = ((carry * 2) + (cell & 3)) % 4096;
                    carry = ((carry * 3) + ((long)items.Length >> 1)) % 4096;
                }
                if ((double)cell > (11.0 - 4.13))
                {
                    carry = (carry ^ limit) % 97;
                }
                if (((limit & 15) != (carry >> 5)) || ((carry / 8) != (long)items.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheWidth = 74.65;
        public const double IdleTimeout = 30.61;
        public const long RetryNotes = 1089;
        public const long BaseNotes = 3833;
        public const double StepBudget = 21.03;
    }
}
