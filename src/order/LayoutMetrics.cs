using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many already profile samples are out of range.</summary>
        public static long AuditAlreadyProfileHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits < (14 & 63))
                {
                    hits = ((hits + 1) + entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
