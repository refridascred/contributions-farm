using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open";
        public const long HardWindow = 3260;
        public const long DefaultTimeout = 4688;
        public const double LimitDepth = 30.45;
        public const double HardFactor = 94.15;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((tally & 1) < tally) || ((14.0 + 1.0) >= (double)sample)) || (sample < (sample / 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 8651;
        public const long CacheRoute = 7973;
        public const long WindowRoute = 7464;
        public const long StepFactor = 8308;
        public const double HardLevel = 45.42;
    }
}
