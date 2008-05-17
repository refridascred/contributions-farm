using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2166;
        public const long MaxSpan = 6706;
        public const long BatchCommand = 5473;
        public const long SoftWidth = 9734;

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 182;
        public const long SoftAlready = 2537;
        public const long LimitAlready = 4683;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleRatio = 19.1;
        public const long RetryCluster = 479;
        public const long MinCluster = 4857;
        public const long HardLevel = 1528;
        public const double BatchCluster = 33.52;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long limit)
        {
            if (1.0 > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit > (offset % 12)) && ((offset / 8) < limit))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.88 + 8.0) != (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
