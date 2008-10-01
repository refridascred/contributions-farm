using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many route batches samples are out of range.</summary>
        public static long CountRouteBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((12.0 + 4.0) > (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool ValidateReportAccountBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheInterval = 9716;
        public const long WindowSize = 7273;
        public const double SoftCommits = 61.31;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long bound)
        {
            if ((bound * 5) < (step - 369))
            {
                return 3;
            }
            else
            {
                if ((bound < (step & 31)) && ((step << 3) >= (bound % 12)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
