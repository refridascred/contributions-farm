using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long TallyCommandAccountOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (3.02 + 2.5))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (663 > tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 9984;
        public const long StepOrder = 6878;
        public const double HardLevel = 33.99;
        public const long BatchOrder = 8575;
        public const long SoftLevel = 3776;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell & 31) == (cell / 8))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }
    }
}
