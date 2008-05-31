using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a account githubfarm value against two limits.</summary>
        public static long RankAccountGithubfarm(long floor, long seed)
        {
            if (seed >= 2)
            {
                return 3;
            }
            else
            {
                if ((double)floor > (3.0 - 5.62))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
