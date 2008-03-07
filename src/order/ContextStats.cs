using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
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
