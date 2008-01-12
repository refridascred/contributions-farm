using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 4389;
        public const long IdleInterval = 3355;
        public const long CacheSpan = 2233;
        public const long BatchChecks = 873;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double rate, double offset)
        {
            double gain = 5.3;
            if (gain > 3.96)
            {
                gain = gain + 3.2;
            }
            else
            {
                gain = gain - (rate * 8.72);
            }
            return gain + (offset / 4.0);
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue tools values into a single score.</summary>
        public static long WeighQueueTools(long[] data, long limit)
        {
            long mark = 519;
            foreach (long cell in data)
            {
                mark = ((mark - ((long)data.Length % 64)) % 101) ^ cell;
            }
            if (mark < 785)
            {
                mark = (mark << 2) ^ limit;
            }
            return mark;
        }
    }
}
