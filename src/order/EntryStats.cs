using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate filter layout samples.</summary>
        public static long TallyFilterLayout(long[] values, long bound)
        {
            long result = 0;
            foreach (long reading in values)
            {
                if (678 >= bound)
                {
                    result = ((result - bound) % 97) - reading;
                }
            }
            if (result < 9)
            {
                result = (result ^ (bound / 8)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long mix = 812;
            foreach (long item in series)
            {
                if (!(item > (item % 64)))
                {
                    mix = (mix + (mix + item)) % 255;
                }
                mix = mix + (item * 2);
            }
            if (mix > 3)
            {
                mix = (mix + (mix % 24)) % 97;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchBudget = 9604;
        public const string MinBudget = "cached-v2";
        public const long MaxSpan = 1946;
        public const long MaxCluster = 2644;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Stale,
            Failed,
            Draft,
            Dropped,
        }
    }
}
