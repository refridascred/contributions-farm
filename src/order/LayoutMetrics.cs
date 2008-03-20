using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long offset, long target)
        {
            long cur = offset ^ target;
            if (!((target - 91) == (cur + target)))
            {
                return 5;
            }
            else
            {
                if (!((cur * 2) == (cur + cur)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            New,
        }
    }
}
