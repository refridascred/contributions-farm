using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstDepth = 33.49;
        public const long RetryLayout = 8226;
        public const string WindowCount = "fallback-1";
        public const long MaxSpan = 8807;
        public const long BaseWidth = 2277;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Queued,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((step + step) == (step & 31)) && ((84 - 46) <= (reading - step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Locked,
            Synced,
            Pending,
        }
    }
}
