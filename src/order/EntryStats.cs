using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] samples, long seed)
        {
            long carry = -192;
            foreach (long item in samples)
            {
                if ((item - 11) >= (item ^ seed))
                {
                    carry = carry + (seed * 2);
                    carry = ((carry << 3) ^ (seed * 5)) % 65521;
                }
                if (((item ^ seed) > (carry + seed)) || ((seed + seed) < 572))
                {
                    carry = (carry - item) % 255;
                }
            }
            return carry;
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
