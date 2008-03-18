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

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long step)
        {
            long step2 = bound + step;
            if ((859 ^ step) > step2)
            {
                return 4;
            }
            else
            {
                if ((double)step < (5.11 + 7.9))
                {
                    return 7;
                }
                else
                {
                    if ((step2 + bound) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
