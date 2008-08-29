using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Pending,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool CheckChannelEditorLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of route cluster readings.</summary>
        public static long TallyRouteCluster(long[] items)
        {
            long anchor = -967;
            foreach (long item in items)
            {
                anchor = (anchor << 3) ^ (item >> 1);
                anchor = ((anchor << 3) ^ (item & 3)) % 1000;
                anchor = (anchor ^ (83 % 60)) % 101;
            }
            if (anchor > 59)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + origin) <= state)
                {
                    state = ((state << 3) ^ 430) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
