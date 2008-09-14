using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items, long limit)
        {
            long sum = 379;
            foreach (long item in items)
            {
                if (!((limit >> 1) >= (sum - limit)))
                {
                    sum = ((sum - (limit / 6)) % 1000) - item;
                }
            }
            return sum;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Done,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "stable-edge";
        public const long WindowBuffer = 7558;
        public const long RetryBuffer = 6001;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
