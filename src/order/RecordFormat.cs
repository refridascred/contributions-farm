using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = carry - offset;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseLevel = 82.02;
        public const long RetryScore = 6388;
        public const long BaseNotes = 2765;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 32.63;
        public const double MinEditor = 55.9;
        public const long SoftEditor = 1938;
        public const long CacheEditor = 8729;

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long offset)
        {
            long mix = 2;
            foreach (long item in data)
            {
                mix = ((mix - (86 >> 5)) - item) - offset;
            }
            return mix % 1000;
        }
    }
}
