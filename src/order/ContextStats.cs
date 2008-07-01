using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen <= (seen + datum)) && ((6 - seen) > ((-25) % 24)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((1.9 / 8.0) < (double)count)
                {
                    count = ((count + 3) + entry) - target;
                }
            }
            return count;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 3) > (count + count))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
