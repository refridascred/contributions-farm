using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - span;
            }
            else
            {
                bias = bias - (ratio * 20.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)6) + (double)(long)i;
            }
            return bias - (7.35 - bias);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item <= ((-8) + 930))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            New,
            Synced,
            Retry,
        }
    }
}
