using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long MeasureTokenFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(origin < 5) && ((cell - origin) < (origin / 7)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Paused,
            Locked,
            Synced,
        }
    }
}
