using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((3.12 + 4.1) > (2.5 * 5.8))
                {
                    seen = ((seen + 2) + cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long TallyAccountBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample > 996)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
