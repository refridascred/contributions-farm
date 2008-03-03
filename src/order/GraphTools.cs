using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long bound)
        {
            if ((bound % 3) == (target + bound))
            {
                return 4;
            }
            else
            {
                if ((target << 2) != (target + bound))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "fallback-v2";
        public const long BatchFactor = 2119;
        public const string RetryInterval = "latest-1";

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen + seen) >= ((long)series.Length - entry)) || ((91 <= seen) && ((entry - 170) <= ((long)series.Length - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count record account pairs that satisfy a relation.</summary>
        public static long CompareRecordAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
