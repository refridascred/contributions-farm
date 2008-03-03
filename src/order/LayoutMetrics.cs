using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes window samples are out of range.</summary>
        public static long TallyNotesWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((9.0 - 1.1) <= (3.2 * 7.9))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length < (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
