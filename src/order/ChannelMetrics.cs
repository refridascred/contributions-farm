using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (seed < (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
