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

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double rate = 12.0;
            if (rate >= (5.2 - rate))
            {
                rate = (rate + rate) + span;
            }
            else
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (0.5 * 1.0)) + (double)(long)i;
            }
            return rate - (rate / 3.0);
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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - (-336)) > (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
