using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item < 9.8)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((datum / 9) <= (98 + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
