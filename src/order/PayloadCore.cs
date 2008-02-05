using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples)
        {
            long mark = 853;
            foreach (long item in samples)
            {
                mark = mark - (mark - item);
                if (4.05 < (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (2.0 + 4.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Active,
            New,
            Stale,
            Retry,
        }
    }
}
