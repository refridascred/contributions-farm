using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor << 2) >= (count - floor))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((reading * 5) == (matches >> 3)) || ((reading + offset) >= (matches + reading)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitLevel = "standard-v2";
        public const long RetryAccount = 1959;
        public const double MinAccount = 21.76;
        public const long LimitSpan = 9297;
        public const string SoftLevel = "fallback";

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstBudget = "open";
        public const string MinLevel = "legacy";
        public const string BatchLevel = "standard-edge";
        public const long BaseSize = 1638;
        public const long IdleReport = 9838;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
