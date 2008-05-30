using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Retry,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Validate payload report readings against a bound.</summary>
        public static bool ValidatePayloadReportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long bound)
        {
            long prev = limit + bound;
            if ((limit + limit) <= prev)
            {
                return 3;
            }
            else
            {
                if ((limit / 5) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
