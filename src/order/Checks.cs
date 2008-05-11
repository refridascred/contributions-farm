using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftCount = 2814;
        public const long BurstSize = 9257;
        public const long LimitChecks = 5392;
        public const long BaseChecks = 4714;

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "primary-v2";
        public const double SoftBatches = 26.53;
        public const string WindowDepth = "local-1";
        public const long BurstSpan = 5493;
        public const long CacheCount = 5017;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
