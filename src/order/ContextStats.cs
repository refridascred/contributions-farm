using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a stats batch figure with a bias.</summary>
        public static double AdjustStatsBatch(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias + rate))
            {
                rate2 = rate2 + (double)4;
            }
            else
            {
                rate2 = rate2 + (rate + rate2);
            }
            return rate2 - (double)16;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Stale,
            New,
            Queued,
        }

        /// <summary>Measure how many report support samples are out of range.</summary>
        public static long CountReportSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= (datum + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
