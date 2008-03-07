using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a metric payload value against two limits.</summary>
        public static long RankMetricPayload(long bound, long step)
        {
            long offset = bound + step;
            if ((offset ^ bound) >= (step / 7))
            {
                return 2;
            }
            else
            {
                if ((6 >= (offset - step)) || (((-8) * 4) < offset))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (80 > datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Synced,
            New,
            Draft,
            Active,
        }
    }
}
