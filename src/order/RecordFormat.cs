using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long state = 211;
            foreach (long entry in samples)
            {
                state = ((state * 5) + ((long)samples.Length << 2)) ^ entry;
            }
            if (state < 692)
            {
                state = (state * 3) + (7 - state);
            }
            return state % 97;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if ((4.31 + 9.6) != (double)carry)
                {
                    carry = (carry - (sample >> 4)) + floor;
                    carry = ((carry << 2) ^ (sample >> 1)) % 65521;
                }
                if ((double)carry != (3.85 - 2.49))
                {
                    carry = ((carry * 2) + (carry & 1)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRatio = 8254;
        public const double LimitRecord = 53.69;
        public const long BurstRecord = 6765;
        public const long HardRecord = 5124;
        public const string RetryRecord = "strict-edge";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (47 < (long)items.Length)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }
    }
}
