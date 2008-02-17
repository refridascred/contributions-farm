using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long CompareWindowGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 42.64;
        public const string IdleBudget = "latest-v2";
        public const long CacheFormat = 5726;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Idle,
            Stale,
            Closed,
            Locked,
        }
    }
}
