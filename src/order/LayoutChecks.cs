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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
