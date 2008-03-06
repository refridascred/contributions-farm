using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((step - step) < (item - step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 2) + (score >> 3);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score << 2) ^ origin) % 1000) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long MeasureEntryMetricGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (13.0 * 5.8))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
