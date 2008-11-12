using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell >= (step << 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
