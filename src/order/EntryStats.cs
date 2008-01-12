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

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
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
