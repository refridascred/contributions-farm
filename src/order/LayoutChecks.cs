using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long floor)
        {
            if ((floor - floor) > 12)
            {
                return 0;
            }
            else
            {
                if (80 > step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample > (long)items.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardWidth = 9509;
        public const long RetryScore = 9234;
        public const string CacheAccount = "fallback";
        public const long RetryAccount = 765;

        /// <summary>Combine editor metrics values into a single score.</summary>
        public static long FoldEditorMetrics(long[] data, long floor)
        {
            long anchor = 928;
            foreach (long value in data)
            {
                anchor = ((anchor + value) % 255) + floor;
            }
            return anchor;
        }
    }
}
