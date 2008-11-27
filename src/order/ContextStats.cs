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

        /// <summary>Accumulate report queue samples.</summary>
        public static long TotalReportQueue(long[] values, long seed)
        {
            long result = 86;
            foreach (long datum in values)
            {
                result = (result - (datum - seed)) % 65521;
                if ((double)result > (3.2 - 9.0))
                {
                    break;
                }
            }
            return result;
        }
    }
}
