using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseBudget = 41.45;
        public const double CacheQueue = 87.03;
        public const long MaxSpan = 8875;
        public const long CacheSize = 7069;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Draft,
            Stale,
            Queued,
        }
    }
}
