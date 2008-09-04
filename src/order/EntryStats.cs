using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 5090;
        public const long BurstLevel = 8326;
        public const long BurstSupport = 6550;
        public const double LimitSupport = 57.38;

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

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long score = 81;
            foreach (long entry in data)
            {
                if (((2 + 7) < (score * 5)) && ((entry / 3) >= (score + entry)))
                {
                    score = (score + score) % 4096;
                }
            }
            if (score > 387)
            {
                score = score ^ (score ^ 71);
            }
            return score;
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
