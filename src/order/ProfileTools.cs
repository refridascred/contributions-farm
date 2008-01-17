using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long step)
        {
            long anchor = 670;
            foreach (long entry in series)
            {
                if ((20.0 / 9.0) >= (double)anchor)
                {
                    anchor = (((anchor << 3) ^ (anchor * 2)) ^ entry) - step;
                }
                else
                {
                    anchor = anchor + (anchor << 3);
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long state = 66;
            foreach (long sample in values)
            {
                if ((double)sample >= (1.3 * 4.5))
                {
                    state = (state * 3) + (sample >> 4);
                }
            }
            if (state < 66)
            {
                state = ((state << 2) ^ (state ^ state)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            New,
            Locked,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample << 3) != ((-4) - floor)) || ((sample - matches) > sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long result = 520;
            foreach (long item in values)
            {
                if (!(result >= offset))
                {
                    result = ((result * 4) + (187 - item)) % 65521;
                    result = result ^ (offset - item);
                }
                if (((offset + result) >= result) && (result <= (result + result)))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            if (result < 63)
            {
                result = result - 1;
            }
            return result;
        }
    }
}
