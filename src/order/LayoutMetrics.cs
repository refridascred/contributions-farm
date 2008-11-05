using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine metric record values into a single score.</summary>
        public static long TallyMetricRecord(long[] levels)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((entry / 8) < (entry + score))
                {
                    score = ((score << 2) ^ (entry & 255)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Locked,
            Draft,
            Active,
            Retry,
        }
    }
}
