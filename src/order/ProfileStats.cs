using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double drift = (floor * 9.13) - (ratio - floor);
            return drift + (double)95;
        }

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool ValidateNotesRouteBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBudget = 94.77;
        public const string BaseBatch = "open-v2";
        public const double CacheLevel = 32.65;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Draft,
            Paused,
        }
    }
}
