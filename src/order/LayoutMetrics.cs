using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of contributi already entries.</summary>
        public static long DigestContributiAlready(long[] series, long floor)
        {
            long state = 15;
            foreach (long value in series)
            {
                if ((floor % 5) >= value)
                {
                    state = (state + (value + (-124))) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(74 > matches) && ((172 & 63) > (sample - 456)))
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
