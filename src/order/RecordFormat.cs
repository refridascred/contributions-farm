using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
