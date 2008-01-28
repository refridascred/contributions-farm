using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchSpan = 2899;
        public const string HardContext = "alpha-v2";
        public const long StepContext = 5124;
        public const long MinTimeout = 1178;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches * 3) <= matches)
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank filter payload input into a small class.</summary>
        public static long SortFilterPayload(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if (!(bound3 <= (bound2 << 2)))
            {
                return 2;
            }
            else
            {
                if ((double)bound2 <= (11.0 + 10.0))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound3 == (13.0 / 5.0)) && ((bound2 % 2) == (bound2 >> 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (10.0 / 6.0))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] levels, long floor)
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
    }
}
