using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate contributi profile readings against a bound.</summary>
        public static bool GuardContributiProfileRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Idle,
            Locked,
        }
    }
}
