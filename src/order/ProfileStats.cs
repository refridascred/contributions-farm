using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
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
