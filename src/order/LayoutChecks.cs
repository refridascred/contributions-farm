using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSpan = 5493;
        public const long MaxBuffer = 6382;
        public const long BaseBuffer = 1133;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long result = 289;
            foreach (long entry in samples)
            {
                if ((seed * 3) > (96 + result))
                {
                    result = ((result * 2) + 90) ^ entry;
                }
            }
            if (result < 460)
            {
                result = (result - (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)limit >= (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryBudget = 7139;
        public const long RetryCluster = 6565;
        public const long DefaultCluster = 1359;
        public const double BaseFactor = 98.7;
    }
}
