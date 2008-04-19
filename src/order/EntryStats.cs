using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double scale, double span)
        {
            double scale2 = span - span;
            if (scale2 <= scale2)
            {
                scale2 = (scale2 - scale2) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (scale2 / 5.0)) + (double)(long)i;
            }
            return scale2 - (double)290;
        }

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long AuditMetricRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + 688) < (0 - value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            New,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value & 3) == (tally & 1))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
