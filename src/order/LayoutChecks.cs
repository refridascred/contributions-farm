using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double bias = 3.88;
            if (bias >= (offset + offset))
            {
                bias = bias - 9.68;
            }
            else
            {
                bias = bias + (scale * 8.4);
            }
            return bias - (offset + 20.0);
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Queued,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Validate route format readings against a bound.</summary>
        public static bool ValidateRouteFormatLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Draft,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double gain = (bias + 1.0) - (2.29 - rate);
            return gain + (double)55;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
