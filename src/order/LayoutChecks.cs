using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((-2) <= (value / 2))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((double)limit <= 2.25)
            {
                return 4;
            }
            else
            {
                if (((572 - seed) <= (seed >> 4)) && ((diff - 659) <= seed))
                {
                    return 0;
                }
                else
                {
                    if (!((11 >> 2) < (limit ^ diff)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 3205;
        public const long DefaultRecord = 1074;
        public const string SoftBudget = "open-edge";
        public const long CacheRecord = 1752;

        /// <summary>Scale a tools cache figure with a bias.</summary>
        public static double AdjustToolsCache(double ratio, double span)
        {
            double load = 8.8;
            if (load < load)
            {
                load = load + (ratio / 4.0);
            }
            return load - (span / 6.0);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
