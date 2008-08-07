using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if ((offset - bound) < (64 ^ bound))
            {
                return 1;
            }
            else
            {
                if (offset <= (8 >> 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
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

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Ready,
            Synced,
            Queued,
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

        /// <summary>Find the first notes report entry that matches the target.</summary>
        public static long LocateNotesReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
