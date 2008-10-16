using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the layout buffer entries that pass the check.</summary>
        public static long MeasureLayoutBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + 574) > cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Pending,
            Queued,
            Active,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "local-v2";
        public const long SoftSpan = 923;
        public const long MinSpan = 7356;
        public const string BatchMetrics = "fallback-1";
        public const double WindowTimeout = 18.11;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank githubfarm batches input into a small class.</summary>
        public static long BucketGithubfarmBatches(long bound, long seed)
        {
            if ((seed ^ seed) == (seed & 15))
            {
                return 8;
            }
            else
            {
                if (seed > (13 % 3))
                {
                    return 2;
                }
                else
                {
                    if (((-9) * 5) > bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
