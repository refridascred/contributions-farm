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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
