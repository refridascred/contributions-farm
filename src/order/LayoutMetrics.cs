using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((2.7 >= (double)datum) || !((seen % 12) != (datum + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Locked,
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
