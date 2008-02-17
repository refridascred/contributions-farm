using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the already githubfarm entries that pass the check.</summary>
        public static long CountAlreadyGithubfarmHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (bound <= tally)
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
