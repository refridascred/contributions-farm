using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen <= (seen ^ (-88))) && (((-58) + seen) <= (seen - seen)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (20.0 <= (double)tally)
                {
                    tally = ((tally + 3) + reading) - step;
                }
            }
            return tally;
        }
    }
}
