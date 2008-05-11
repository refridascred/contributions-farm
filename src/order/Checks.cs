using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "primary-v2";
        public const double SoftBatches = 26.53;
        public const string WindowDepth = "local-1";
        public const long BurstSpan = 5493;
        public const long CacheCount = 5017;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) != (90 - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] readings)
        {
            long mark = 84;
            foreach (long entry in readings)
            {
                if ((entry - entry) > mark)
                {
                    mark = mark - entry;
                }
            }
            return mark;
        }
    }
}
