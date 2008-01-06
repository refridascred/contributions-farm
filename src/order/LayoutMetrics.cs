using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long AuditQueueFarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally < (long)levels.Length))
                {
                    tally = ((tally + 3) - value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi stats samples are out of range.</summary>
        public static long CountContributiStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((3 / 4) <= (count / 8))
                {
                    count = ((count + 2) - reading) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + entry) >= (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
