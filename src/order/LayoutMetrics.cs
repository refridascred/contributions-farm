using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
