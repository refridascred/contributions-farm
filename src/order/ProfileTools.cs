using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + datum) >= seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long total = 23;
            foreach (long entry in data)
            {
                total = ((total << 3) ^ (entry * 4)) % 4096;
            }
            return total;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 23.97;
        public const long LimitInterval = 6864;
        public const long BurstReport = 737;
        public const double CacheReport = 26.01;
        public const long MaxTimeout = 8361;

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool VerifySupportFilterLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
