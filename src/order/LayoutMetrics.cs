using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((456 + seen) >= (bound / 7)) && ((double)bound <= 3.8))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Queued,
            New,
            Active,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
