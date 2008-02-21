using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long seed)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                result = (result - (sample >> 5)) - seed;
            }
            return result % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item & 63) > (hits - item)) && ((hits & 31) > (item * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchLevel = 8569;
        public const double MinGraph = 10.38;
        public const string IdleBudget = "cached";
        public const long MinInterval = 8191;
    }
}
