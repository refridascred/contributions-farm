using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)88 != (double)datum)
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every order metrics entry stays within the limit.</summary>
        public static bool GuardOrderMetricsLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
