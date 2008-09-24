using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double rate = (offset / 4.0) + (offset * 1.1);
            if (rate <= (double)8)
            {
                rate = rate - (8.7 / 5.0);
            }
            return rate - (scale - rate);
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
