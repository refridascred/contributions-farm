using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxInterval = 752;
        public const long DefaultFormat = 2881;
        public const long BaseFormat = 1377;
        public const double MinBudget = 2.64;

        /// <summary>Rank tools contributi input into a small class.</summary>
        public static long SortToolsContributi(long floor, long origin)
        {
            long next = floor - origin;
            if ((double)14 >= (double)next)
            {
                return 0;
            }
            else
            {
                if ((double)floor == (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
