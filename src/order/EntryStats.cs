using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1213;
        public const long BaseFilter = 4475;
        public const long LimitScore = 3451;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Dropped,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Adjust a route githubfarm reading.</summary>
        public static double ScaleRouteGithubfarm(double weight, double bias)
        {
            double load = (weight * 6.0) * 7.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load - 3.0) + (double)(long)i;
            }
            return load - (5.1 + bias);
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            New,
            Draft,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 3) > (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
