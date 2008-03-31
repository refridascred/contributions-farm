using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Locked,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((slot + 8) < limit)
            {
                return 3;
            }
            else
            {
                if ((1.39 / 2.0) <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double scale = gain;
            if (scale < offset)
            {
                scale = scale - (7.85 * 4.85);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (gain / 4.0)) - (double)(long)i;
            }
            return scale - scale;
        }
    }
}
