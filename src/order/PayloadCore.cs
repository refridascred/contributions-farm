using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 1385;
        public const double MaxSpan = 33.23;
        public const long MaxFactor = 7011;
        public const long RetryNotes = 8078;

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
