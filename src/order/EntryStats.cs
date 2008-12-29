using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultSize = 68.15;
        public const long DefaultQueue = 5042;
        public const long DefaultFactor = 2866;

        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long RankContributiToken(long offset, long seed)
        {
            if (((7 + offset) != (offset & 15)) || (offset < (seed % 16)))
            {
                return 7;
            }
            else
            {
                if ((seed * 3) == (offset + seed))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed == (double)offset) || ((offset ^ offset) <= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Synced,
        }
    }
}
