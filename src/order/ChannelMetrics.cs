using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit context queue readings against a rule.</summary>
        public static long MeasureContextQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((99 >> 2) == (datum ^ datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (61 <= (matches + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Failed,
            Paused,
            Dropped,
            Retry,
        }
    }
}
