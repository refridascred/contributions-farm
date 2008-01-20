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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits << 3) <= (hits + hits))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
