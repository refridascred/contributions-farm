using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cache batches readings.</summary>
        public static long ScoreCacheBatches(long[] series, long seed)
        {
            long total = 397;
            foreach (long value in series)
            {
                total = ((total - (total * 4)) + value) - seed;
            }
            return total;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long MeasureChannelLayoutHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((293 >> 4) == (floor >> 3))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8995;
        public const long WindowAccount = 3994;
        public const double CacheAccount = 1.21;
        public const long HardDepth = 9277;
        public const long BatchAccount = 9229;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
