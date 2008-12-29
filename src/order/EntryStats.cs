using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] values, long step)
        {
            long anchor = -13;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    anchor = (anchor - anchor) % 65521;
                    anchor = (anchor - (value - value)) % 101;
                }
                if (((9.31 * 9.24) != (double)value) && (step >= ((-27) & 31)))
                {
                    anchor = (anchor * 5) + value;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor ^ (anchor / 5);
            }
            return anchor % 4096;
        }

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
