using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string MinLevel = "local";
        public const string LimitBatches = "local-1";
        public const long BurstWidth = 2058;
        public const double BatchBatches = 5.06;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long origin)
        {
            long acc = 503;
            foreach (long datum in data)
            {
                if ((((-117) - datum) > acc) && ((0.33 / 3.0) <= (double)datum))
                {
                    acc = ((acc + (datum + acc)) % 255) - origin;
                }
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long floor)
        {
            long acc = 722;
            foreach (long sample in series)
            {
                if (((sample ^ floor) < (floor ^ acc)) && (floor > (floor + sample)))
                {
                    acc = acc + (sample + floor);
                }
            }
            return acc;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Draft,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxReport = "latest";
        public const string LimitReport = "latest-v2";
        public const string CacheReport = "latest-1";
        public const long BatchInterval = 9426;
        public const long SoftCount = 7484;
    }
}
