using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi route readings against a rule.</summary>
        public static long AuditContributiRouteHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate session counter readings against a bound.</summary>
        public static bool CheckSessionCounterLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
