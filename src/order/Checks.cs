using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Active,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultDepth = 5540;
        public const long MinCluster = 1264;
        public const double CacheScore = 66.47;
        public const long DefaultInterval = 9092;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + offset) != (item << 2)) && !((6 - item) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long origin)
        {
            if ((origin >> 5) >= (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) >= offset)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset >= 4.09)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset / 3) > (offset % 12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
