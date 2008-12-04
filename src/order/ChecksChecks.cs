using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4.0 * 4.0) < (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
