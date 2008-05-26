using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] items, long origin)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                anchor = (anchor << 2) ^ (anchor - item);
            }
            if (anchor > 116)
            {
                anchor = ((anchor * 2) + (origin % 16)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 15.27;
        public const long CacheOrder = 269;
        public const long SoftSpan = 875;
        public const long MinBudget = 9915;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits > (2.69 * 3.66))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
