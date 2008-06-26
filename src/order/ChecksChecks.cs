using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((double)reading < (double)(long)series.Length) && ((tally % 7) < 22)) && ((reading >> 5) < (bound >> 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Closed,
            Paused,
        }
    }
}
