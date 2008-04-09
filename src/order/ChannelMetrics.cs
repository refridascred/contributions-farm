using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Locked,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Ready,
            Failed,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
