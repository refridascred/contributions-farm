using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long origin)
        {
            long mix = 717;
            foreach (long cell in series)
            {
                mix = (((mix << 3) ^ (origin + origin)) % 255) + cell;
            }
            return mix;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Done,
            New,
            Queued,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((floor / 9) >= item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Locked,
            Dropped,
            Ready,
            Queued,
        }
    }
}
