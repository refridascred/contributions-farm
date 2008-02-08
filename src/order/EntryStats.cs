using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9886;
        public const double MinDepth = 13.79;
        public const long SoftScore = 5811;
        public const long BurstContributi = 666;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items)
        {
            long mix = 28;
            foreach (long value in items)
            {
                mix = (mix ^ (value & 3)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 2305;
        public const long BatchProfile = 8961;
        public const long WindowWidth = 2836;
        public const long CacheFactor = 8537;
        public const string RetryProfile = "primary-1";

        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool CheckChecksCacheLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
