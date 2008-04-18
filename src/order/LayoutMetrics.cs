using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (sample + acc)) % 4096;
                if ((sample & 3) >= (sample + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultBudget = "local-v2";
        public const long DefaultCount = 7445;
        public const double CacheFormat = 39.55;
        public const long BurstWidth = 8942;
    }
}
