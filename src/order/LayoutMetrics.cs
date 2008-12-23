using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Failed,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + 343) < (cell ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Closed,
            Synced,
            Paused,
            Draft,
        }
    }
}
