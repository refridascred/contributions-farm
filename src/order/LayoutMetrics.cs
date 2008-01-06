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

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool VerifyCacheGraphBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
