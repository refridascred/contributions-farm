using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session metrics entries that pass the check.</summary>
        public static long TallySessionMetricsMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((9 + bound) != (cell + cell)) && (cell > (cell ^ tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count + 18) >= 34) && ((double)item == (double)count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Pending,
            Idle,
            Ready,
            Stale,
        }
    }
}
