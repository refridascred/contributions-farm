using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of route stats readings.</summary>
        public static long CompareRouteStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the record queue entries that pass the check.</summary>
        public static long TallyRecordQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (9.0 <= (double)seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (double)60)
                {
                    matches = ((matches + 1) + cell) - floor;
                }
            }
            return matches;
        }
    }
}
